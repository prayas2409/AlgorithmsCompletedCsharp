// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MergeSortAlgo.cs" company="Bridgelabz">
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
    /// The class is to execute the merge sort in strings
    /// </summary>
    public class MergeSortAlgo
    {
        /// <summary>
        /// TMethod to execute Merge sort
        /// </summary>
        public void MergeSortAlgoDemo()
        {
            Console.WriteLine("Enter the string whose words are to be sorted");
            string s, temp = string.Empty;
            int count = 0, i = 0;
            s = Console.ReadLine();
            //// counting number of words by counting spaces
            foreach (char c in s)
            {
                if (c == ' ')
                {
                    count++;
                }
            }

            Console.WriteLine("number of spaces " + count);
            string[] stringarray = new string[count + 1];
            //// converting the line to array of strings to sort them
            foreach (char c in s)
            {
                //// if space is encountered we store it to next element
                if (c == ' ')
                {
                    stringarray[i] = temp;
                    temp = string.Empty;
                    i++;
                }
                else
                {
                    temp = temp + c;
                }
            }

            stringarray[i] = temp;
            Console.WriteLine("Before sorting the srting is");
            for (i = 0; i <= count; i++)
            {
                Console.WriteLine(stringarray[i]);
            }

            stringarray = Utility.MergeSortString(stringarray, 0, count);
            Console.WriteLine("After sorting the srting is");
            for (i = 0; i <= count; i++)
            {
                Console.WriteLine(stringarray[i]);
            }
        }
    }
}
