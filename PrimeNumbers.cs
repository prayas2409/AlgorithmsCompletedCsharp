using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeNumbers
    {
        public void PrimeNumbersDemo()
        {
            int counter;
            for (counter = 2; counter < 1000; counter++)
            {
                if (Utility.CheckPrime(counter)) Console.Write("{0} ", counter);
            }
        }
    }
}
