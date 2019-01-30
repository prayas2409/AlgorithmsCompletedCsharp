// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InsertionSortLine.cs" company="Bridgelabz">
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
    /// Executes the Insertion sort on the words of given line
    /// </summary>
    public class InsertionSortLine
    {
        /// <summary>
        /// performs Insertion sort on line 
        /// </summary>
        public void InsertionSortLineDemo()
        {
            string string1, temp = string.Empty;
            int i = 0, count = 0;
            Console.WriteLine("Enter the line for sorting its words");
            string1 = Console.ReadLine();
            ////counts number of strings by using spaces
            foreach (char c in string1)
            {
                if (c == ' ')
                {
                    count++;
                }
            }

            Console.WriteLine("count is {0}", count);
            string[] stringArray = new string[count + 1];
            foreach (char c in string1)
            {
                if (c == ' ')
                {
                    stringArray[i] = temp;
                    temp = string.Empty;
                    i++;
                    Console.WriteLine();
                }

                temp = temp + c;
            }
           
            Console.WriteLine("temp is " + temp);
            stringArray[i] = temp;
            Console.WriteLine("Before sorting ");
            for (i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            stringArray = Utility.InsertionSortString(stringArray, stringArray.Length);
            Console.WriteLine("After sorting array");
            for (i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }     
        }
    }
}
