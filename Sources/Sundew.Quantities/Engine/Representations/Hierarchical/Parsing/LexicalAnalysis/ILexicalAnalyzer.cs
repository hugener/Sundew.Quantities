// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ILexicalAnalyzer.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis
{
    using Sundew.Base.Computation;

    /// <summary>
    /// Interface for implementing a lexical analyzer.
    /// </summary>
    public interface ILexicalAnalyzer
    {
        /// <summary>
        /// Analyzes the specified input and generates a list of lexemes.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="throwOnError">If set to <c>true</c> an exception will be thrown on error.</param>
        /// <returns>
        /// A <see cref="Lexemes" />.
        /// </returns>
        Result<Lexemes, LexicalError> Analyze(string input, bool throwOnError);
    }
}