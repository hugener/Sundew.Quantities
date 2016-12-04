﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Charge.generated.cs" company="Hukano">
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
    public partial struct Charge : IQuantity<Charge, ChargeUnitSelector>
    {
        private readonly double value;

        public Charge(double value, SelectUnit<ChargeUnitSelector> unitSelector)
            : this(value,  UnitBuilder.BuildUnit(unitSelector(new ChargeUnitSelector())))
        {
        }

        public Charge(IQuantity quantity)
            : this(quantity.Value, quantity.Unit)
        {
        }

        public Charge(double value)
            : this(value, units => units.BaseUnit)
        {
        }

        public Charge(double value, IUnit unit)
        {
            this.value = value;
            this.Unit = unit;
        }

        double IQuantity.Value => this.value;

        public IUnit Unit { get; }

        public static Charge operator +(Charge quantity)
        {
            return quantity;
        }

        public static Charge operator -(Charge quantity)
        {
            return new Charge(-quantity.value, quantity.Unit);
        }

        public static Charge operator ++(Charge quantity)
        {
            return new Charge(quantity.value + 1, quantity.Unit);
        }

        public static Charge operator --(Charge quantity)
        {
            return new Charge(quantity.value - 1, quantity.Unit);
        }

        public static Charge operator +(Charge lhs, double rhs)
        {
            return new Charge(lhs.value + rhs, lhs.Unit);
        }

        public static Charge operator -(Charge lhs, double rhs)
        {
            return new Charge(lhs.value - rhs, lhs.Unit);
        }

        public static Charge operator *(Charge lhs, double rhs)
        {
            return new Charge(lhs.value * rhs, lhs.Unit);
        }

        public static Charge operator /(Charge lhs, double rhs)
        {
            return new Charge(lhs.value / rhs, lhs.Unit);
        }

        public static Charge operator +(Charge lhs, Charge rhs)
        {
            return new Charge(QuantityOperations.Add(lhs, rhs));
        }

        public static Charge operator -(Charge lhs, Charge rhs)
        {
            return new Charge(QuantityOperations.Subtract(lhs, rhs));
        }

        public static double operator /(Charge lhs, Charge rhs)
        {
            return QuantityOperations.Divide(lhs, rhs).Value;
        }

        public static bool operator ==(Charge lhs, Charge rhs)
        {
            return QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator !=(Charge lhs, Charge rhs)
        {
            return !QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator >=(Charge lhs, Charge rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) >= 0;
        }

        public static bool operator <=(Charge lhs, Charge rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) <= 0;
        }

        public static bool operator >(Charge lhs, Charge rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) > 0;
        }

        public static bool operator <(Charge lhs, Charge rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) < 0;
        }

        public static Interval<Charge> Interval(double min, double max, SelectUnit<ChargeUnitSelector> unitSelector)
        {
            return new Interval<Charge>(min, max, unitSelector(new ChargeUnitSelector()));
        }

        public Squared<Charge> Squared()
        {
            return new Squared<Charge>(this);
        }

        public Cubed<Charge> Cubed()
        {
            return new Cubed<Charge>(this);
        }

        public double ToDouble(IUnit unit)
        {
            return QuantityOperations.ConvertToUnit(this, unit);
        }

        public IQuantity ToQuantity(IUnit unit)
        {
            return this.ToUnit(unit);
        }

        public Charge ToUnit(IUnit unit)
        {
            return new Charge(this.ToDouble(unit), unit);
        }

        public Charge ToUnit(SelectUnit<ChargeUnitSelector> unitSelector)
        {
            return this.ToUnit(UnitBuilder.BuildUnit(unitSelector(new ChargeUnitSelector())));
        }

        public double ToDouble(SelectUnit<ChargeUnitSelector> unitSelector)
        {
            return this.ToDouble(UnitBuilder.BuildUnit(unitSelector(new ChargeUnitSelector())));
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

        public bool Equals(Charge quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        public int CompareTo(object obj)
        {
            return QuantityHelper.CompareTo<Charge>(this, obj);
        }

        public int CompareTo(IQuantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        public int CompareTo(Charge quantity)
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

        public Charge CreateQuantity(double value, IUnit unit)
        {
            return new Charge(value, unit);
        }

        IQuantity IDeferredQuantity.GetResult()
        {
            return this;
        }

        ChargeUnitSelector IQuantity<Charge, ChargeUnitSelector>.CreateUnitSelector()
        {
            return new ChargeUnitSelector();
        }
    }
}