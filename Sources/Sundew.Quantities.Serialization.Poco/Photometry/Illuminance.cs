﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Illuminance.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Serialization.Poco.Photometry
{
    using Sundew.Quantities.Engine.Quantities;

    /// <summary>
    /// Represents <see cref="Sundew.Quantities.Photometry.Illuminance"/> as a serializable type.
    /// </summary>
    public class Illuminance : SerializableQuantity<Quantities.Photometry.Illuminance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Illuminance"/> class.
        /// </summary>
        public Illuminance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Illuminance"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Illuminance(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>
        /// A <see cref="Sundew.Quantities.Photometry.Illuminance"/>.
        /// </returns>
        public override Quantities.Photometry.Illuminance ToQuantity()
        {
            return new Quantities.Photometry.Illuminance(this.Value, this.GetUnit());
        }
    }
}