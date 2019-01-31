// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StopwatchForAlgos.cs" company="Bridgelabz">
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
    /// This class is to call various methods and print the time elapsed between them
    /// </summary>
    public class StopwatchForAlgos
    {
        /// <summary>
        /// this method executes the stop watch in algorithms program
        /// </summary>
        public void ElapsedTimeForAlgos()
        {
            try
            {
                double start = 0, stop = 0;

                int intlength, stringlength, i, j;

                Console.WriteLine("Enter the length of integer array");
                intlength = Utility.IsInteger(Console.ReadLine());
                int[] array = new int[intlength]; ////integer array
                int[] tempintar = new int[intlength];
                Console.WriteLine("Enter the array");
                for (i = 0; i < intlength; i++)
                {
                    array[i] = Utility.IsInteger(Console.ReadLine());
                }

                Console.WriteLine("Enter the length of string array");
                stringlength = Utility.IsInteger(Console.ReadLine());
                string[] stringarray = new string[stringlength];
                string[] tempstringar = new string[stringlength];
                Console.WriteLine("Enter the array");

                for (i = 0; i < stringlength; i++)
                {
                    stringarray[i] = Utility.IsString(Console.ReadLine());
                }
                //// stopwatch
                double[] times = new double[6];
                string[] s = new string[6];

                start = Convert.ToDouble(DateTime.Now.Millisecond);
                tempintar = Utility.InsertionSortInt(array, intlength);
                stop = Convert.ToDouble(DateTime.Now.Millisecond);
                times[0] = stop - start;
                s[0] = "InsertionsortInt";
                Console.WriteLine("After insertion sort int");

                start = Convert.ToDouble(DateTime.Now.Millisecond);
                tempstringar = Utility.InsertionSortString(stringarray, stringlength);
                stop = Convert.ToDouble(DateTime.Now.Millisecond);
                times[1] = stop - start;
                s[1] = "InsertionsortString";
                Console.WriteLine("After insertion sort String");

                start = Convert.ToDouble(DateTime.Now.Millisecond);
                stringarray = Utility.BubbleSortString(stringarray, stringlength);
                stop = Convert.ToDouble(DateTime.Now.Millisecond);
                times[2] = stop - start;
                s[2] = "BubblesortString";
                Console.WriteLine("After Bubble sort String");

                start = Convert.ToDouble(DateTime.Now.Millisecond);
                array = Utility.BubbleSortInt(array, intlength);
                stop = Convert.ToDouble(DateTime.Now.Millisecond);
                times[3] = stop - start;
                s[3] = "BubblesortInt";
                Console.WriteLine("After Bubble sort Int");

                Console.WriteLine("Enter the number to be searched");
                int num = Utility.IsInteger(Console.ReadLine());

                start = Convert.ToDouble(DateTime.Now.Millisecond);
                Utility.BinarySearchInt(array, num);
                stop = Convert.ToDouble(DateTime.Now.Millisecond);
                times[4] = stop - start;
                s[4] = "BinarraySearchInt";
                Console.WriteLine("After Binary Search Int");

                Console.WriteLine("Enter the String to be searched");
                string search = Utility.IsString(Console.ReadLine());

                start = Convert.ToDouble(DateTime.Now.Millisecond);
                Utility.BinarySearchString(stringarray, search);
                stop = Convert.ToDouble(DateTime.Now.Millisecond);
                times[5] = stop - start;
                s[5] = "BinarraySearchString";
                Console.WriteLine("After Binary Search String");

                //// Temporary variables to sort the time and names of Processes to swap
                double temp;
                string change;

                for (i = 0; i < times.Length; i++)
                {
                    for (j = 0; j < times.Length - 1; j++)
                    {
                        if (times[j] < times[j + 1])
                        {
                            temp = times[i];
                            change = s[i];
                            times[i] = times[j];
                            s[i] = s[j];
                            times[j] = temp;
                            s[j] = change;
                        }
                    }
                }
                //// printing the time taken by algos in decending order
                Console.WriteLine("Times in descending order are");

                for (i = 0; i < times.Length; i++)
                {
                    Console.WriteLine("Time for :" + s[i] + " is " + times[i] + " milliseconds");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
