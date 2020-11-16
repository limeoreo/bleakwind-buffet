/*
 * Author: Madison Burch
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent smokehouse skeleton entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton: Entree
    {
        /// <summary>
        /// gets smokehouse skeleton price
        /// </summary>
        public override double Price => 5.62;
        public override string Description
        {
            get
            {
                return ("Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.");
            }
        }
        /// <summary>
        /// gets calories for smokehouse skeleton
        /// </summary>
        public override uint Calories => 602;
        /// <summary>
        /// get/set sausage or no sausage
        /// </summary>
        public bool SausageLink { get; set; } = true;
        /// <summary>
        /// get/set eggs or no eggs
        /// </summary>
        public bool Egg { get; set; } = true;
        /// <summary>
        /// get/set hashbrowns or no hashbrowns
        /// </summary>
        public bool HashBrowns { get; set; } = true;
        /// <summary>
        /// get/set pancakes or no pancakes
        /// </summary>
        public bool Pancake { get; set; } = true;
        /// <summary>
        /// gets list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }
        /// <summary>
        /// overrides toString method
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
