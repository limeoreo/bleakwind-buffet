using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// an interface containing common properties of all menu items
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// the price of the item
        /// </summary>
        double Price { get; }
        /// <summary>
        /// the calories in the item
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// the description of the item
        /// </summary>
        string Description { get; }
        /// <summary>
        /// special instructions for preparing the item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
