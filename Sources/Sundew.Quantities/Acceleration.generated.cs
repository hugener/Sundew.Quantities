﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Acceleration.generated.cs" company="Hukano">
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
    public partial struct Acceleration : IQuantity<Acceleration, AccelerationUnitSelector>
    {
        private readonly double value;

        public Acceleration(double value, SelectUnit<AccelerationUnitSelector> unitSelector)
            : this(value,  UnitBuilder.BuildUnit(unitSelector(new AccelerationUnitSelector())))
        {
        }

        public Acceleration(IQuantity quantity)
            : this(quantity.Value, quantity.Unit)
        {
        }

        public Acceleration(double value)
            : this(value, units => units.BaseUnit)
        {
        }

        public Acceleration(double value, IUnit unit)
        {
            this.value = value;
            this.Unit = unit;
        }

        double IQuantity.Value => this.value;

        public IUnit Unit { get; }

        public static Acceleration operator +(Acceleration quantity)
        {
            return quantity;
        }

        public static Acceleration operator -(Acceleration quantity)
        {
            return new Acceleration(-quantity.value, quantity.Unit);
        }

        public static Acceleration operator ++(Acceleration quantity)
        {
            return new Acceleration(quantity.value + 1, quantity.Unit);
        }

        public static Acceleration operator --(Acceleration quantity)
        {
            return new Acceleration(quantity.value - 1, quantity.Unit);
        }

        public static Acceleration operator +(Acceleration lhs, double rhs)
        {
            return new Acceleration(lhs.value + rhs, lhs.Unit);
        }

        public static Acceleration operator -(Acceleration lhs, double rhs)
        {
            return new Acceleration(lhs.value - rhs, lhs.Unit);
        }

        public static Acceleration operator *(Acceleration lhs, double rhs)
        {
            return new Acceleration(lhs.value * rhs, lhs.Unit);
        }

        public static Acceleration operator /(Acceleration lhs, double rhs)
        {
            return new Acceleration(lhs.value / rhs, lhs.Unit);
        }

        public static Acceleration operator +(Acceleration lhs, Acceleration rhs)
        {
            return new Acceleration(QuantityOperations.Add(lhs, rhs));
        }

        public static Acceleration operator -(Acceleration lhs, Acceleration rhs)
        {
            return new Acceleration(QuantityOperations.Subtract(lhs, rhs));
        }

        public static double operator /(Acceleration lhs, Acceleration rhs)
        {
            return QuantityOperations.Divide(lhs, rhs).Value;
        }

        public static bool operator ==(Acceleration lhs, Acceleration rhs)
        {
            return QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator !=(Acceleration lhs, Acceleration rhs)
        {
            return !QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator >=(Acceleration lhs, Acceleration rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) >= 0;
        }

        public static bool operator <=(Acceleration lhs, Acceleration rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) <= 0;
        }

        public static bool operator >(Acceleration lhs, Acceleration rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) > 0;
        }

        public static bool operator <(Acceleration lhs, Acceleration rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) < 0;
        }

        public static Interval<Acceleration> Interval(double min, double max, SelectUnit<AccelerationUnitSelector> unitSelector)
        {
            return new Interval<Acceleration>(min, max, unitSelector(new AccelerationUnitSelector()));
        }

        public Squared<Acceleration> Squared()
        {
            return new Squared<Acceleration>(this);
        }

        public Cubed<Acceleration> Cubed()
        {
            return new Cubed<Acceleration>(this);
        }

        public double ToDouble(IUnit unit)
        {
            return QuantityOperations.ConvertToUnit(this, unit);
        }

        public IQuantity ToQuantity(IUnit unit)
        {
            return this.ToUnit(unit);
        }

        public Acceleration ToUnit(IUnit unit)
        {
            return new Acceleration(this.ToDouble(unit), unit);
        }

        public Acceleration ToUnit(SelectUnit<AccelerationUnitSelector> unitSelector)
        {
            return this.ToUnit(UnitBuilder.BuildUnit(unitSelector(new AccelerationUnitSelector())));
        }

        public double ToDouble(SelectUnit<AccelerationUnitSelector> unitSelector)
        {
            return this.ToDouble(UnitBuilder.BuildUnit(unitSelector(new AccelerationUnitSelector())));
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

        public bool Equals(Acceleration quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        public int CompareTo(object obj)
        {
            return QuantityHelper.CompareTo<Acceleration>(this, obj);
        }

        public int CompareTo(IQuantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        public int CompareTo(Acceleration quantity)
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

        public Acceleration CreateQuantity(double value, IUnit unit)
        {
            return new Acceleration(value, unit);
        }

        IQuantity IDeferredQuantity.GetResult()
        {
            return this;
        }

        AccelerationUnitSelector IQuantity<Acceleration, AccelerationUnitSelector>.CreateUnitSelector()
        {
            return new AccelerationUnitSelector();
        }
    }
}