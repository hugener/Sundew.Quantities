﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="VolumeUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spatial.UnitSelection
{
    using System.Collections.Generic;

    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;
    using Sundew.Quantities.Engine.Units;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Unit selector for <see cref="Volume"/>.
    /// </summary>
    public class VolumeUnitSelector : PrefixSelector<IVolumeUnitSelector, IPrefixedVolumeSelector>,
                                      IPrefixedVolumeSelector
    {
        /// <summary>
        /// Gets the base unit.
        /// </summary>
        /// <value>
        /// The base unit <see cref="Expression"/>.
        /// </value>
        public Expression BaseUnit => this.SpecifyUnit(UnitBuilder.BuildUnit(this.Cubic.Meters));

        /// <summary>
        /// Gets the liter.
        /// </summary>
        /// <value>The liter <see cref="Expression"/>.</value>
        public Expression Liters => this.SpecifyUnit(UnitDefinitions.Liter);

        /// <summary>
        /// Gets the meters.
        /// </summary>
        /// <value>
        /// The meters <see cref="Expression"/>.
        /// </value>
        public Expression Meters => this.SpecifyUnit(UnitDefinitions.Meter);

        /// <summary>
        /// Gets the miles.
        /// </summary>
        /// <value>
        /// The miles <see cref="Expression"/>.
        /// </value>
        public Expression Miles => this.SpecifyUnit(UnitDefinitions.Mile);

        /// <summary>
        /// Gets the feet.
        /// </summary>
        /// <value>
        /// The feet <see cref="Expression"/>.
        /// </value>
        public Expression Feet => this.SpecifyUnit(UnitDefinitions.Foot);

        /// <summary>
        /// Gets or sets the inches.
        /// </summary>
        /// <value>
        /// The inches <see cref="Expression"/>.
        /// </value>
        public Expression Inches => this.SpecifyUnit(UnitDefinitions.Inch);

        /// <summary>
        /// Gets the nautical miles.
        /// </summary>
        /// <value>
        /// The nautical miles <see cref="Expression"/>.
        /// </value>
        public Expression NauticalMiles => this.SpecifyUnit(UnitDefinitions.NauticalMile);

        /// <summary>
        /// Gets the yards.
        /// </summary>
        /// <value>
        /// The yards <see cref="Expression"/>.
        /// </value>
        public Expression Yards => this.SpecifyUnit(UnitDefinitions.Yard);

        /// <summary>
        /// Gets the default units.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{IUnit}"/>.</returns>
        public IEnumerable<IUnit> GetDefaultUnits()
        {
            yield return UnitBuilder.BuildUnit(this.Cubic.Meters);
            yield return UnitBuilder.BuildUnit(this.Liters);
        }

        /// <summary>
        /// Gets the prefixes and units.
        /// </summary>
        /// <returns>The <see cref="IPrefixedVolumeSelector"/>.</returns>
        protected override IPrefixedVolumeSelector GetPrefixesAndUnits()
        {
            return this;
        }

        /// <summary>
        /// Gets the units.
        /// </summary>
        /// <returns>The <see cref="IVolumeUnitSelector"/>.</returns>
        protected override IVolumeUnitSelector GetUnits()
        {
            return this;
        }
    }
}