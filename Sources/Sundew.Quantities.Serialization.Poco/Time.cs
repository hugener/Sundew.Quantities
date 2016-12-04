// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="Time.cs" company="Hukano">
// //   2016 (c) Hukano. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using Sundew.Quantities.Engine.Quantities;

namespace Sundew.Quantities.Serialization.Poco
{
    /// <summary>
    /// Represents <see cref="Quantities.Time"/> as a serializable type.
    /// </summary>
    public sealed class Time : SerializableQuantity<Quantities.Time>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class.
        /// </summary>
        public Time()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class.
        /// </summary>
        /// <param name="quantity">The quantity.</param>
        public Time(IQuantity quantity)
            : base(quantity)
        {
        }

        /// <summary>
        /// Converts this instances to a quantity.
        /// </summary>
        /// <returns>A <see cref="Quantities.Time"/>.</returns>
        public override Quantities.Time ToQuantity()
        {
            return new Quantities.Time(this.Value, this.GetUnit());
        }
    }
}