
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITemperatureUnitSelector.generated.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

// <auto-generated />
namespace Sundew.Quantities.UnitSelectors
{
    using global::System.CodeDom.Compiler;
    using global::Sundew.Quantities.Representations.Expressions;
    using global::Sundew.Quantities.Representations.Units;
    using global::Sundew.Quantities.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Temperature"/> unit selector.
    /// </summary>
    [GeneratedCode("Sundew.Quantities.Generator.UnitSelectors.UnitSelectorInterfaceGenerator", "1.0.0.0")]
    public interface ITemperatureUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the kelvin.
        /// </summary>
        /// <value>
        /// The yard <see cref="Expression"/>.
        /// </value>
        Expression Kelvin { get; }

        /// <summary>
        /// Gets the celsius.
        /// </summary>
        /// <value>
        /// The yard <see cref="Expression"/>.
        /// </value>
        Expression Celsius { get; }

        /// <summary>
        /// Gets the fahrenheit.
        /// </summary>
        /// <value>
        /// The yard <see cref="Expression"/>.
        /// </value>
        Expression Fahrenheits { get; }
    }
}