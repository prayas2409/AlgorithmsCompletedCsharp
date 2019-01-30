// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AnagramPalindromeInt.cs" company="Bridgelabz">
//   Copyright © 2015 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The class is to execute the Anagram palindrome mix program
    /// </summary>
    public class AnagramPalindromeInt
    {
        /// <summary>
        /// Method to execute the program.
        /// </summary>
        public void AnagramPalindromeIntDemo()
        {
            int counter, count = 0, i = 0, j, temp1, temp2 = 0;
            int[] primearray = new int[1000];
            for (counter = 2; counter < 1000; counter++)
            {
                if (Utility.CheckPrime(counter))
                {
                    count++;
                }
            }           

            for (counter = 2; i < count;  counter++)
            {
                if (Utility.CheckPrime(counter))
                {
                    primearray[i] = counter;
                    i++;
                }
            }

            string string1;
            for (i = 0; i < count; i++)
            {
                string1 = Convert.ToString(primearray[i]);
                for (j = i + 1; j < count; j++)
                {                    
                    Utility.Anagram(string1, Convert.ToString(primearray[j]));
                }

                temp1 = primearray[i];
                ////reversing the digits of the number  
                while (temp1 > 0)
                {
                    temp2 = (temp2 * 10) + (temp1 % 10);
                    temp1 = temp1 / 10;
                }

                if ((primearray[i] - temp2 == 0) && primearray[i] > 10)
                {
                    Console.WriteLine("{0} is palindrome", primearray[i]);
                }

                temp2 = 0; 
            }
        }
    }
}
