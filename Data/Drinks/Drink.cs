using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// the size of the drink
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// the item description
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// the price of the drink
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// the calories in the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
