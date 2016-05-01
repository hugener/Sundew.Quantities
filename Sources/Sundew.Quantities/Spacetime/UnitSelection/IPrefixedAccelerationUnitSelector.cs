﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IPrefixedAccelerationUnitSelector.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Spacetime.UnitSelection
{
    using Sundew.Quantities.Engine.UnitSelection;

    /// <summary>
    /// Interface for <see cref="Acceleration"/> unit selector.
    /// </summary>
    public interface IPrefixedAccelerationUnitSelector : IAccelerationUnitSelector,
                                                         IPrefixSelector<IAccelerationUnitSelector>
    {
    }
}