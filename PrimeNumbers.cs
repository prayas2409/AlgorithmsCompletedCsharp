// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeNumbers.cs" company="Bridgelabz">
//   Copyright © 2015 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// checks the prime numbers in range 1000
    /// </summary>
    public class PrimeNumbers
    {
        /// <summary>
        /// method prints prime numbers less than 1000
        /// </summary>
        public void PrimeNumbersDemo()
        {
            int counter;
            for (counter = 2; counter < 1000; counter++)
            {
                if (Utility.CheckPrime(counter))
                {
                    Console.Write("{0} ", counter);
                }
            }
        }
    }
}
