/*
 * Author: Madison Burch
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent warrior water drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    public class WarriorWater
    {
        /// <summary>
        /// gets water price
        /// </summary>
        public double Price => 0.00;
        /// <summary>
        /// gets calories for water
        /// </summary>
        public uint Calories => 0;
        /// <summary>
        /// get/set ice or no ice
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// get/set lemon or no lemon
        /// </summary>
        public bool Lemon { get; set; }
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
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }
        /// <summary>
        /// overrides toString method
        /// </summary>
        /// <returns>name of drink</returns>
        public override string ToString()
        {
            return size.ToString() + " Warrior Water";
        }
    }
}
