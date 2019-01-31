// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BubbleSortFileInt.cs" company="Bridgelabz">
//   Copyright © 2015 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace AlgorithmPrograms
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The class is to execute the bubble sort on the data extracted from file
    /// </summary>
    public class BubbleSortFileInt
    {
        /// <summary>
        /// Writes and reads data from file.
        /// </summary>
        public void BubbleSortFileIntDemo()
        {
            try
            {
                Console.WriteLine("Enter the numbers of elements for int array");
                int i, count = Utility.IsInteger(Console.ReadLine());
                int[] array = new int[count];
                Console.WriteLine("Enter the integer elements for int array");
                //// taking input for integer array
                for (i = 0; i < count; i++)
                {
                    array[i] = Utility.IsInteger(Console.ReadLine());
                }

                string s = string.Empty;
                //// entering numbers to string and separating them by spaces
                for (i = 0; i < count; i++)
                {
                    s = s + (array[i].ToString() + " ");
                }
                //// creating object to write to a file
                StreamWriter sw = new StreamWriter("integers.txt");
                sw.WriteLine(s);
                sw.Close();
                StreamReader sr = new StreamReader("integers.txt");
                count = 0;
                s = sr.ReadLine();
                sr.Close();
                foreach (char c in s)
                {
                    if (c == ' ')
                    {
                        count++;
                    }
                }

                Console.WriteLine("number of elements in array is " + count);
                int[] newarray = new int[count];
                i = 0;
                int temp = 0;
                foreach (char c in s)
                {
                    //// checking is the string has empty space if yes it means a new word starts after it
                    if (c.ToString().Equals(" "))
                    {
                        newarray[i] = temp;
                        temp = 0;
                        i++;
                    }
                    //// untill space is encountered we store the array
                    else if (i < count)
                    {
                        temp = (temp * 10) + Convert.ToInt32(c.ToString());
                    }
                }
                //// getting the sorted array
                newarray = Utility.BubbleSortInt(newarray, count);
                Console.WriteLine("After sort array is");
                for (i = 0; i < count; i++)
                {
                    Console.Write("{0} ", newarray[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
