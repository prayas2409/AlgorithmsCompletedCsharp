// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{  
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The class consist of programs that'll be used multiple times
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// The method is to validate the input integer
        /// </summary>
        /// <param name="input">its the input string to check its an integer</param>
        /// <returns>an integer number</returns>
        public static int IsInteger(string input)
        {
            if (int.TryParse(input, out int num))
            {
                return Convert.ToInt32(input);
            }
            else
            {
                while (int.TryParse(input, out num) == false)
                {
                    Console.WriteLine("You have not entered an integer number please try again");
                    input = Console.ReadLine();
                }

                return Convert.ToInt32(input);
            }
        }

        /// <summary>
        /// The method is to validate the input double
        /// </summary>
        /// <param name="input">its the input string to check its double</param>
        /// <returns>a double value</returns>
        public static double IsDouble(string input)
        {
            double num;
            //// trying to convert the string to double returns true if successful
            if (double.TryParse(input, out num))
            {
                return num;
            }
            else
            {
                while (double.TryParse(input, out num) == false)
                {
                    Console.WriteLine("You have not entered a number please try again");
                    input = Console.ReadLine();
                }

                return num;
            }
        }

        /// <summary>
        /// Determines whether the specified input is string.
        /// </summary>
        /// <param name="input">The input is to check if string has spaces or digits</param>
        /// <returns>
        /// <c>true</c> if the specified input is not having a number and any spaces; otherwise, <c>false</c>.
        /// </returns>
        public static string IsString(string input)
        {
            int flag = 1;
            do
            {
                int i = 0;
                if (input.Contains(" "))
                {
                    flag = 1;
                    Console.WriteLine("You have entered space it should not be, please try again");
                    input = Console.ReadLine();
                }
                //// it checks it the string has spaces
                for (i = 0; i < 10; i++)
                {
                    if (input.Contains(i.ToString()))
                    {
                        flag = 1;
                        Console.WriteLine("You have entered number in string it should not be please try again");
                        input = Console.ReadLine();
                        break;
                    }
                    else
                    {
                        flag = 0;
                    }
                }
            }
            while (flag == 1);
            return input;
        }

        /// <summary>Determines whether the specified input is boolean.</summary>
        /// <param name="input">The input.</param>
        /// <returns>
        /// <c>true</c> if the specified input is boolean; otherwise, <c>false</c>.</returns>
        public static bool IsBoolean(string input)
        {
            input.ToLower();
            ////this check the value of input if its true or false
            while (string.Equals(input, "true") != true && string.Equals(input, "false") != true)
            {
                input.ToLower();
                Console.WriteLine("You have not entered a boolean value please try again");
                input = Console.ReadLine();
            }

            return input.Equals("true") ? true : false;
        }

        /// <summary>
        /// It prints 2d arrays
        /// </summary>
        /// <typeparam name="template">generic 2 d array</typeparam>
        /// <param name="array"> Is the name of 2d array</param>
        public static void Print2DArray<template>(template[,] array)
        {
            int rows = 0, cols = 0;
            for (rows = 0; rows < array.GetLength(0); rows++)
            {
                for (cols = 0; cols < array.GetLength(1); cols++)
                {
                    Console.Write("{0} ", array[rows, cols]);
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// generates random double element
        /// </summary>
        /// <returns>it returns random double value</returns>
        public static double RandomDoubleGenerator()
        {
            Random rand = new Random();
            return rand.NextDouble();
        }

        /// <summary>
        /// It generates random integer.
        /// </summary>
        /// <param name="min">The minimum is range from where the random should begin</param>
        /// <param name="max">The maximum is the max value till where the random should be generated</param>
        /// <returns>returns the random integer</returns>
        public static int RandomIntGenerator(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max + 1);
        }

        /// <summary>
        /// Sorts the character array.
        /// </summary>
        /// <param name="a"> its the character array to be sorted</param>
        /// <returns> returns sorted character array </returns>
        public static char[] SortChar(char[] a)
        {
            int i, j;
            char temp;
            for (i = 0; i < a.Length; i++)
            {
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            return a;
        }

        /// <summary>
        /// Checks if both the input strings are anagrams by sorting and checking the sorted elements 
        /// </summary>
        /// <param name="string1">it is first string as argument</param>
        /// <param name="string2">2nd string argument to check if its anagram </param>
        public static void Anagram(string string1, string string2)
        {
            int i, flag = 0;

            if (string1.Length != string2.Length)
            {
                ////System.out.println("Strings are not anagrams");
                return;
            }

            char[] aS1 = new char[string1.Length];
            char[] aS2 = new char[string2.Length];

            for (i = 0; i < string1.Length; i++)
            {
                aS1[i] = string1[i];
            }

            for (i = 0; i < string2.Length; i++)
            {
                aS2[i] = string2[i];
            }

            aS1 = SortChar(aS1);
            aS2 = SortChar(aS2);
            for (i = 0; i < string1.Length; i++)
            {
                if (aS1[i] != aS2[i])
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine(string1 + " and " + string2 + " are anagrams ");
            }
        }

        /// <summary>
        /// checks is the input number prime and returns bool value for the same
        /// </summary>
        /// <param name="num">This is the number input to check if its prime</param>
        /// <returns>true if prime else false</returns>
        public static bool CheckPrime(int num)
        {
            int j;
            bool flag = true;
            for (j = 2; j <= num / 2; j++)
            {
                //// check if the number is divisible by any number between 2 or the half of that number
                if (num % j == 0)
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }

        /// <summary>
        /// Swipes all the element to right from index till the index 'till'
        /// </summary>
        /// <param name="array">the array in which swiping has to be done</param>
        /// <param name="index">swap from this index</param>
        /// <param name="till">swap till this index</param>
        /// <returns>It returns the resultant array after swiping</returns>
        public static int[] SwipeInt(int[] array, int index, int till)
        {
            int j;
            for (j = index; j >= 1; j--)
            {
                array[j] = array[j - 1];
            }

            return array;
        }

        /// <summary>
        /// Swipes String to right from index till till
        /// </summary>
        /// <param name="array">The array to be swiped</param>
        /// <param name="index">Index till which we need to swap</param>
        /// <param name="till">Swipe till this index</param>
        /// <returns>It returns the string array after swipe</returns>
        public static string[] SwipeString(string[] array, int index, int till)
        {
            int j;
            for (j = index; j >= till + 1; j--)
            {
                array[j] = array[j - 1];
            }

            return array;
        }

        /// <summary>
        /// Sorts integer array using insertion sort
        /// </summary>
        /// <param name="array">This is the array in which insertion sort has to be performed</param>
        /// <param name="length">This is the length of the array</param>
        /// <returns>it returns the sorted array</returns>
        public static int[] InsertionSortInt(int[] array, int length)
        {
            int i, j, temp, index;

            for (j = 0; j < length; j++)
            {
                for (i = j + 1; i < length; i++)
                {
                    if (array[j] > array[i])
                    {
                        temp = array[i];
                        index = i;
                        array = SwipeInt(array, index, i);
                        array[j] = temp;
                    }
                }
            }
            
            return array;
        }

        /// <summary>
        /// Sorts String array using insertion sort
        /// </summary>
        /// <param name="array">The string array on which the commenting has to be done</param>
        /// <param name="length">The length of string array</param>
        /// <returns>The sorted string</returns>
        public static string[] InsertionSortString(string[] array, int length)
        {
            int i, j, index;
            string temp;
            for (j = 0; j < length - 1; j++)
            {
                for (i = j + 1; i < length; i++)
                {
                    if (string.Compare(array[j], array[i]) > 1)
                    {
                        temp = array[i];
                        index = i;
                        array = SwipeString(array, index, i);
                        array[j] = temp;
                    }
                }
            }
            
            return array;
        }

        /// <summary>
        /// Sorts integer array using Bubble sort
        /// </summary>
        /// <param name="array">The array to be sorted</param>
        /// <param name="length">length of the input array</param>
        /// <returns>The sorted array</returns>
        public static int[] BubbleSortInt(int[] array, int length)
        {
            int i, j, temp;
            for (i = 0; i < length; i++)
            {
                for (j = 0; j < length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// Sorts String  array using Bubble sort
        /// </summary>
        /// <param name="array">The array to be sorted</param>
        /// <param name="length">length of the input array</param>
        /// <returns>The sorted string array</returns>
        public static string[] BubbleSortString(string[] array, int length)
        {
            int i, j;
            string temp;
            for (i = 0; i < length; i++)
            {
                for (j = 0; j < length - 1; j++)
                {
                    if (string.Compare(array[j], array[j + 1]) > 0)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// Binaries the search int.
        /// </summary>
        /// <param name="array">The array of integers in which we need to search</param>
        /// <param name="num">The number to be searched array</param>
        public static void BinarySearchInt(int[] array, int num)
        {
            int i, length, low, high, mid;
            array = BubbleSortInt(array, array.Length);
            length = array.Length;

            low = 0;
            high = length - 1;
            for (i = 0; i < (length / 2) + 1; i++)
            {
                mid = (low + high) / 2;
                if (num == array[mid])
                {
                    Console.WriteLine("Number found at position " + (mid + 1));
                    return;
                }

                if (num < array[mid])
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            Console.WriteLine("Number not found");
        }

        /// <summary>
        /// Searches a String in string array using Binary search
        /// </summary>
        /// <param name="array">The string array on which the binary search is to be done</param>
        /// <param name="num">The array to be searched int the array</param>
        public static void BinarySearchString(string[] array, string num)
        {
            int i, length, low, high, mid;
            length = array.Length;
            low = 0;
            high = length - 1;
            for (i = 0; i < length; i++)
            {
                mid = (low + high) / 2;
                if (string.Compare(num, array[mid]) == 0)
                {
                    Console.WriteLine("string found at position " + (mid + 1));
                    return;
                }

                if (string.Compare(num, array[mid]) < 0)
                {
                    Console.Write("in num<amid and amid= {0}  ", array[mid]);
                    high = mid;
                }
                else
                {
                    Console.Write("in num>amid  and amid= {0}  ", array[mid]);
                    low = mid + 1;
                }
            }

            Console.WriteLine("String not found");
        }

        /// <summary>
        /// checks is the number power of 2 if yes returns power else 0
        /// </summary>
        /// <param name="num">IT checks if the number is a power of 2</param>
        /// <returns>returns power if its power of 2 else return 0</returns>
        public static int IsPowerOfTwo(int num)
        {
            int power = 0, temp;
            temp = num;
            while (temp > 0 && temp % 2 == 0)
            {
                if (temp % 2 == 0 && temp / 2 == 1)
                {
                    return ++power;
                }

                temp = temp / 2;
                power++;
            }

            return 0;
        }

        /// <summary>
        /// calculates 2^num
        /// </summary>
        /// <param name="num">finds the number that is 2^num</param>
        /// <returns>Returns 2^n</returns>
        public static int PowerOfTwo(int num)
        {
            int i = 1;
            //// i stores the number 2^n
            while (num > 0)
            {
                i = i * 2;
                num--;
            }

            return i;
        }

        /// <summary>
        /// combines 2 arrays after comparing the smaller elements in both arrays
        /// </summary>
        /// <param name="a">First half to be combined</param>
        /// <param name="la">Length of first half array</param>
        /// <param name="b">Second part to be combined</param>
        /// <param name="lb">Length of the second part</param>
        /// <returns>The combined array</returns>
        public static string[] Combine(string[] a, int la, string[] b, int lb)
        {
            //// i counts the lenth of a
            //// k counts the length of b
            //// j counts the length of c that is destination
            int j, i = 0, k = 0;
            ////c is the destination array where both string a and b will be stored
            string[] c = new string[la + lb];
            i = 0;
            for (j = 0; j < c.Length; j++)
            {
                //// if b is completely added to array then add all the elements of a
                if (k >= lb && i < la)
                {
                    c[j] = a[i];
                    i++;
                }
                else if (i >= la && k < lb)
                {
                    //// if A is completely added to array then add b 
                    c[j] = b[k];
                    k++;
                }
                else
                {                   
                    //// if element of b is smaller than or equal to a's element
                    if (b[k].CompareTo(a[i]) <= 0 && k < lb)
                    {
                        c[j] = b[k];
                        k++;
                    }
                    else if (b[k].CompareTo(a[i]) >= 1 && i < la)
                    {
                        //// if element of b is greater than a's element then add b's element
                        c[j] = a[i];
                        i++;
                    }
                }
            }

            return c;
        }

        /// <summary>
        /// Sorts Strings using merge sort
        /// </summary>
        /// <param name="a">The array to be sorted</param>
        /// <param name="low">The starting index of the array</param>
        /// <param name="high">The max index of the array</param>
        /// <returns>The sorted string array</returns>
        public static string[] MergeSortString(string[] a, int low, int high)
        {
            int mid = low + ((high - low) / 2);
            //// r1 stores first half merge, r2 stores next half and c stores the combined one of both the halves
            string[] r1 = new string[mid - low + 1], r2 = new string[high - mid], c = new string[high - low + 1];
            if (low < high)
            {
                r1 = MergeSortString(a, low, mid);
                r2 = MergeSortString(a, mid + 1, high);
                c = Combine(r1, mid - low + 1, r2, high - mid);
                return c;
            }
            else
            {
                //// returning the only element in the array
                c[0] = a[low];
                return c;
            }
        }

        /// <summary>
        /// Checks day of the week on the date provided
        /// </summary>
        /// <param name="day">The date on the day</param>
        /// <param name="month">Month in the date</param>
        /// /// <param name="year">Year in the date</param>
        public static void DayOfWeek(int day, int month, int year)
        {
            int y0, x, m0, d0;
            y0 = year - ((14 - month) / 12);
            x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            m0 = month + (12 * ((14 - month) / 12)) - 2;
            d0 = (day + x + ((31 * month) / 12)) % 7;

            string[] months = new string[] 
            {
                "January", "Feb", "March", "April", "May", "June", "July", "August", "September", "October", "November",
                        "December"
            };
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("The day on this date is " + days[d0 - 1]);
        }

        /// <summary>
        /// Finds out monthly payment to be made
        /// </summary>
        /// <param name="p">The principal loan</param>
        /// <param name="y">Y years to pay off</param>
        /// <param name="r">R per cent interest compounded monthly</param>
        public static void MonthlyPayment(int p, int y, double r)
        {
            int n;
            double r1, denominator, payment;
            n = 12 * y;
            r1 = r / 1200.0;             
            //// below functionality can be done by denominator=Math.Pow(denominator, -n);
            denominator = 1;
            //// calculating (1+r)^n
            for (int i = 1; i < n; i++)
            {
                denominator = denominator * (1 + r1);
            }
            //// calculating (1+r)^-n
            denominator = (float)(1.0 / denominator);
            Console.WriteLine("denominator: " + denominator);
            denominator = 1 + denominator;
            payment = (p * r1) / denominator;
            Console.WriteLine("Payment to be made monthly: " + payment);
        }

        /// <summary>
        /// converts the number to binary printing 0 and 1
        /// </summary>
        /// <param name="num">THe number to be convert the to binary</param>
        /// <returns>The binary array</returns>
        public static int[] ToBinary(int num)
        {
            int count, i = 0, power = 1;

            //// calculating the power of 2 just greater than number
            for (; num >= power; i++)
            {
                power *= 2;
            }
            //// count will keep track of n in 2^n
            //// values store 1,2,4,8
            //// nums store numbers which will be used to calculate the number
            count = i;
            int[] values = new int[i], nums = new int[i];
            //// storing values 16 8 4 2 in values
            for (i = 0; power > 1; i++)
            {
                power = power / 2;
                values[i] = power;
            }
            //// storing power into count
            count = i;
            ////  Console.WriteLine();
            i = 0;
            while (num > 0)
            {
                //// printing 1 for only those numbers which will be used to calculate  number
                //// also storing the value 1 for the numbers that are used
                if (num >= values[i])
                {
                    num = num - values[i];
                    nums[i] = 1;
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }

                i++;
            }

            Console.WriteLine();
            count--;
            //// count is the power
            Console.WriteLine("In 8 bits");            
            int[] nums8bit = To8Bit(nums, count);
            for (i = 0; i < 8; i++)
            {
                Console.Write(nums8bit[i]);
            }

            Console.WriteLine();
            return nums8bit;
        }

        /// <summary>
        /// Converts array of 2 or 4 bits to 8 bit binary digits
        /// </summary>
        /// <param name="nums">The array of 2 or 4 bit number</param>
        /// <param name="count">The the length of the received array</param>
        /// <returns>The 8 bit integer array</returns>
        public static int[] To8Bit(int[] nums, int count)
        {
            int i;
            int[] nums8bit = new int[8];
            for (i = 7; count >= 0; i--)
            {
                nums8bit[i] = nums[count];
                count--;
            }

            Console.WriteLine();
            return nums8bit;
        }
    }   
}
