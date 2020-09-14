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
    public class SailorSoda:Drink
    {
        /// <summary>
        /// gets sailor soda price
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.42;
                }
                else if (Size == Size.Medium)
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
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 117;
                }
                else if (Size == Size.Medium)
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
        public override List<string> SpecialInstructions
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
            return Size.ToString()+" "+ flavor.ToString()+" Sailor Soda";
        }
    }
}
