﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Illuminance.generated.cs" company="Hukano">
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
    public partial struct Illuminance : IQuantity<Illuminance, IlluminanceUnitSelector>
    {
        private readonly double value;

        public Illuminance(double value, SelectUnit<IlluminanceUnitSelector> unitSelector)
            : this(value,  UnitBuilder.BuildUnit(unitSelector(new IlluminanceUnitSelector())))
        {
        }

        public Illuminance(IQuantity quantity)
            : this(quantity.Value, quantity.Unit)
        {
        }

        public Illuminance(double value)
            : this(value, units => units.BaseUnit)
        {
        }

        public Illuminance(double value, IUnit unit)
        {
            this.value = value;
            this.Unit = unit;
        }

        double IQuantity.Value => this.value;

        public IUnit Unit { get; }

        public static Illuminance operator +(Illuminance quantity)
        {
            return quantity;
        }

        public static Illuminance operator -(Illuminance quantity)
        {
            return new Illuminance(-quantity.value, quantity.Unit);
        }

        public static Illuminance operator ++(Illuminance quantity)
        {
            return new Illuminance(quantity.value + 1, quantity.Unit);
        }

        public static Illuminance operator --(Illuminance quantity)
        {
            return new Illuminance(quantity.value - 1, quantity.Unit);
        }

        public static Illuminance operator +(Illuminance lhs, double rhs)
        {
            return new Illuminance(lhs.value + rhs, lhs.Unit);
        }

        public static Illuminance operator -(Illuminance lhs, double rhs)
        {
            return new Illuminance(lhs.value - rhs, lhs.Unit);
        }

        public static Illuminance operator *(Illuminance lhs, double rhs)
        {
            return new Illuminance(lhs.value * rhs, lhs.Unit);
        }

        public static Illuminance operator /(Illuminance lhs, double rhs)
        {
            return new Illuminance(lhs.value / rhs, lhs.Unit);
        }

        public static Illuminance operator +(Illuminance lhs, Illuminance rhs)
        {
            return new Illuminance(QuantityOperations.Add(lhs, rhs));
        }

        public static Illuminance operator -(Illuminance lhs, Illuminance rhs)
        {
            return new Illuminance(QuantityOperations.Subtract(lhs, rhs));
        }

        public static double operator /(Illuminance lhs, Illuminance rhs)
        {
            return QuantityOperations.Divide(lhs, rhs).Value;
        }

        public static bool operator ==(Illuminance lhs, Illuminance rhs)
        {
            return QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator !=(Illuminance lhs, Illuminance rhs)
        {
            return !QuantityHelper.AreEqual(lhs, rhs);
        }

        public static bool operator >=(Illuminance lhs, Illuminance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) >= 0;
        }

        public static bool operator <=(Illuminance lhs, Illuminance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) <= 0;
        }

        public static bool operator >(Illuminance lhs, Illuminance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) > 0;
        }

        public static bool operator <(Illuminance lhs, Illuminance rhs)
        {
            return QuantityHelper.CompareTo(lhs, rhs) < 0;
        }

        public static Interval<Illuminance> Interval(double min, double max, SelectUnit<IlluminanceUnitSelector> unitSelector)
        {
            return new Interval<Illuminance>(min, max, unitSelector(new IlluminanceUnitSelector()));
        }

        public Squared<Illuminance> Squared()
        {
            return new Squared<Illuminance>(this);
        }

        public Cubed<Illuminance> Cubed()
        {
            return new Cubed<Illuminance>(this);
        }

        public double ToDouble(IUnit unit)
        {
            return QuantityOperations.ConvertToUnit(this, unit);
        }

        public IQuantity ToQuantity(IUnit unit)
        {
            return this.ToUnit(unit);
        }

        public Illuminance ToUnit(IUnit unit)
        {
            return new Illuminance(this.ToDouble(unit), unit);
        }

        public Illuminance ToUnit(SelectUnit<IlluminanceUnitSelector> unitSelector)
        {
            return this.ToUnit(UnitBuilder.BuildUnit(unitSelector(new IlluminanceUnitSelector())));
        }

        public double ToDouble(SelectUnit<IlluminanceUnitSelector> unitSelector)
        {
            return this.ToDouble(UnitBuilder.BuildUnit(unitSelector(new IlluminanceUnitSelector())));
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

        public bool Equals(Illuminance quantity)
        {
            return QuantityHelper.AreEqual(this, quantity);
        }

        public int CompareTo(object obj)
        {
            return QuantityHelper.CompareTo<Illuminance>(this, obj);
        }

        public int CompareTo(IQuantity quantity)
        {
            return QuantityHelper.CompareTo(this, quantity);
        }

        public int CompareTo(Illuminance quantity)
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

        public Illuminance CreateQuantity(double value, IUnit unit)
        {
            return new Illuminance(value, unit);
        }

        IQuantity IDeferredQuantity.GetResult()
        {
            return this;
        }

        IlluminanceUnitSelector IQuantity<Illuminance, IlluminanceUnitSelector>.CreateUnitSelector()
        {
            return new IlluminanceUnitSelector();
        }
    }
}