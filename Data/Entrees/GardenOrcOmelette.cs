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
    public class GardenOrcOmelette:Entree
    {
        /// <summary>
        /// gets garden orc omelette price
        /// </summary>
        public override double Price => 4.57;
        public override string Description
        {
            get
            {
                return ("Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.");
            }
        }
        /// <summary>
        /// gets calories for garden orc omelette
        /// </summary>
        public override uint Calories => 404;
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
        public override List<string> SpecialInstructions
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
