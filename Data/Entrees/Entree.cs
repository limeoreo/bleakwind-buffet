using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// a base class representing common properties of entrees
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// the price of the entree
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// the calories in the entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// special instructions to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
