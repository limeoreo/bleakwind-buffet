/*
 * Author: Madison Burch
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent philly poacher entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher: Entree
    {
        /// <summary>
        /// gets philly poacher price
        /// </summary>
        public override double Price =>7.23;
        public override string Description
        {
            get
            {
                return ("Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.");
            }
        }
        /// <summary>
        /// gets calories for philly poacher
        /// </summary>
        public override uint Calories => 784;
        /// <summary>
        /// get/set sirloin or no sirloin
        /// </summary>
        public bool Sirloin { get; set; } = true;
        /// <summary>
        /// get/set onion or no onion
        /// </summary>
        public bool Onion { get; set; } = true;
        /// <summary>
        /// get/set roll or no roll
        /// </summary>
        public bool Roll { get; set; } = true;
        /// <summary>
        /// gets list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }
        /// <summary>
        /// overrides toString method
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
