﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemperatureUnitSelector.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitSelectors
{
    using System.Collections.Generic;
    using Sundew.Quantities.Representations.Expressions;
    using Sundew.Quantities.Representations.Units;
    using Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Unit selector for <see cref="Temperature"/>.
    /// </summary>
    public class TemperatureUnitSelector :
        PrefixSelector<ITemperatureUnitSelector, IPrefixSelector<ITemperatureUnitSelector>>,
        ITemperatureUnitSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit.
        /// </value>
        public Expression BaseUnit => this.Kelvin;

        /// <summary>
        /// Gets the Kelvin.
        /// </summary>
        /// <value>
        /// The Kelvin.
        /// </value>
        public Expression Kelvin => this.SpecifyUnit(UnitDefinitions.Kelvin);

        /// <summary>
        /// Gets the Celsius.
        /// </summary>
        /// <value>
        /// The Celsius.
        /// </value>
        public Expression Celsius => this.SpecifyUnit(UnitDefinitions.Celsius);

        /// <summary>
        /// Gets the Fahrenheit.
        /// </summary>
        /// <value>
        /// The Fahrenheit.
        /// </value>
        public Expression Fahrenheits => this.SpecifyUnit(UnitDefinitions.Fahrenheit);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>s.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitDefinitions.Kelvin;
            yield return UnitDefinitions.Celsius;
            yield return UnitDefinitions.Fahrenheit;
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>The <see cref="IPrefixSelector{ITemperatureUnitSelector}"/></returns>
        protected override IPrefixSelector<ITemperatureUnitSelector> GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The <see cref="ITemperatureUnitSelector"/>.</returns>
        protected override ITemperatureUnitSelector GetUnits()
        {
            return this;
        }
    }
}