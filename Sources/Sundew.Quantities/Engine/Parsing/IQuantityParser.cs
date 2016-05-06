﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IQuantityParser.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Parsing
{
    using Sundew.Base.Computation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis;

    /// <summary>
    /// Interface for implementing a quantity parser.
    /// </summary>
    public interface IQuantityParser
    {
        /// <summary>
        /// Parses the specified quantity.
        /// </summary>
        /// <param name="lexemes">The lexemes.</param>
        /// <param name="parseSettings">The parse settings.</param>
        /// <returns>The parsed <see cref="Quantity" />.</returns>
        Result<Quantity, Error<QuantityError>> Parse(Lexemes lexemes, ParseSettings parseSettings);
    }
}