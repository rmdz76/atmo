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

namespace Atmo {

	/// <summary>
	/// Represents a connection to a DAQ device.
	/// </summary>
	public interface IDaqConnection {

		/// <summary>
		/// Accesses the sensor at the given index, <paramref name="i"/>.
		/// </summary>
		/// <param name="i">The index of the sensor to access.</param>
		/// <returns>A sensor object (or proxy), or null.</returns>
		ISensor GetSensor(int i);

	}
}