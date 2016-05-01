﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IPrefixedTimeUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Periodics.UnitSelection
{
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Time"/> unit selector.
    /// </summary>
    public interface IPrefixedTimeUnitSelector : ITimeUnitSelector, IPrefixSelector<ITimeUnitSelector>
    {
    }
}