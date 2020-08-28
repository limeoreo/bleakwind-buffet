/*
 * Author: Madison Burch
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent mad otar grits side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    public class MadOtarGrits
    {
        /// <summary>
        /// gets mad otar grits price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    price = 1.22;
                }
                else if (size == Size.Medium)
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
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    calories = 105;
                }
                else if (size == Size.Medium)
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
        /// overrides toString method
        /// </summary>
        /// <returns>name of side</returns>
        public override string ToString()
        {
            return size.ToString() + " Mad Otar Grits";
        }
    }
}