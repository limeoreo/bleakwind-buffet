/*
 * Author: Madison Burch
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent briarheart burger entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class BriarheartBurger
    {
        /// <summary>
        /// gets burger price
        /// </summary>
        public double Price => 6.32;
        /// <summary>
        /// gets calories for burger
        /// </summary>
        public uint Calories => 743;
        /// <summary>
        /// get/set bun or no bun
        /// </summary>
        public bool Bun { get; set; } = true;
        /// <summary>
        /// get/set ketchup or no ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// get/set mustard or no mustard
        /// </summary>
        public bool Mustard { get; set; } = true;
        /// <summary>
        /// get/set pickles or no pickles
        /// </summary>
        public bool Pickle { get; set; } = true;
        /// <summary>
        /// get/set cheese or no cheese
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// gets list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold ketchup");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }
        /// <summary>
        /// overrides toString method
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
