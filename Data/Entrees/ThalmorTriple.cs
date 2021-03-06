﻿/*
 * Author: Madison Burch
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent thalmor triple entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple:Entree
    {
        /// <summary>
        /// gets burger price
        /// </summary>
        public override double Price => 8.32;
        public override string Description
        {
            get
            {
                return ("Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.");
            }
        }
        /// <summary>
        /// gets calories for burger
        /// </summary>
        public override uint Calories => 943;
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
        /// get/set tomato or no tomato
        /// </summary>
        public bool Tomato { get; set; } = true;
        /// <summary>
        /// get/set lettuce or no lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;
        /// <summary>
        /// get/set mayo or no mayo
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// get/set bacon or no bacon
        /// </summary>
        public bool Bacon { get; set; } = true;
        /// <summary>
        /// get/set egg or no egg
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// gets list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }
        /// <summary>
        /// overrides toString method
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
