﻿namespace Atmo.UI.DevEx.Controls {
	partial class WindResourceGraph {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY1 = new DevExpress.XtraCharts.SecondaryAxisY();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
			DevExpress.XtraCharts.SplineAreaSeriesView splineAreaSeriesView1 = new DevExpress.XtraCharts.SplineAreaSeriesView();
			DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
			DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
			DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
			DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
			DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
			DevExpress.XtraCharts.SplineAreaSeriesView splineAreaSeriesView2 = new DevExpress.XtraCharts.SplineAreaSeriesView();
			DevExpress.XtraCharts.PolarDiagram polarDiagram1 = new DevExpress.XtraCharts.PolarDiagram();
			DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.RadarPointSeriesLabel radarPointSeriesLabel1 = new DevExpress.XtraCharts.RadarPointSeriesLabel();
			DevExpress.XtraCharts.PolarAreaSeriesView polarAreaSeriesView1 = new DevExpress.XtraCharts.PolarAreaSeriesView();
			DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.RadarPointSeriesLabel radarPointSeriesLabel2 = new DevExpress.XtraCharts.RadarPointSeriesLabel();
			DevExpress.XtraCharts.PolarAreaSeriesView polarAreaSeriesView2 = new DevExpress.XtraCharts.PolarAreaSeriesView();
			DevExpress.XtraCharts.RadarPointSeriesLabel radarPointSeriesLabel3 = new DevExpress.XtraCharts.RadarPointSeriesLabel();
			DevExpress.XtraCharts.PolarAreaSeriesView polarAreaSeriesView3 = new DevExpress.XtraCharts.PolarAreaSeriesView();
			this.bindingSourceWindSpeedFreq = new System.Windows.Forms.BindingSource(this.components);
			this.chartControlWindSpeedFreq = new DevExpress.XtraCharts.ChartControl();
			this.chartControlWindDir = new DevExpress.XtraCharts.ChartControl();
			this.bindingSourceWindDir = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceWindSpeedFreq)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControlWindSpeedFreq)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(splineAreaSeriesView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(splineAreaSeriesView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControlWindDir)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(polarDiagram1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(polarAreaSeriesView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(polarAreaSeriesView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(polarAreaSeriesView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceWindDir)).BeginInit();
			this.SuspendLayout();
			// 
			// bindingSourceWindSpeedFreq
			// 
			this.bindingSourceWindSpeedFreq.DataSource = typeof(Atmo.Stats.WindSpeedFrequency);
			// 
			// chartControlWindSpeedFreq
			// 
			this.chartControlWindSpeedFreq.AppearanceName = "The Trees";
			this.chartControlWindSpeedFreq.DataSource = this.bindingSourceWindSpeedFreq;
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
			xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
			xyDiagram1.AxisX.ScaleBreakOptions.Style = DevExpress.XtraCharts.ScaleBreakStyle.Straight;
			xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
			xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
			secondaryAxisY1.AxisID = 0;
			secondaryAxisY1.Name = "Secondary AxisY 1";
			secondaryAxisY1.Range.ScrollingRange.SideMarginsEnabled = true;
			secondaryAxisY1.Range.SideMarginsEnabled = true;
			secondaryAxisY1.VisibleInPanesSerializable = "-1";
			xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1});
			this.chartControlWindSpeedFreq.Diagram = xyDiagram1;
			this.chartControlWindSpeedFreq.Dock = System.Windows.Forms.DockStyle.Top;
			this.chartControlWindSpeedFreq.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
			this.chartControlWindSpeedFreq.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
			this.chartControlWindSpeedFreq.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
			this.chartControlWindSpeedFreq.Legend.EquallySpacedItems = false;
			this.chartControlWindSpeedFreq.Legend.Shadow.Visible = true;
			this.chartControlWindSpeedFreq.Location = new System.Drawing.Point(0, 0);
			this.chartControlWindSpeedFreq.Name = "chartControlWindSpeedFreq";
			series1.ArgumentDataMember = "SpeedPropertty";
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
			series1.DataSource = this.bindingSourceWindSpeedFreq;
			pointSeriesLabel1.LineVisible = true;
			pointSeriesLabel1.Visible = false;
			series1.Label = pointSeriesLabel1;
			series1.Name = "Wind Energy";
			series1.ValueDataMembersSerializable = "Energy";
			splineAreaSeriesView1.AxisYName = "Secondary AxisY 1";
			splineAreaSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(64)))));
			splineAreaSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
			splineAreaSeriesView1.MarkerOptions.Visible = false;
			splineAreaSeriesView1.Transparency = ((byte)(120));
			series1.View = splineAreaSeriesView1;
			series2.ArgumentDataMember = "SpeedPropertty";
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
			series2.DataSource = this.bindingSourceWindSpeedFreq;
			sideBySideBarSeriesLabel1.LineVisible = true;
			sideBySideBarSeriesLabel1.Visible = false;
			series2.Label = sideBySideBarSeriesLabel1;
			series2.Name = "Wind Speed Frequency";
			series2.ValueDataMembersSerializable = "FrequencyProperty";
			sideBySideBarSeriesView1.BarWidth = 1D;
			sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))), ((int)(((byte)(228)))));
			sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
			series2.View = sideBySideBarSeriesView1;
			series3.ArgumentDataMember = "SpeedPropertty";
			series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
			series3.DataSource = this.bindingSourceWindSpeedFreq;
			pointSeriesLabel2.LineVisible = true;
			pointSeriesLabel2.Visible = false;
			series3.Label = pointSeriesLabel2;
			series3.LegendText = "Beta: NaN Theta: NaN";
			series3.Name = "Weibull";
			series3.ValueDataMembersSerializable = "WeibullProperty";
			splineSeriesView1.Color = System.Drawing.Color.Red;
			splineSeriesView1.LineMarkerOptions.Visible = false;
			splineSeriesView1.LineStyle.Thickness = 1;
			series3.View = splineSeriesView1;
			this.chartControlWindSpeedFreq.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
			pointSeriesLabel3.LineVisible = true;
			this.chartControlWindSpeedFreq.SeriesTemplate.Label = pointSeriesLabel3;
			splineAreaSeriesView2.Transparency = ((byte)(0));
			this.chartControlWindSpeedFreq.SeriesTemplate.View = splineAreaSeriesView2;
			this.chartControlWindSpeedFreq.SideBySideBarDistanceFixed = 0;
			this.chartControlWindSpeedFreq.SideBySideEqualBarWidth = true;
			this.chartControlWindSpeedFreq.Size = new System.Drawing.Size(898, 203);
			this.chartControlWindSpeedFreq.TabIndex = 0;
			// 
			// chartControlWindDir
			// 
			polarDiagram1.AxisX.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
			polarDiagram1.AxisX.NumericOptions.Precision = 0;
			polarDiagram1.AxisY.MinorCount = 1;
			polarDiagram1.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent;
			polarDiagram1.AxisY.NumericOptions.Precision = 1;
			polarDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
			polarDiagram1.AxisY.Range.SideMarginsEnabled = true;
			polarDiagram1.RotationDirection = DevExpress.XtraCharts.RadarDiagramRotationDirection.Clockwise;
			this.chartControlWindDir.Diagram = polarDiagram1;
			this.chartControlWindDir.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartControlWindDir.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
			this.chartControlWindDir.Legend.HorizontalIndent = 2;
			this.chartControlWindDir.Legend.Padding.Bottom = 1;
			this.chartControlWindDir.Legend.Padding.Left = 1;
			this.chartControlWindDir.Legend.Padding.Right = 1;
			this.chartControlWindDir.Legend.Padding.Top = 1;
			this.chartControlWindDir.Legend.Shadow.Visible = true;
			this.chartControlWindDir.Legend.TextOffset = 1;
			this.chartControlWindDir.Legend.VerticalIndent = 1;
			this.chartControlWindDir.Location = new System.Drawing.Point(0, 203);
			this.chartControlWindDir.Name = "chartControlWindDir";
			series4.ArgumentDataMember = "DirectionProperty";
			series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
			series4.DataSource = this.bindingSourceWindDir;
			radarPointSeriesLabel1.LineVisible = true;
			radarPointSeriesLabel1.Visible = false;
			series4.Label = radarPointSeriesLabel1;
			series4.Name = "Wind From Direction";
			series4.ValueDataMembersSerializable = "FrequencyProperty";
			polarAreaSeriesView1.Border.Visible = false;
			polarAreaSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			polarAreaSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
			polarAreaSeriesView1.MarkerOptions.Visible = false;
			series4.View = polarAreaSeriesView1;
			series5.ArgumentDataMember = "DirectionProperty";
			series5.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
			series5.DataSource = this.bindingSourceWindDir;
			radarPointSeriesLabel2.LineVisible = true;
			radarPointSeriesLabel2.Visible = false;
			series5.Label = radarPointSeriesLabel2;
			series5.Name = "Energy From Direction";
			series5.ValueDataMembersSerializable = "EnergyProperty";
			polarAreaSeriesView2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			polarAreaSeriesView2.MarkerOptions.Visible = false;
			polarAreaSeriesView2.Transparency = ((byte)(200));
			series5.View = polarAreaSeriesView2;
			this.chartControlWindDir.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4,
        series5};
			this.chartControlWindDir.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
			radarPointSeriesLabel3.LineVisible = true;
			this.chartControlWindDir.SeriesTemplate.Label = radarPointSeriesLabel3;
			polarAreaSeriesView3.Transparency = ((byte)(0));
			this.chartControlWindDir.SeriesTemplate.View = polarAreaSeriesView3;
			this.chartControlWindDir.Size = new System.Drawing.Size(898, 676);
			this.chartControlWindDir.TabIndex = 1;
			// 
			// bindingSourceWindDir
			// 
			this.bindingSourceWindDir.DataSource = typeof(Atmo.Stats.WindDirectionEnergy);
			// 
			// WindResourceGraph
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.chartControlWindDir);
			this.Controls.Add(this.chartControlWindSpeedFreq);
			this.Name = "WindResourceGraph";
			this.Size = new System.Drawing.Size(898, 879);
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceWindSpeedFreq)).EndInit();
			((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(splineAreaSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(splineAreaSeriesView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControlWindSpeedFreq)).EndInit();
			((System.ComponentModel.ISupportInitialize)(polarDiagram1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(polarAreaSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(polarAreaSeriesView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(radarPointSeriesLabel3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(polarAreaSeriesView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControlWindDir)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceWindDir)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraCharts.ChartControl chartControlWindSpeedFreq;
		private System.Windows.Forms.BindingSource bindingSourceWindSpeedFreq;
		private DevExpress.XtraCharts.ChartControl chartControlWindDir;
		private System.Windows.Forms.BindingSource bindingSourceWindDir;
	}
}
