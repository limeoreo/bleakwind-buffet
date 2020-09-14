/*
 * Author: Madison Burch
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent thugs t-bone entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone:Entree
    {
        /// <summary>
        /// gets thugs t-bone price
        /// </summary>
        public override double Price => 6.44;
        /// <summary>
        /// gets calories for thugs t-bone
        /// </summary>
        public override uint Calories => 982;
        /// <summary>
        /// gets list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// overrides toString method
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
