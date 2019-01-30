// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NewtonSqrt.cs" company="Bridgelabz">
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
    /// The class is to execute the square root program using newtons method
    /// </summary>
    public class NewtonSqrt
    {
        /// <summary>
        /// This method calculates square root using Newtons method
        /// </summary>
        public static void NewtonSqrtDemo()
        {
            Console.WriteLine("Enter the value for which you want to get the squre root");
            int c = Utility.IsInteger(Console.ReadLine());
            float t = c;
            while (Math.Abs(t - (c / t)) > 1e-15)
            {
                t = ((c / t) + t) / 2;
            }

            Console.WriteLine("The squre root of c is " + t);
        }
    }
}
