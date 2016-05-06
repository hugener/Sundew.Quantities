﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="FlatUnit.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.UnitTests.Engine.Representations.Flat
{
    using System.Linq;

    using Sundew.Quantities.Engine.Representations.Conversion;
    using Sundew.Quantities.Engine.Representations.Flat;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Units;

    internal class FlatUnit : IFlatIdentifier
    {
        private readonly string baseNotation;

        private readonly double exponent;

        private readonly string notation;

        private readonly bool reduceByBaseNotation;

        public FlatUnit(string notation, double exponent)
            : this(notation, notation, false, exponent)
        {
        }

        public FlatUnit(
            string notation,
            string baseNotation = null,
            bool reduceByBaseNotation = true,
            double exponent = 1)
        {
            if (baseNotation == null)
            {
                baseNotation = notation;
            }

            this.baseNotation = baseNotation;
            this.notation = notation;
            this.reduceByBaseNotation = reduceByBaseNotation;
            this.exponent = exponent;
        }

        public string Id => this.reduceByBaseNotation ? this.baseNotation : this.notation;

        public IFlatIdentifierRepresentation GetFlatIdentifierRepresentation()
        {
            return new UnitFlatIdentifierRepresentation(new UnitExpression(new Unit(this.notation)), this.exponent);
        }

        public static FlatRepresentation CreateFlatRepresentation(params IFlatIdentifier[] flatIdentifiers)
        {
            var flatRepresentations = flatIdentifiers.ToDictionary(
                flatUnit => flatUnit.Id,
                flatUnit => flatUnit.GetFlatIdentifierRepresentation());
            return new FlatRepresentation(flatRepresentations);
        }
    }
}