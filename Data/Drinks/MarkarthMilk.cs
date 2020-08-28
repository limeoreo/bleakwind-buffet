/*
 * Author: Madison Burch
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent markarth milk drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    public class MarkarthMilk
    {
        /// <summary>
        /// gets markarth milk price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    price = 1.05;
                }
                else if (size == Size.Medium)
                {
                    price = 1.11;
                }
                else
                {
                    price = 1.22;
                }
                return price;
            }
        }
        /// <summary>
        /// gets calories for markarth milk
        /// </summary>
        private uint calories;
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    calories = 56;
                }
                else if (size == Size.Medium)
                {
                    calories = 72;
                }
                else
                {
                    calories = 93;
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
            return size.ToString() + " Markarth Milk";
        }
    }
}
