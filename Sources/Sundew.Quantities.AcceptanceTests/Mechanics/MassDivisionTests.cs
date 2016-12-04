﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="MassDivisionTests.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.AcceptanceTests.Mechanics
{
    using FluentAssertions;

    using Sundew.Quantities.AcceptanceTests.Testing;

    using Xunit;

    public class MassDivisionTests
    {
        [Fact]
        public void Mass_Division_When_RhsIsMeterSecondsSquared_Then_ResultShouldBeExpected()
        {
            const double Expected = 23;
            var mass = 46.KiloGrams();
            var meterSecondsSquared = 2.Meters() * 1D.Seconds().Squared();

            var result = mass / meterSecondsSquared;

            result.Should().Be(Expected, "Pa");
        }

        [Fact]
        public void Mass_Multiplication_When_RhsIsMeterSeconds_Then_ResultShouldBeExpected()
        {
            const double Expected = 92;
            var mass = 46.KiloGrams();
            var velocity = 2.Meters() / 1D.Seconds();

            var result = mass * velocity;

            result.Should().Be(Expected, "kg*m/s");
        }
    }
}