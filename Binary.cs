﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Binary.cs" company="Bridgelabz">
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
    /// the class executes the nibble swap program
    /// </summary>
    public class Binary
    {
        /// <summary>
        /// method to execute the program for NibbleSwap
        /// </summary>
        public void NibblesSwap()
        {
            try
            {
                Console.WriteLine("Enter the number");
                int temp, i, num = Utility.IsInteger(Console.ReadLine());
                int[] binnum = new int[8];
                binnum = Utility.ToBinary(num);
                for (i = 0; i < 4; i++)
                {
                    temp = binnum[i];
                    binnum[i] = binnum[4 + i];
                    binnum[4 + i] = temp;
                }

                Console.WriteLine("New binary array is ");
                for (i = 0; i < 8; i++)
                {
                    Console.Write(binnum[i]);
                }

                Console.WriteLine();
                num = 0;
                //// calculating new number
                for (i = 0; i < 8; i++)
                {
                    if (binnum[i] == 1)
                    {
                        // 7-i gives index of the number that is used to calculate the 2^n i
                        // 7-i is because we're staring from starting where i=0 where it should be 
                        num = num + Utility.PowerOfTwo(7 - i);
                    }
                }

                Console.WriteLine("new number is " + num);
                //// checking is the number a power of 2
                if (Utility.IsPowerOfTwo(num) != 0)
                {
                    Console.WriteLine(num + " is a power of 2");
                }
                else
                {
                    Console.WriteLine(num + " is not power of 2");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
