// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Prime2DArray.cs" company="Bridgelabz">
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
    /// The class is to execute the program for prime 2d array
    /// </summary>
    public class Prime2DArray
    {
        /// <summary>
        /// searches the prime numbers in the range 0-1000
        /// </summary>
        public void Prime2DarrayDemo()
        {
            try
            {
                int[,] primenumbers = new int[10, 50];
                int i = 0, j, count;
                primenumbers[0, 0] = 0;
                //// storing the range for each of the array
                for (i = 1; i < 10; i++)
                {
                    primenumbers[i, 0] = primenumbers[i - 1, 0] + 100;
                }
                //// to check and store prime numbers in array
                for (i = 0; i < 10; i++)
                {
                    count = 0;
                    for (j = 1; j < 100; j++)
                    {
                        //// WriteLine("For i= {0}, j= {1}, count= {2} ",i,j,count);
                        if (Utility.IsPrime(primenumbers[i, 0] + j))
                        {
                            count++;
                            primenumbers[i, count] = primenumbers[i, 0] + j;
                        }
                    }
                }

                Console.WriteLine("Printing the prime numbers");
                for (i = 0; i < 10; i++)
                {
                    Console.Write("For {0} - {1}: ", primenumbers[i, 0], primenumbers[i, 0] + 100);

                    for (j = 1; primenumbers[i, j] != 0; j++)
                    {
                        Console.Write(primenumbers[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process is stopped because " + e);
            }
        }
    }
}
