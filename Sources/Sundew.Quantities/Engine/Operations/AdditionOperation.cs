﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="AdditionOperation.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Operations
{
    using Sundew.Quantities.Engine.Exceptions;
    using Sundew.Quantities.Engine.Quantities;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Visitors;

    /// <summary>
    /// Operation for adding two <see cref="IQuantity"/> instances.
    /// </summary>
    public class AdditionOperation : IQuantityOperation<IQuantity>
    {
        private readonly ValueFromBaseVisitor valueFromBaseVisitor;

        private readonly ValueToBaseVisitor valueToBaseVisitor;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionOperation"/> class.
        /// </summary>
        /// <param name="valueFromBaseVisitor">From base visitor.</param>
        /// <param name="valueToBaseVisitor">To base visitor.</param>
        public AdditionOperation(ValueFromBaseVisitor valueFromBaseVisitor, ValueToBaseVisitor valueToBaseVisitor)
        {
            this.valueFromBaseVisitor = valueFromBaseVisitor;
            this.valueToBaseVisitor = valueToBaseVisitor;
        }

        /// <summary>
        /// Executes the specified LHS.
        /// </summary>
        /// <param name="lhs">The LHS quantity.</param>
        /// <param name="rhs">The RHS quantity.</param>
        /// <returns>A <see cref="IQuantity"/>.</returns>
        /// <exception cref="UnitMismatchException">If the two <see cref="IQuantity"/> are not of the same unit or base unit.</exception>
        public IQuantity Execute(IQuantity lhs, IQuantity rhs)
        {
            var lhsValue = lhs.Value;
            var lhsUnit = lhs.Unit;
            var rhsValue = rhs.Value;
            var rhsUnit = rhs.Unit;
            if (lhsUnit.Equals(rhsUnit))
            {
                return new Quantity(lhsValue + rhsValue, lhsUnit);
            }

            if (lhsUnit.BaseUnit.Equals(rhsUnit.BaseUnit))
            {
                return
                    new Quantity(
                        lhsValue
                        + this.valueFromBaseVisitor.Visit(
                            lhsUnit.GetExpression(),
                            this.valueToBaseVisitor.Visit(rhsUnit.GetExpression(), rhsValue)),
                        lhsUnit);
            }

            throw new UnitMismatchException(OperationType.Add, lhsUnit, rhsUnit);
        }
    }
}