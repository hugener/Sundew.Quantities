﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Velocity.generated.cs" company="Hukano">
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
    public partial struct Velocity : IQuantity<Velocity, VelocityUnitSelector>
    {
        private readonly double value;

        public Velocity(double value, SelectUnit<VelocityUnitSelector> unitSelector)
            : this(value,  UnitBuilder.BuildUnit(unitSelector(new VelocityUnitSelector())))
        {
        }

        public Velocity(IQuantity quantity)
            : this(quantity.Value, quantity.Unit)
        {
        }

        public Velocity(double value)
            : this(value, units => units.BaseUnit)
        {
        }

        public Velocity(double value, IUnit unit)
        {
            this.value = value;
            this.Unit = unit;
        }

        double IQuantity.Value => this.value;

        public IUnit Unit { get; }

        public static Velocity operator +(Velocity quantity)
        {
            return quantity;
        }

        public static Velocity operator -(Velocity quantity)
        {
            return new Velocity(-quantity.value, quantity.Unit);
        }

        public static Velocity operator ++(Velocity quantity)
        {
            return new Velocity(quantity.value + 1, quantity.Unit);
        }

        public static Velocity operator --(Velocity quantity)
        {
            return new Velocity(quantity.value - 1, quantity.Unit);
        }

        public static Velocity operator +(Velocity lhs, double rhs)
        {
            return new Velocity(lhs.value + rhs, lhs.Unit);
        }

        public static Velocity operator -(Velocity lhs, double rhs)
        {
            return new Velocity(lhs.value - rhs, lhs.Unit);
        }

        public static Velocity operator *(Velocity lhs, double rhs)
        {
            return new Velocity(lhs.value * rhs, lhs.Unit);
        }

        public static Velocity operator /(Velocity lhs, double rhs)
        {
            return new Velocity(lhs.value / rhs, lhs.Unit);
        }

        public static Velocity operator +(Velocity lhs, Velocity rhs)
        {
            return new Velocity(QuantityOperations.Add(lhs, rhs));
        }

        public static Velocity operator -(Velocity lhs, Velocity rhs)
        {
            return new Velocity(QuantityOperations.Subtract(lhs, rhs));
        }

        public static double operator /(Velocity lhs, Velocity rhs)
        {
            return QuantityOperations.Divide(lhs, rhs).Value;
        }

        public static bool operator ==(Velocity lhs, Velocity rhs)
        {
            return QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator !=(Velocity lhs, Velocity rhs)
        {
            return !QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator >=(Velocity lhs, Velocity rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) >= 0;
        }

        public static bool operator <=(Velocity lhs, Velocity rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) <= 0;
        }

        public static bool operator >(Velocity lhs, Velocity rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) > 0;
        }

        public static bool operator <(Velocity lhs, Velocity rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) < 0;
        }

        public static Interval<Velocity> Interval(double min, double max, SelectUnit<VelocityUnitSelector> unitSelector)
        {
            return new Interval<Velocity>(min, max, unitSelector(new VelocityUnitSelector()));
        }

        public Squared<Velocity> Squared()
        {
            return new Squared<Velocity>(this);
        }

        public Cubed<Velocity> Cubed()
        {
            return new Cubed<Velocity>(this);
        }

        public double ToDouble(IUnit unit)
        {
            return QuantityOperations.ConvertToUnit(this, unit);
        }

        public IQuantity ToQuantity(IUnit unit)
        {
            return this.ToUnit(unit);
        }

        public Velocity ToUnit(IUnit unit)
        {
            return new Velocity(this.ToDouble(unit), unit);
        }

        public Velocity ToUnit(SelectUnit<VelocityUnitSelector> unitSelector)
        {
            return this.ToUnit(UnitBuilder.BuildUnit(unitSelector(new VelocityUnitSelector())));
        }

        public double ToDouble(SelectUnit<VelocityUnitSelector> unitSelector)
        {
            return this.ToDouble(UnitBuilder.BuildUnit(unitSelector(new VelocityUnitSelector())));
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

        public bool Equals(Velocity quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        public int CompareTo(object obj)
        {
            return QuantityHelper.CompareTo<Velocity>(this, obj);
        }

        public int CompareTo(IQuantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        public int CompareTo(Velocity quantity)
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

        public Velocity CreateQuantity(double value, IUnit unit)
        {
            return new Velocity(value, unit);
        }

        IQuantity IDeferredQuantity.GetResult()
        {
            return this;
        }

        VelocityUnitSelector IQuantity<Velocity, VelocityUnitSelector>.CreateUnitSelector()
        {
            return new VelocityUnitSelector();
        }
    }
}