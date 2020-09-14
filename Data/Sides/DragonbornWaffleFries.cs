/*
 * Author: Madison Burch
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent dragonborn waffle fries side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries: Side
    {
        /// <summary>
        /// gets dragonborn waffle fries price
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = .42;
                }
                else if (Size == Size.Medium)
                {
                    price = .76;
                }
                else
                {
                    price = .96;
                }
                return price;
            }
        }
        /// <summary>
        /// gets calories for dragonborn waffle fries
        /// </summary>
        private uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 77;
                }
                else if (Size == Size.Medium)
                {
                    calories = 89;
                }
                else
                {
                    calories = 100;
                }
                return calories;
            }
        }
        /// <summary>
        /// gets list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// overrides toString method
        /// </summary>
        /// <returns>name of side</returns>
        public override string ToString()
        {
            return Size.ToString() + " Dragonborn Waffle Fries";
        }
    }
}
