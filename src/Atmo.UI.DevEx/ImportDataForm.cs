﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Atmo;
using Atmo.Data;
using System.IO;
using System.Linq;
using Atmo.UI.DevEx.Controls;
using Atmo.Units;


namespace Atmo.UI.DevEx {
    public partial class ImportDataForm : DevExpress.XtraEditors.XtraForm {


        private static IEnumerable<FileInfo> GetAnemFiles(DirectoryInfo folder) {
            return folder.GetFiles()
				.Where(fi => DaqDataFileInfo.AnemFileNameRegex.IsMatch(fi.Name))
                .OrderBy(fi => fi.Name)
            ;
        }

		private static IEnumerable<PackedReading> GetPackedReadings(DaqDataFileInfo fileInfo) {
			using (var file = fileInfo.CreateReader()) {
                while (file.MoveNext()) {
                    yield return file.Current;
                }
            }
        }




		private static IEnumerable<DaqDataFileInfo> GetAnemFileInfos(IEnumerable<FileInfo> fileInfos) {
			return fileInfos.Select(DaqDataFileInfo.Create);
        }


        private IDataStore _dataStore;
		private IDaqConnection _device;
		private Dictionary<int, List<DaqDataFileInfo>> _fileInfosLookup;
		public bool AutoImport { get; set; }


		public ImportDataForm(IDataStore dataStore, IDaqConnection device)
            : base() {
			AutoImport = false;
            _dataStore = dataStore;
            _device = device;
            _fileInfosLookup = null;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonSelectDataFolder_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select a folder containing the data files";
            fbd.ShowNewFolderButton = false;

            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK) {

                textEditFolderPath.Text = fbd.SelectedPath;
				var fileInfos = new List<DaqDataFileInfo>(
                    GetAnemFileInfos(GetAnemFiles(new DirectoryInfo(fbd.SelectedPath))).Where(afi => null != afi)
                );

                SetAnemFileList(fileInfos);

                _fileInfosLookup = fileInfos
                    .GroupBy(afi => afi.Nid)
					.ToDictionary<IGrouping<int, DaqDataFileInfo>, int, List<DaqDataFileInfo>>(
                        g => g.Key,
                        g => g.ToList()
                    )
                ;

                ActivateAnemImportMaps(_fileInfosLookup, _dataStore);

                buttonImport.Enabled = true;
                daqCheckTimer_Tick(null, null);

            }
            else {
                ;
            }
        }

		private void ActivateAnemImportMaps(Dictionary<int, List<DaqDataFileInfo>> fileInfos, IDataStore dataStore) {

            var importAnemMaps = new[] {
                importAnemMap0,
                importAnemMap1,
                importAnemMap2,
                importAnemMap3
            };
            List<ISensorInfo> dbSensorInfos = dataStore.GetAllSensorInfos().ToList();
            string[] dbSensorNamesArray = dbSensorInfos.Select(sim => sim.Name).ToArray();
            for (int i = 0; i < importAnemMaps.Length; i++) {
                var anemMapControl = importAnemMaps[i];
				List<DaqDataFileInfo> afiCollection = null;
                anemMapControl.AnemId = ((char)((byte)('A') + i)).ToString();
                if (fileInfos.TryGetValue(i, out afiCollection) && null != afiCollection && afiCollection.Count > 0) {
                    var minFileStamp = afiCollection.Min(afi => afi.FirstStamp);
                    anemMapControl.StartStamp = minFileStamp;
                    anemMapControl.DatabaseSensorId = dataStore.GetLatestSensorNameForHardwareId(i.ToString()) ?? String.Empty;
                    anemMapControl.SetNameSuggestions(dbSensorNamesArray);
                    anemMapControl.Enabled = true;
                }
                else {
                    anemMapControl.Enabled = false;
                }
            }

        }

		private void SetAnemFileList(IEnumerable<DaqDataFileInfo> fileInfos) {
            listBoxAnemFiles.Items.Clear();
			foreach (DaqDataFileInfo fi in fileInfos) {
                listBoxAnemFiles.Items.Add(fi.ToString());
            }
        }

