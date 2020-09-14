using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// a base class representing common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// the size of the side
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// the price of the side
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// the calories in the side
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// special instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
