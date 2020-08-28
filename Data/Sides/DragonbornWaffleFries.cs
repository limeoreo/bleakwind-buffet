/*
 * Author: Madison Burch
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent dragonborn waffle fries side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// gets dragonborn waffle fries price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    price = .42;
                }
                else if (size == Size.Medium)
                {
                    price = .76;
                }
                else
                {
                    price = .96;
                }
                return price;
            }
        }
        /// <summary>
        /// gets calories for dragonborn waffle fries
        /// </summary>
        private uint calories;
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    calories = 77;
                }
                else if (size == Size.Medium)
                {
                    calories = 89;
                }
                else
                {
                    calories = 100;
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
            return size.ToString() + " Dragonborn Waffle Fries";
        }
    }
}
