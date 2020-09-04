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
    public class CandlehearthCoffee
    {
        /// <summary>
        /// gets coffee price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    price = .75;
                }
                else if (size == Size.Medium)
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
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    calories = 7;
                }
                else if (size == Size.Medium)
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
                return size.ToString() + " Decaf Candlehearth Coffee";
            }
            else
            {
                return size.ToString() + " Candlehearth Coffee";
            }
        }
    }
}
