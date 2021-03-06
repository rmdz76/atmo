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
// Contact: Jan Barani mailto:jan@baranidesign.com
//
// ================================================================================

using NUnit.Framework;
using Atmo.Data;
using System;

namespace Atmo.Test {

	[TestFixture]
	public class DaqDataFileInfoTest {
		
		[Test]
		public void TryConvert7ByteDateTimeFromBytesTest() {

			DateTime stamp;
			var result = DaqDataFileInfo.TryConvert7ByteDateTime(new byte[] { 0x07, 0xda, 0x0b, 0x12, 0x13, 0x2e, 0x03 }, 0, out stamp);

			Assert.IsTrue(result);
			Assert.AreEqual(new DateTime(2010, 11, 18, 19, 46, 3), stamp);

		}

		[Test]
		public void TryConvert7ByteDateTimeFromBytesInvalidYearTest() {

			DateTime stamp;
			var result = DaqDataFileInfo.TryConvert7ByteDateTime(new byte[] { 0xff, 0xda, 0x0b, 0x12, 0x13, 0x2e, 0x03 }, 0, out stamp);

			Assert.IsFalse(result);
			Assert.AreEqual(default(DateTime), stamp);

		}

		[Test]
		public void TryConvert7ByteDateTimeFromBytesInvalidMonthTest() {

			DateTime stamp;
			var result = DaqDataFileInfo.TryConvert7ByteDateTime(new byte[] { 0x07, 0xda, 0x0f, 0x12, 0x13, 0x2e, 0x03 }, 0, out stamp);

			Assert.IsFalse(result);
			Assert.AreEqual(default(DateTime), stamp);

		}

		[Test]
		public void TryConvert7ByteDateTimeFromBytesInvalidDayTest() {

			DateTime stamp;
			var result = DaqDataFileInfo.TryConvert7ByteDateTime(new byte[] { 0x07, 0xda, 0x0b, 0xf2, 0x13, 0x2e, 0x03 }, 0, out stamp);

			Assert.IsFalse(result);
			Assert.AreEqual(default(DateTime), stamp);

		}

		[Test]
		public void TryConvert7ByteDateTimeFromBytesInvalidHourTest() {

			DateTime stamp;
			var result = DaqDataFileInfo.TryConvert7ByteDateTime(new byte[] { 0x07, 0xda, 0x0b, 0x12, 0xf3, 0x2e, 0x03 }, 0, out stamp);

			Assert.IsFalse(result);
			Assert.AreEqual(default(DateTime), stamp);

		}

		[Test]
		public void TryConvert7ByteDateTimeFromBytesInvalidMinuteTest() {

			DateTime stamp;
			var result = DaqDataFileInfo.TryConvert7ByteDateTime(new byte[] { 0x07, 0xda, 0x0b, 0x12, 0x03, 0x4e, 0x03 }, 0, out stamp);

			Assert.IsFalse(result);
			Assert.AreEqual(default(DateTime), stamp);

		}

		[Test]
		public void TryConvert7ByteDateTimeFromBytesInvalidSecondTest() {

			DateTime stamp;
			var result = DaqDataFileInfo.TryConvert7ByteDateTime(new byte[] { 0x07, 0xda, 0x0b, 0x12, 0x03, 0x2e, 0x53 }, 0, out stamp);

			Assert.IsFalse(result);
			Assert.AreEqual(default(DateTime), stamp);

		}

	}
}
