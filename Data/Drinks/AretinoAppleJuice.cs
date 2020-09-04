/*
 * Author: Madison Burch
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent aretino apple juice drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        /// <summary>
        /// gets aretino apple juice price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    price = .62;
                }
                else if (size == Size.Medium)
                {
                    price = .87;
                }
                else
                {
                    price = 1.01;
                }
                return price;
            }
        }
        /// <summary>
        /// gets calories for aretino apple juice
        /// </summary>
        private uint calories;
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    calories = 44;
                }
                else if (size == Size.Medium)
                {
                    calories = 88;
                }
                else
                {
                    calories = 132;
                }
                return calories;
            }
        }
        /// <summary>
        /// get/set ice or no ice
        /// </summary>
        public bool Ice { get; set; }
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
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }
        /// <summary>
        /// overrides toString method
        /// </summary>
        /// <returns>name of drink</returns>
        public override string ToString()
        {
            return size.ToString() + " Aretino Apple Juice";
        }
    }
}
