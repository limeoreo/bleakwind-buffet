/*
 * Author: Madison Burch
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent mad otar grits side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits:Side
    {
        /// <summary>
        /// gets mad otar grits price
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 1.22;
                }
                else if (Size == Size.Medium)
                {
                    price = 1.58;
                }
                else
                {
                    price = 1.93;
                }
                return price;
            }
        }
        /// <summary>
        /// gets calories for mad otar grits
        /// </summary>
        private uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 105;
                }
                else if (Size == Size.Medium)
                {
                    calories = 142;
                }
                else
                {
                    calories = 179;
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
            return Size.ToString() + " Mad Otar Grits";
        }
    }
}