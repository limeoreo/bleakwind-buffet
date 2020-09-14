/*
 * Author: Madison Burch
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent candlehearth coffee drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee: Drink
    {
        /// <summary>
        /// gets coffee price
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = .75;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.25;
                }
                else
                {
                    price = 1.75;
                }
                return price;
            }
        }
        /// <summary>
        /// gets calories for coffee
        /// </summary>
        private uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 7;
                }
                else if (Size == Size.Medium)
                {
                    calories = 10;
                }
                else
                {
                    calories = 20;
                }
                return calories;
            }
        }
        /// <summary>
        /// get/set ice or no ice
        /// </summary>
        public bool Ice { get; set; }
        /// <summary>
        /// get/set cream or no cream
        /// </summary>
        public bool RoomForCream { get; set; }
        /// <summary>
        /// get/set decaf or not decaf
        /// </summary>
        public bool Decaf { get; set; }
        /// <summary>
        /// gets list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }
        /// <summary>
        /// overrides toString method
        /// </summary>
        /// <returns>name of drink</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return Size.ToString() + " Decaf Candlehearth Coffee";
            }
            else
            {
                return Size.ToString() + " Candlehearth Coffee";
            }
        }
    }
}
