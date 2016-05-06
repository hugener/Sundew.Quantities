// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IAngleUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spatial.UnitSelection
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Spatial.Angle"/> unit selector.
    /// </summary>
    public interface IAngleUnitSelector : IUnitSelector
    {
        /// <summary>
        /// Gets the radian.
        /// </summary>
        /// <value>
        /// The radian.
        /// </value>
        Expression Radians { get; }

        /// <summary>
        /// Gets the degrees.
        /// </summary>
        /// <value>
        /// The degrees.
        /// </value>
        Expression Degrees { get; }

        /// <summary>
        /// Gets the turns.
        /// </summary>
        /// <value>
        /// The turns.
        /// </value>
        Expression Turns { get; }
    }
}