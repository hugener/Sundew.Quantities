﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Reduction.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Evaluation
{
    using Sundew.Quantities.Engine.Representations.Hierarchical.Units;

    /// <summary>
    /// Represents a reductions of two units.
    /// </summary>
    public class Reduction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reduction"/> class.
        /// </summary>
        /// <param name="targetUnit">The target unit.</param>
        /// <param name="reducedUnit">The reduced unit.</param>
        internal Reduction(IUnit targetUnit, IUnit reducedUnit)
        {
            this.TargetUnit = targetUnit;
            this.ReducedUnit = reducedUnit;
        }

        /// <summary>
        /// Gets the target unit.
        /// </summary>
        /// <value>
        /// The target unit.
        /// </value>
        public IUnit TargetUnit { get; }

        /// <summary>
        /// Gets the reduced unit.
        /// </summary>
        /// <value>
        /// The reduced unit.
        /// </value>
        public IUnit ReducedUnit { get; }

        /// <summary>
        /// Converts the RHS.
        /// </summary>
        /// <param name="rhsValue">The RHS value.</param>
        /// <returns>The converted value.</returns>
        public double ConvertRhs(double rhsValue)
        {
            if (this.IsConversionRequired())
            {
                return this.TargetUnit.FromBase(this.ReducedUnit.ToBase(rhsValue));
            }

            return rhsValue;
        }

        /// <summary>
        /// Determines whether conversion is required.
        /// </summary>
        /// <returns><c>true</c> if conversion is required.</returns>
        private bool IsConversionRequired()
        {
            return !this.TargetUnit.Equals(this.ReducedUnit);
        }
    }
}