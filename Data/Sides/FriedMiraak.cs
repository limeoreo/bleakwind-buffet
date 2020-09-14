/*
 * Author: Madison Burch
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent fried miraak side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak:Side
    {
        /// <summary>
        /// gets fried miraak price
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.78;
                }
                else if (Size == Size.Medium)
                {
                    price = 2.01;
                }
                else
                {
                    price = 2.88;
                }
                return price;
            }
        }
        /// <summary>
        /// gets calories for fried miraak
        /// </summary>
        private uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 151;
                }
                else if (Size == Size.Medium)
                {
                    calories = 236;
                }
                else
                {
                    calories = 306;
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
            return Size.ToString() + " Fried Miraak";
        }
    }
}
