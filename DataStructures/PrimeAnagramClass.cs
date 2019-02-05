// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagramClass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The class is to create an object for storing the range and the number in that range
    /// </summary>
    public class PrimeAnagramClass
    {
        /// <summary>
        /// The range is the number from where the counting starts
        /// </summary>
        private int range;

        /// <summary>
        /// The anagrams is the array to store the anagrams in the array
        /// </summary>
        private int[] anagrams = new int[20];

        /// <summary>
        /// Gets the range.
        /// </summary>
        /// <returns>The range that is from where the count will start</returns>
        public int GetRange()
        {
            return this.range;
        }

        /// <summary>
        /// Gets the anagrams.
        /// </summary>
        /// <returns>the integer array of anagrams</returns>
        public int[] GetAnagrams()
        {
            return this.anagrams;
        }

        /// <summary>
        /// Sets the range.
        /// </summary>
        /// <param name="num">The number.</param>
        public void SetRange(int num)
        {
            this.range = num;
        }

        /// <summary>
        /// Adds the anagrams to array.
        /// </summary>
        /// <param name="num">The number.</param>
        public void SetAnagrams(int num)
        {
            int i = 0;
            while (this.anagrams[i] != 0)
            {
                i++;
            }

            this.anagrams[i] = num;
        }
    }
}
