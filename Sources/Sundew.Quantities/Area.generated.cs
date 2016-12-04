﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Area.generated.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// <auto-generated />
namespace Sundew.Quantities
{
    using global::Sundew.Quantities.Engine;
    using global::Sundew.Quantities.Engine.Quantities;
    using global::Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using global::Sundew.Quantities.Engine.UnitSelection;
    using global::Sundew.Quantities.UnitSelection;
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Globalization;

    [GeneratedCode("Sundew.Quantities.Generator", "1.0.0.0")]
    public partial struct Area : IQuantity<Area, DistanceUnitSelector>
    {
        private readonly double value;

        public Area(double value, SelectUnit<DistanceUnitSelector> unitSelector)
            : this(value,  UnitBuilder.BuildUnit(unitSelector(new DistanceUnitSelector())))
        {
        }

        public Area(IQuantity quantity)
            : this(quantity.Value, quantity.Unit)
        {
        }

        public Area(double value)
            : this(value, units => units.BaseUnit)
        {
        }

        public Area(double value, IUnit unit)
        {
            this.value = value;
            this.Unit = unit;
        }

        double IQuantity.Value => this.value;

        public IUnit Unit { get; }

        public static Area operator +(Area quantity)
        {
            return quantity;
        }

        public static Area operator -(Area quantity)
        {
            return new Area(-quantity.value, quantity.Unit);
        }

        public static Area operator ++(Area quantity)
        {
            return new Area(quantity.value + 1, quantity.Unit);
        }

        public static Area operator --(Area quantity)
        {
            return new Area(quantity.value - 1, quantity.Unit);
        }

        public static Area operator +(Area lhs, double rhs)
        {
            return new Area(lhs.value + rhs, lhs.Unit);
        }

        public static Area operator -(Area lhs, double rhs)
        {
            return new Area(lhs.value - rhs, lhs.Unit);
        }

        public static Area operator *(Area lhs, double rhs)
        {
            return new Area(lhs.value * rhs, lhs.Unit);
        }

        public static Area operator /(Area lhs, double rhs)
        {
            return new Area(lhs.value / rhs, lhs.Unit);
        }

        public static Area operator +(Area lhs, Area rhs)
        {
            return new Area(QuantityOperations.Add(lhs, rhs));
        }

        public static Area operator -(Area lhs, Area rhs)
        {
            return new Area(QuantityOperations.Subtract(lhs, rhs));
        }

        public static double operator /(Area lhs, Area rhs)
        {
            return QuantityOperations.Divide(lhs, rhs).Value;
        }

        public static bool operator ==(Area lhs, Area rhs)
        {
            return QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator !=(Area lhs, Area rhs)
        {
            return !QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator >=(Area lhs, Area rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) >= 0;
        }

        public static bool operator <=(Area lhs, Area rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) <= 0;
        }

        public static bool operator >(Area lhs, Area rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) > 0;
        }

        public static bool operator <(Area lhs, Area rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) < 0;
        }

        public static Interval<Area> Interval(double min, double max, SelectUnit<DistanceUnitSelector> unitSelector)
        {
            return new Interval<Area>(min, max, unitSelector(new DistanceUnitSelector()));
        }

        public Squared<Area> Squared()
        {
            return new Squared<Area>(this);
        }

        public Cubed<Area> Cubed()
        {
            return new Cubed<Area>(this);
        }

        public double ToDouble(IUnit unit)
        {
            return QuantityOperations.ConvertToUnit(this, unit);
        }

        public IQuantity ToQuantity(IUnit unit)
        {
            return this.ToUnit(unit);
        }

        public Area ToUnit(IUnit unit)
        {
            return new Area(this.ToDouble(unit), unit);
        }

        public Area ToUnit(SelectUnit<DistanceUnitSelector> unitSelector)
        {
            return this.ToUnit(UnitBuilder.BuildUnit(unitSelector(new DistanceUnitSelector())));
        }

        public double ToDouble(SelectUnit<DistanceUnitSelector> unitSelector)
        {
            return this.ToDouble(UnitBuilder.BuildUnit(unitSelector(new DistanceUnitSelector())));
        }

        public override int GetHashCode()
        {
            return QuantityHelper.GetHashCode(this);
        }

        public override bool Equals(object obj)
        {
            return QuantityHelper.AreEqual(this, obj);
        }

        public bool Equals(IQuantity quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        public bool Equals(Area quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        public int CompareTo(object obj)
        {
            return QuantityHelper.CompareTo<Area>(this, obj);
        }

        public int CompareTo(IQuantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        public int CompareTo(Area quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        public override string ToString()
        {
            return this.ToString(CultureInfo.CurrentCulture);
        }

        public string ToString(UnitFormat unitFormat)
        {
            return this.ToString(unitFormat, null, CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(IFormatProvider formatProvider)
        {
            return this.ToString(null, formatProvider);
        }

        public string ToString(UnitFormat unitFormat, string format)
        {
            return this.ToString(unitFormat, format, CultureInfo.CurrentCulture);
        }

        public string ToString(UnitFormat unitFormat, IFormatProvider formatProvider)
        {
            return this.ToString(unitFormat, null, formatProvider);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return this.ToString(UnitFormat.Default, format, formatProvider);
        }

        public string ToString(UnitFormat unitFormat, string format, IFormatProvider formatProvider)
        {
            return QuantityHelper.ToString(
                this.Unit.FormatValue(this.value, format, formatProvider),
                UnitHelper.GetNotation(this.Unit, unitFormat));
        }

        public Area CreateQuantity(double value, IUnit unit)
        {
            return new Area(value, unit);
        }

        IQuantity IDeferredQuantity.GetResult()
        {
            return this;
        }

        DistanceUnitSelector IQuantity<Area, DistanceUnitSelector>.CreateUnitSelector()
        {
            return new DistanceUnitSelector();
        }
    }
}