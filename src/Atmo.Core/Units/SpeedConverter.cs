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

using System;
using System.Linq.Expressions;

namespace Atmo.Units {
	public class SpeedConverter : ValueConverterBase<SpeedUnit> {

		private static Expression CreateExpression(Expression input, SpeedUnit from, SpeedUnit to) {
			if (from == to) {
				return input;
			}
			// TODO: this would be better as a factor lookup using division or multiplication
			switch (from) {
				case SpeedUnit.MetersPerSec:
					switch (to) {
						case SpeedUnit.MilesPerHour:
							return Expression.Multiply(input, Expression.Constant(2.23693629));
						case SpeedUnit.Knot:
							return Expression.Multiply(input, Expression.Constant(1.94384449));
					}
					break;
				case SpeedUnit.MilesPerHour:
					switch (to) {
						case SpeedUnit.MetersPerSec:
							return Expression.Multiply(input, Expression.Constant(0.44704));
						case SpeedUnit.Knot:
							return Expression.Multiply(input, Expression.Constant(0.868976242));
					}
					break;
				case SpeedUnit.Knot:
					switch (to) {
						case SpeedUnit.MetersPerSec:
							return Expression.Multiply(input, Expression.Constant(0.514444444));
						case SpeedUnit.MilesPerHour:
							return Expression.Multiply(input, Expression.Constant(1.15077945));
					}
					break;
			}
			throw new NotSupportedException(String.Format("No conversion from {0} to {1}.",from,to));
		}

		public readonly Func<double, double> Conversion;

		public SpeedConverter(SpeedUnit from, SpeedUnit to)
			: base(from,to)
		{
			var valueIn = Expression.Parameter(typeof(double), "value");
			Conversion = Expression.Lambda<Func<double, double>>(CreateExpression(valueIn, From, To), valueIn).Compile();
		}

		public override double Convert(double value) {
			return Conversion(value);
		}

		public override Expression GetConversionExpression(Expression input) {
			return CreateExpression(input, From, To);
		}
	}
}
