/*
 * Author: Madison Burch
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent vokun salad side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    public class VokunSalad
    {
        /// <summary>
        /// gets vokun salad price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    price = .93;
                }
                else if (size == Size.Medium)
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
        /// <summary>
        /// gets calories for vokun salad
        /// </summary>
        private uint calories;
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    calories = 41;
                }
                else if (size == Size.Medium)
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
            return size.ToString() + " Vokun Salad";
        }
    }
}
