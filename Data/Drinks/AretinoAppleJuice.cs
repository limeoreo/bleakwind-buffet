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
    public class AretinoAppleJuice : Drink
    {
        /// <summary>
        /// gets aretino apple juice price
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = .62;
                }
                else if (Size == Size.Medium)
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
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 44;
                }
                else if (Size == Size.Medium)
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
        /// gets list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
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
            return Size.ToString() + " Aretino Apple Juice";
        }
    }
}
