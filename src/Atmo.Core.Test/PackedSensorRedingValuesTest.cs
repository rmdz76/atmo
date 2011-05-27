﻿// ================================================================================
//
// Atmo 2
// Copyright (C) 2011  BARANI DESIGN
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// 
// Contact: Jan Barani at jan@baranidesign.com
//
// ================================================================================

using NUnit.Framework;

namespace Atmo.Test {
	[TestFixture]
	public class PackedSensorRedingValuesTest {

		public byte[] DeviceSampleData;

		[TestFixtureSetUp]
		public void Setup() {
			DeviceSampleData = new byte[] { 0x39, 0xDF, 0xFD, 0x42, 0xBF, 0x37, 0xED, 0x1B };
		}

		[Test]
		public void FromDeviceRawBytesRawValuesTest() {
			var values = PackedSensorReadingValues.FromDeviceBytes(DeviceSampleData, 0);

			Assert.AreEqual(0x73B, values.RawWindSpeed);
			Assert.AreEqual(0x1ff, values.RawWindDirection);
			Assert.AreEqual(0x285, values.RawTemperature);
			Assert.AreEqual(0x1f9, values.RawHumidity);
			Assert.AreEqual(0xbf68, values.RawPressure);
		}

		[Test]
		public void FromDeviceRawBytesValuesTest() {
			var values = PackedSensorReadingValues.FromDeviceBytes(DeviceSampleData, 0);

			Assert.AreEqual(18.51, values.WindSpeed);
			Assert.AreEqual(511, values.WindDirection);
			Assert.AreEqual(24.5, values.Temperature);
			Assert.AreEqual(.505, values.Humidity);
			Assert.AreEqual(98000, values.Pressure);
		}

	}
}
