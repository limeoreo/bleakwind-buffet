/*
 * Author: Madison Burch
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent markarth milk drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk:Drink
    {
        /// <summary>
        /// gets markarth milk price
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.05;
                }
                else if (Size == Size.Medium)
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
        public override string Description
        {
            get
            {
                return ("Hormone-free organic 2% milk.");
            }
        }
        /// <summary>
        /// gets calories for markarth milk
        /// </summary>
        private uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 56;
                }
                else if (Size == Size.Medium)
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
            return Size.ToString() + " Markarth Milk";
        }
    }
}