        private void buttonImport_Click(object sender, EventArgs e) {

            var importAnemMaps = new[] {
                importAnemMap0,
                importAnemMap1,
                importAnemMap2,
                importAnemMap3
            };
            var validMaps = new List<ImportAnemMap>();
            var invalidMaps = new List<ImportAnemMap>();
            for (int i = 0; i < importAnemMaps.Length; i++) {
                var anemMapControl = importAnemMaps[i];
                if (anemMapControl.Enabled && anemMapControl.Checked) {
                    if (anemMapControl.IsValid) {
                        validMaps.Add(anemMapControl);
                    }
                    else {
                        invalidMaps.Add(anemMapControl);
                    }
                }
            }
            if (invalidMaps.Count > 0) {
                MessageBox.Show(
                    "All anemometers selected for import require a database name to be specified.",
                    "Invalid Import Request",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning
                );
                return;
            }
            bool failed = false;
            bool success = false;
            foreach(var map in validMaps){
                
                IEnumerable<PackedReading> packedReadings = _fileInfosLookup[(byte)(Char.Parse(map.AnemId.ToUpper())) - (byte)('A')]
                    .OrderBy(afi => afi.FirstStamp)
                    .SelectMany(afi => GetPackedReadings(afi))
                ;

                ISensorInfo sensor = _dataStore.GetAllSensorInfos().FirstOrDefault(si => String.Equals(si.Name, map.DatabaseSensorId, StringComparison.InvariantCultureIgnoreCase));
                if (null == sensor) {
                    sensor = new SensorInfo(map.DatabaseSensorId, SpeedUnit.MetersPerSec, TemperatureUnit.Celsius, PressureUnit.InchOfMercury);
                    _dataStore.AddSensor(sensor);
                }
                if (_dataStore.Push<PackedReading>(sensor.Name, packedReadings, chkOverwrite.Checked)) {
                    success = true;
                    _dataStore.SetLatestSensorNameForHardwareId(sensor.Name, map.AnemId);
                }
                else {
                    failed = true;
                }
            }

            if (failed || !success) {
                MessageBox.Show(
                    "Data import failed.",
                    "Import Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }else{
                if (syncChk.Checked && null != _device && _device.IsConnected) {
                    DateTime cpuTime = DateTime.Now;
                    bool clockOk = _device.SetClock(cpuTime);
                    //bool noData = false;
                    if (clockOk) {
                        DateTime minSyncStamp = _dataStore.GetMaxSyncStamp().AddSeconds(1.0);
                        if (default(DateTime).Equals(minSyncStamp)) {
                            MessageBox.Show(
                                "No data was found to be adjusted but DAQ clock syncronization was successful.",
                                "Notice",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                        else {
                            // todo: show progress bar and tell them the device and data are no longer needed at this time
                            DateTime daqTime = _device.QueryClock();
                            foreach (ISensorInfo si in _dataStore.GetAllSensorInfos()) {
                                _dataStore.AdjustTimeStamps(si.Name, new TimeRange(minSyncStamp, daqTime), new TimeRange(minSyncStamp, cpuTime));
                            }
                            _dataStore.PushSyncStamp(cpuTime);
                            // todo: hide that progress bar/dialog/message
                            MessageBox.Show(
                                "Data import and time synchronization completed successfully.",
                                "Import and synchronization Complete",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                    }
                    else {
                        MessageBox.Show(
                            "DAQ clock failed to synchronize.",
                            "Notice",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
                else {
                    MessageBox.Show(
                        "Data import completed successfully.",
                        "Import Complete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }



        }

        private void daqCheckTimer_Tick(object sender, EventArgs e) {
            syncChk.Enabled = null != _device
                &&  null != _fileInfosLookup
                && _fileInfosLookup.Any()
                && _device.IsConnected
            ;
        }

        private void ImportDataForm_Load(object sender, EventArgs e) {
            //syncChk.Checked = null != _device && _device.IsConnected;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(ReconnectSD), _device);

        }


        public void ReconnectSD(object state)
        {
			var device = (state as IDaqConnection);
            if (null != device)
            {
                device.ReconnectMedia();
            }
        }
    }
}