/*
 * Author: Madison Burch
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent vokun salad side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad:Side
    {
        /// <summary>
        /// gets vokun salad price
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = .93;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.28;
                }
                else
                {
                    price = 1.82;
                }
                return price;
            }
        }
        public override string Description
        {
            get
            {
                return ("A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.");
            }
        }
        /// <summary>
        /// gets calories for vokun salad
        /// </summary>
        private uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 41;
                }
                else if (Size == Size.Medium)
                {
                    calories = 52;
                }
                else
                {
                    calories = 73;
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
            return Size.ToString() + " Vokun Salad";
        }
    }
}
