/*
 * Author: Madison Burch
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent sailor soda drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        /// <summary>
        /// gets sailor soda price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    price = 1.42;
                }
                else if (size == Size.Medium)
                {
                    price = 1.74;
                }
                else
                {
                    price = 2.07;
                }
                return price;
            }
        }
        /// <summary>
        /// gets calories for sailor soda
        /// </summary>
        private uint calories;
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    calories = 117;
                }
                else if (size == Size.Medium)
                {
                    calories = 153;
                }
                else
                {
                    calories = 205;
                }
                return calories;
            }
        }
        /// <summary>
        /// get/set ice or no ice
        /// </summary>
        public bool Ice { get; set; } = true;
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
        /// get/set flavor option
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
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
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }
        /// <summary>
        /// overrides toString method
        /// </summary>
        /// <returns>name of drink</returns>
        public override string ToString()
        {
            return size.ToString()+" "+ flavor.ToString()+" Sailor Soda";
        }
    }
}
