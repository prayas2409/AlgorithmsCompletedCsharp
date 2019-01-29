using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class StopwatchForAlgos
    {
        public void ElapsedTimeForAlgos()
        {
            double start = 0, stop = 0;

            int intlength, stringlength, i, j;
            
            Console.WriteLine("Enter the length of integer array");
            intlength = Utility.IsInteger(Console.ReadLine());
            int[] array = new int[intlength]; //integer array
            int[] tempintar = new int[intlength];
            Console.WriteLine("Enter the array");
            for (i = 0; i < intlength; i++) array[i] = Utility.IsInteger(Console.ReadLine()); ;
             

            Console.WriteLine("Enter the length of string array");
            stringlength = Utility.IsInteger(Console.ReadLine());
            String[] stringarray = new String[stringlength];
            String[] tempstringar = new String[stringlength];
            Console.WriteLine("Enter the array");
           
            for (i = 0; i < stringlength; i++) stringarray[i] = Utility.IsString(Console.ReadLine());
            //stopwatch
            double[] times = new double[6];
            String[] S = new String[6];

            start = Convert.ToDouble(DateTime.Now.Millisecond);
            tempintar = Utility.InsertionSortInt(array, intlength);
            stop = Convert.ToDouble(DateTime.Now.Millisecond);
            times[0] = stop - start;
            S[0] = "InsertionsortInt";
            Console.WriteLine("After insertion sort int");
            
           start = Convert.ToDouble(DateTime.Now.Millisecond);
            tempstringar = Utility.InsertionSortString(stringarray, stringlength);
            stop = Convert.ToDouble(DateTime.Now.Millisecond);
            times[1] = stop - start;
            S[1] = "InsertionsortString";
            Console.WriteLine("After insertion sort String");
           
            start = Convert.ToDouble(DateTime.Now.Millisecond);
            stringarray = Utility.BubbleSortString(stringarray, stringlength);
            stop = Convert.ToDouble(DateTime.Now.Millisecond);
            times[2] = stop - start;
            S[2] = "BubblesortString";
            Console.WriteLine("After Bubble sort String");

            start = Convert.ToDouble(DateTime.Now.Millisecond);
            array = Utility.BubbleSortInt(array, intlength);
            stop = Convert.ToDouble(DateTime.Now.Millisecond);
            times[3] = stop - start;
            S[3] = "BubblesortInt";
            Console.WriteLine("After Bubble sort Int");

            Console.WriteLine("Enter the number to be searched");
            int num = Utility.IsInteger(Console.ReadLine());

            start = Convert.ToDouble(DateTime.Now.Millisecond);
            Utility.BinarySearchInt(array, num);
            stop = Convert.ToDouble(DateTime.Now.Millisecond);
            times[4] = stop - start;
            S[4] = "BinarraySearchInt";
            Console.WriteLine("After Binary Search Int");

            Console.WriteLine("Enter the String to be searched");
            String search = Utility.IsString(Console.ReadLine());

            start = Convert.ToDouble(DateTime.Now.Millisecond);
            Utility.BinarySearchString(stringarray, search);
            stop = Convert.ToDouble(DateTime.Now.Millisecond);
            times[5] = stop - start;
            S[5] = "BinarraySearchString";
            Console.WriteLine("After Binary Search String");

            //Temporary variables to sort the time and names of Processes to swap
            double temp;
            String change;

            for (i = 0; i < times.Length; i++)
            {
                for (j = 0; j < times.Length - 1; j++)
                {
                    if (times[j] < times[j + 1])
                    {
                        temp = times[i];
                        change = S[i];
                        times[i] = times[j];
                        S[i] = S[j];
                        times[j] = temp;
                        S[j] = change;
                    }
                }
            }
            //printing the time taken by algos in decending order
            Console.WriteLine("Times in descending order are");

            for (i = 0; i < times.Length; i++) Console.WriteLine("Time for :" + S[i] + " is " + times[i] + " milliseconds");

        }
    }
}
