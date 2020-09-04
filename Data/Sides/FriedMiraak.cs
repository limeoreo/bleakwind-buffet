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
    public class FriedMiraak
    {
        /// <summary>
        /// gets fried miraak price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    price = 1.78;
                }
                else if (size == Size.Medium)
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
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    calories = 151;
                }
                else if (size == Size.Medium)
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
        /// get/set size option
        /// </summary>
        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        /// <summary>
        /// gets list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
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
            return size.ToString() + " Fried Miraak";
        }
    }
}
