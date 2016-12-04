﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Volume.generated.cs" company="Hukano">
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
    public partial struct Volume : IQuantity<Volume, VolumeUnitSelector>
    {
        private readonly double value;

        public Volume(double value, SelectUnit<VolumeUnitSelector> unitSelector)
            : this(value,  UnitBuilder.BuildUnit(unitSelector(new VolumeUnitSelector())))
        {
        }

        public Volume(IQuantity quantity)
            : this(quantity.Value, quantity.Unit)
        {
        }

        public Volume(double value)
            : this(value, units => units.BaseUnit)
        {
        }

        public Volume(double value, IUnit unit)
        {
            this.value = value;
            this.Unit = unit;
        }

        double IQuantity.Value => this.value;

        public IUnit Unit { get; }

        public static Volume operator +(Volume quantity)
        {
            return quantity;
        }

        public static Volume operator -(Volume quantity)
        {
            return new Volume(-quantity.value, quantity.Unit);
        }

        public static Volume operator ++(Volume quantity)
        {
            return new Volume(quantity.value + 1, quantity.Unit);
        }

        public static Volume operator --(Volume quantity)
        {
            return new Volume(quantity.value - 1, quantity.Unit);
        }

        public static Volume operator +(Volume lhs, double rhs)
        {
            return new Volume(lhs.value + rhs, lhs.Unit);
        }

        public static Volume operator -(Volume lhs, double rhs)
        {
            return new Volume(lhs.value - rhs, lhs.Unit);
        }

        public static Volume operator *(Volume lhs, double rhs)
        {
            return new Volume(lhs.value * rhs, lhs.Unit);
        }

        public static Volume operator /(Volume lhs, double rhs)
        {
            return new Volume(lhs.value / rhs, lhs.Unit);
        }

        public static Volume operator +(Volume lhs, Volume rhs)
        {
            return new Volume(QuantityOperations.Add(lhs, rhs));
        }

        public static Volume operator -(Volume lhs, Volume rhs)
        {
            return new Volume(QuantityOperations.Subtract(lhs, rhs));
        }

        public static double operator /(Volume lhs, Volume rhs)
        {
            return QuantityOperations.Divide(lhs, rhs).Value;
        }

        public static bool operator ==(Volume lhs, Volume rhs)
        {
            return QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator !=(Volume lhs, Volume rhs)
        {
            return !QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator >=(Volume lhs, Volume rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) >= 0;
        }

        public static bool operator <=(Volume lhs, Volume rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) <= 0;
        }

        public static bool operator >(Volume lhs, Volume rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) > 0;
        }

        public static bool operator <(Volume lhs, Volume rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) < 0;
        }

        public static Interval<Volume> Interval(double min, double max, SelectUnit<VolumeUnitSelector> unitSelector)
        {
            return new Interval<Volume>(min, max, unitSelector(new VolumeUnitSelector()));
        }

        public Squared<Volume> Squared()
        {
            return new Squared<Volume>(this);
        }

        public Cubed<Volume> Cubed()
        {
            return new Cubed<Volume>(this);
        }

        public double ToDouble(IUnit unit)
        {
            return QuantityOperations.ConvertToUnit(this, unit);
        }

        public IQuantity ToQuantity(IUnit unit)
        {
            return this.ToUnit(unit);
        }

        public Volume ToUnit(IUnit unit)
        {
            return new Volume(this.ToDouble(unit), unit);
        }

        public Volume ToUnit(SelectUnit<VolumeUnitSelector> unitSelector)
        {
            return this.ToUnit(UnitBuilder.BuildUnit(unitSelector(new VolumeUnitSelector())));
        }

        public double ToDouble(SelectUnit<VolumeUnitSelector> unitSelector)
        {
            return this.ToDouble(UnitBuilder.BuildUnit(unitSelector(new VolumeUnitSelector())));
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

        public bool Equals(Volume quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        public int CompareTo(object obj)
        {
            return QuantityHelper.CompareTo<Volume>(this, obj);
        }

        public int CompareTo(IQuantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        public int CompareTo(Volume quantity)
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

        public Volume CreateQuantity(double value, IUnit unit)
        {
            return new Volume(value, unit);
        }

        IQuantity IDeferredQuantity.GetResult()
        {
            return this;
        }

        VolumeUnitSelector IQuantity<Volume, VolumeUnitSelector>.CreateUnitSelector()
        {
            return new VolumeUnitSelector();
        }
    }
}