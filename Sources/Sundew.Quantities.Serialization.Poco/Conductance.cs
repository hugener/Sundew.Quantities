﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Conductance.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Engine.Quantities;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Sundew.Quantities.ElectricCurrent"/> as a serializable type.
    /// </summary>
    public class Conductance : SerializableQuantity<Quantities.Conductance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Conductance"/> class.
        /// </summary>
        public Conductance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conductance" /> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Conductance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts the serializable electric current to a <see cref="Sundew.Quantities.Conductance"/>.
        /// </summary>
        /// <returns>A <see cref="Sundew.Quantities.Conductance"/>.</returns>
        public override Quantities.Conductance ToQuantity()
        {
            return new Quantities.Conductance(this.Value, this.GetUnit());
        }
    }
}