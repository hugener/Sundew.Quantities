﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ExpressionParser.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Engine.Representations.Hierarchical.Parsing
{
    using System;

    using Sundew.Base.Computation;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Expressions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Internals;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Errors;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.Exceptions;
    using Sundew.Quantities.Engine.Representations.Hierarchical.Parsing.LexicalAnalysis;

    /// <summary>
    /// Default implementation of <see cref="IExpressionParser"/>.
    /// </summary>
    public class ExpressionParser : IExpressionParser
    {
        private readonly IUnitExpressionParser unitExpressionParser;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionParser"/> class.
        /// </summary>
        /// <param name="unitExpressionParser">The unit parser.</param>
        public ExpressionParser(IUnitExpressionParser unitExpressionParser)
        {
            this.unitExpressionParser = unitExpressionParser;
        }

        /// <summary>
        /// Parses the specified lexeme list.
        /// </summary>
        /// <param name="lexemes">The lexemes.</param>
        /// <param name="parseSettings">The parse settings.</param>
        /// <returns>
        /// The parsed expression.
        /// </returns>
        public Result<Expression, Error<ExpressionError>> Parse(Lexemes lexemes, ParseSettings parseSettings)
        {
            try
            {
                var expression = this.Expression(lexemes, parseSettings);
                string token;
                if (parseSettings.AssertEnd && !lexemes.AcceptTokenType(TokenType.End, out token))
                {
                    throw CreateParseException(ExpressionError.EndOfDataNotFound, lexemes.Current);
                }

                return Result.Success(expression);
            }
            catch (ExpressionParseException expressionParseException)
            {
                if (parseSettings.ThrowOnError)
                {
                    throw;
                }

                return Result.Error(expressionParseException.Error);
            }
        }

        private static Exception CreateParseException(
            ExpressionError expressionError,
            Lexeme lexeme,
            IError innerError = null)
        {
            throw new ExpressionParseException(Error.From(expressionError, lexeme, innerError));
        }

        private Expression Expression(Lexemes lexemes, ParseSettings parseSettings)
        {
            return this.TryMultiplicativeExpression(lexemes, parseSettings);
        }

        private Expression TryMultiplicativeExpression(Lexemes lexemes, ParseSettings parseSettings)
        {
            var expression = this.TryMagnitudeExpression(lexemes, parseSettings);
            return this.MultiplicativeExpression(lexemes, expression, parseSettings);
        }

        private Expression MultiplicativeExpression(Lexemes lexemes, Expression lhs, ParseSettings parseSettings)
        {
            if (lexemes.AcceptToken(Constants.Multiply) || lexemes.AcceptToken(Constants.MultiplyDot)
                || lexemes.AcceptToken(Constants.MultiplyCross))
            {
                var rhs = this.TryMagnitudeExpression(lexemes, parseSettings);
                return this.MultiplicativeExpression(lexemes, new MultiplicationExpression(lhs, rhs), parseSettings);
            }

            if (lexemes.AcceptToken(Constants.Divide))
            {
                var rhs = this.TryMagnitudeExpression(lexemes, parseSettings);
                return this.MultiplicativeExpression(lexemes, new DivisionExpression(lhs, rhs), parseSettings);
            }

            return lhs;
        }

        private Expression TryMagnitudeExpression(Lexemes lexemes, ParseSettings parseSettings)
        {
            var lhs = this.PrimaryExpression(lexemes, parseSettings);
            return this.MagnitudeExpression(lexemes, lhs, parseSettings);
        }

        private Expression MagnitudeExpression(Lexemes lexemes, Expression lhs, ParseSettings parseSettings)
        {
            if (lexemes.AcceptToken(Constants.Power))
            {
                var constantExpression = this.ConstantExpression(lexemes, parseSettings);
                return this.MagnitudeExpression(
                    lexemes,
                    new MagnitudeExpression(lhs, constantExpression),
                    parseSettings);
            }

            string exponent;
            if (lexemes.AcceptTokenType(TokenType.Exponent, out exponent))
            {
                var constantExpression =
                    new ConstantExpression(
                        double.Parse(CharacterConverter.FromExponentNotation(exponent), parseSettings.CultureInfo));
                return this.MagnitudeExpression(
                    lexemes,
                    new MagnitudeExpression(lhs, constantExpression),
                    parseSettings);
            }

            return lhs;
        }

        private Expression PrimaryExpression(Lexemes lexemes, ParseSettings parseSettings)
        {
            if (lexemes.AcceptToken(Constants.LeftParenthesis))
            {
                var expression = this.Expression(lexemes, parseSettings);
                if (lexemes.AcceptToken(Constants.RightParenthesis))
                {
                    return new ParenthesisExpression(expression);
                }

                throw CreateParseException(ExpressionError.RightParenthesisNotFound, lexemes.Current);
            }

            if (lexemes.AcceptToken(Constants.LeftWeakParenthesis))
            {
                var expression = this.Expression(lexemes, parseSettings);
                if (lexemes.AcceptToken(Constants.RightWeakParenthesis))
                {
                    return expression;
                }

                throw CreateParseException(ExpressionError.RightWeakParenthesisNotFound, lexemes.Current);
            }

            string identifier;
            if (lexemes.AcceptTokenType(TokenType.Identifier, true, out identifier))
            {
                var result = this.unitExpressionParser.Parse(identifier, false);
                if (result)
                {
                    return result.Value;
                }

                throw CreateParseException(ExpressionError.IdentifierNotFound, lexemes.MoveToPrevious(), result.Error);
            }

            return this.ConstantExpression(lexemes, parseSettings);
        }

        private ConstantExpression ConstantExpression(Lexemes lexemes, ParseSettings parseSettings)
        {
            string number;
            if (lexemes.AcceptTokenType(TokenType.Number, out number))
            {
                return new ConstantExpression(double.Parse(number, parseSettings.CultureInfo));
            }

            throw CreateParseException(ExpressionError.NumberNotFound, lexemes.Current);
        }
    }
}