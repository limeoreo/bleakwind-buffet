/*
 * Author: Madison Burch
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent garden orc omelette entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// gets garden orc omelette price
        /// </summary>
        public double Price => 4.57;
        /// <summary>
        /// gets calories for garden orc omelette
        /// </summary>
        public uint Calories => 404;
        /// <summary>
        /// get/set broccoli or no broccoli
        /// </summary>
        public bool Broccoli { get; set; } = true;
        /// <summary>
        /// get/set mushrooms or no mushrooms
        /// </summary>
        public bool Mushrooms { get; set; } = true;
        /// <summary>
        /// get/set tomato or no tomato
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// get/set cheddar or no cheddar
        /// </summary>
        public bool Cheddar { get; set; } = true;
        /// <summary>
        /// gets list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }
        /// <summary>
        /// overrides toString method
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
