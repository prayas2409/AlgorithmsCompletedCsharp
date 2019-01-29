using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class NewtonSqrt
    {
        public static void NewtonSqrtDemo()
        {
            Console.WriteLine("Enter the value for which you want to get the squre root");
            int c = Utility.IsInteger(Console.ReadLine());
            float t = c;
            while (Math.Abs(t - (c / t)) > (1e-15))
            {
                t = ((c / t) + t) / 2;
            }
            Console.WriteLine("The squre root of c is " + t );
        }
    }
}
