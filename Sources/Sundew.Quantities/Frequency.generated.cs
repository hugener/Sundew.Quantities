﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Frequency.generated.cs" company="Hukano">
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
    public partial struct Frequency : IQuantity<Frequency, FrequencyUnitSelector>
    {
        private readonly double value;

        public Frequency(double value, SelectUnit<FrequencyUnitSelector> unitSelector)
            : this(value,  UnitBuilder.BuildUnit(unitSelector(new FrequencyUnitSelector())))
        {
        }

        public Frequency(IQuantity quantity)
            : this(quantity.Value, quantity.Unit)
        {
        }

        public Frequency(double value)
            : this(value, units => units.BaseUnit)
        {
        }

        public Frequency(double value, IUnit unit)
        {
            this.value = value;
            this.Unit = unit;
        }

        double IQuantity.Value => this.value;

        public IUnit Unit { get; }

        public static Frequency operator +(Frequency quantity)
        {
            return quantity;
        }

        public static Frequency operator -(Frequency quantity)
        {
            return new Frequency(-quantity.value, quantity.Unit);
        }

        public static Frequency operator ++(Frequency quantity)
        {
            return new Frequency(quantity.value + 1, quantity.Unit);
        }

        public static Frequency operator --(Frequency quantity)
        {
            return new Frequency(quantity.value - 1, quantity.Unit);
        }

        public static Frequency operator +(Frequency lhs, double rhs)
        {
            return new Frequency(lhs.value + rhs, lhs.Unit);
        }

        public static Frequency operator -(Frequency lhs, double rhs)
        {
            return new Frequency(lhs.value - rhs, lhs.Unit);
        }

        public static Frequency operator *(Frequency lhs, double rhs)
        {
            return new Frequency(lhs.value * rhs, lhs.Unit);
        }

        public static Frequency operator /(Frequency lhs, double rhs)
        {
            return new Frequency(lhs.value / rhs, lhs.Unit);
        }

        public static Frequency operator +(Frequency lhs, Frequency rhs)
        {
            return new Frequency(QuantityOperations.Add(lhs, rhs));
        }

        public static Frequency operator -(Frequency lhs, Frequency rhs)
        {
            return new Frequency(QuantityOperations.Subtract(lhs, rhs));
        }

        public static double operator /(Frequency lhs, Frequency rhs)
        {
            return QuantityOperations.Divide(lhs, rhs).Value;
        }

        public static bool operator ==(Frequency lhs, Frequency rhs)
        {
            return QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator !=(Frequency lhs, Frequency rhs)
        {
            return !QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator >=(Frequency lhs, Frequency rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) >= 0;
        }

        public static bool operator <=(Frequency lhs, Frequency rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) <= 0;
        }

        public static bool operator >(Frequency lhs, Frequency rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) > 0;
        }

        public static bool operator <(Frequency lhs, Frequency rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) < 0;
        }

        public static Interval<Frequency> Interval(double min, double max, SelectUnit<FrequencyUnitSelector> unitSelector)
        {
            return new Interval<Frequency>(min, max, unitSelector(new FrequencyUnitSelector()));
        }

        public Squared<Frequency> Squared()
        {
            return new Squared<Frequency>(this);
        }

        public Cubed<Frequency> Cubed()
        {
            return new Cubed<Frequency>(this);
        }

        public double ToDouble(IUnit unit)
        {
            return QuantityOperations.ConvertToUnit(this, unit);
        }

        public IQuantity ToQuantity(IUnit unit)
        {
            return this.ToUnit(unit);
        }

        public Frequency ToUnit(IUnit unit)
        {
            return new Frequency(this.ToDouble(unit), unit);
        }

        public Frequency ToUnit(SelectUnit<FrequencyUnitSelector> unitSelector)
        {
            return this.ToUnit(UnitBuilder.BuildUnit(unitSelector(new FrequencyUnitSelector())));
        }

        public double ToDouble(SelectUnit<FrequencyUnitSelector> unitSelector)
        {
            return this.ToDouble(UnitBuilder.BuildUnit(unitSelector(new FrequencyUnitSelector())));
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

        public bool Equals(Frequency quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        public int CompareTo(object obj)
        {
            return QuantityHelper.CompareTo<Frequency>(this, obj);
        }

        public int CompareTo(IQuantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        public int CompareTo(Frequency quantity)
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

        public Frequency CreateQuantity(double value, IUnit unit)
        {
            return new Frequency(value, unit);
        }

        IQuantity IDeferredQuantity.GetResult()
        {
            return this;
        }

        FrequencyUnitSelector IQuantity<Frequency, FrequencyUnitSelector>.CreateUnitSelector()
        {
            return new FrequencyUnitSelector();
        }
    }
}