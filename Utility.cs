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
        /// <param name="input"></param>
        /// <returns>an integer number</returns>
        public static int IsInteger(string input)
        {
            if (Int32.TryParse(input, out int num)) return Convert.ToInt32(input); 
            else
            {
                while (Int32.TryParse(input, out num) == false)
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
        /// <param name="input"></param>
        /// <returns>a double value</returns>
        public static double IsDouble(string input)
        {
            double num;
            if (Double.TryParse(input, out num)) return num;
            else
            {
                while (Double.TryParse(input, out num) == false)
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
        /// <param name="input">The input.</param>
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
                // it checks it the string has spaces
                for (i = 0; i < 10; i++)
                {
                    if (input.Contains(i.ToString()))
                    {
                        flag = 1;
                        Console.WriteLine("You have entered number in string it should not be please try again");
                        input = Console.ReadLine();
                        break;
                    }
                    else flag = 0;
                }
            } while (flag == 1);
            return input;
        }
        /// <summary>Determines whether the specified input is boolean.</summary>
        /// <param name="input">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is boolean; otherwise, <c>false</c>.</returns>
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
        /// <typeparam name="Template"></typeparam>
        /// <param name="array"></param>
        public static void Print2DArray<Template>(Template[,] array)
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
        /// <returns></returns>
        public static double RandomDoubleGenerator()
        {
            Random rand = new Random();
            return rand.NextDouble();
        }
        public static int RandomIntGenerator(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max + 1);
        }

        static char[] SortChar(char[] a)
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
        /// Checks if both the input strings are anagrams
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
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
            if (flag == 0) Console.WriteLine(string1 + " and " + string2 + " are anagrams ");            
        }
        /// <summary>
        /// checks is the input number prime and returns bool value for the same
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool CheckPrime(int num)
        {
            int j;
            bool flag = true;
            for (j = 2; j <= num / 2; j++)
            {
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
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <param name="till"></param>
        /// <returns></returns>
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
        /// Swipes Srting to right from index till till
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <param name="till"></param>
        /// <returns></returns>
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
        /// <param name="array"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static int[] InsertionSortInt(int[] array, int length)
        {
            int i, j, temp, index;

            for (j = 0; j < length; j++)
            {
                //System.out.println("In j= "+j);
                for (i = j + 1; i < length; i++)
                {
                    if (array[j] > array[i])
                    {
                        temp = array[i];
                        index = i;
                        array = SwipeInt(array, index, i);
                        array[j] = temp;
                        //	System.out.println("Array after swipe ");
                        //for(int c=0;c<length;c++)System.out.print(" "+array[c]);
                        //	System.out.println();						
                    }
                }
            }
            //System.out.println("The sorted array is");
            //for(i=0;i<length;i++) System.out.print(" "+array[i]);
            return array;
        }
        /// <summary>
        /// Sorts String array using insertion sort
        /// </summary>
        /// <param name="array"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string[] InsertionSortString(string[] array, int length)
        {
            int i, j, index;
            String temp;

            for (j = 0; j < length - 1; j++)
            {
                //System.out.println("In j= "+j);
                for (i = j + 1; i < length; i++)
                {
                    if (string.Compare(array[j], (array[i])) > 1)
                    {
                        temp = array[i];
                        index = i;
                        array = SwipeString(array, index, i);
                        array[j] = temp;
                        //System.out.println("Array after swipe ");
                        //	for(int c=0;c<length;c++)System.out.print(" "+array[c]);
                        //	System.out.println();						
                    }
                }
            }
            //	System.out.println("The sorted array is");
            //for(i=0;i<length;i++) System.out.print(" "+array[i]);
            return array;
        }
        /// <summary>
        /// Sorts integer array using Bubble sort
        /// </summary>
        /// <param name="array"></param>
        /// <param name="length"></param>
        /// <returns></returns>
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
        /// <param name="array"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string[] BubbleSortString(string[] array, int length)
        {

            int i, j;
            String temp;

            for (i = 0; i < length; i++)
            {
                for (j = 0; j < length - 1; j++)
                {
                    if (string.Compare(array[j], (array[j + 1])) > 0)
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
        /// Searchs a number in integer array using Binary search
        /// </summary>
        /// <param name="array"></param>
        /// <param name="num"></param>
        public static void BinarySearchInt(int[] array, int num)
        {
            int i, length, low, high, mid;
            array = BubbleSortInt(array, array.Length);
            length = array.Length;

            low = 0;
            high = length - 1;


            for (i = 0; i < length / 2 + 1; i++)
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
        /// Searchs a String in string array using Binary search
        /// </summary>
        /// <param name="array"></param>
        /// <param name="num"></param>
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
        /// <param name="num"></param>
        /// <returns></returns>
        public static int IsPowerOfTwo(int num)
        {
            int power = 0, temp;
            temp = num;
            while (temp > 0 && temp % 2 == 0)
            {
                if (temp % 2 == 0 && temp / 2 == 1) return ++power;
                temp = temp / 2;
                power++;
            }
            return 0;
        }
        /// <summary>
        /// calculates 2^num
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int PowerOfTwo(int num)
        {
            int i=1;
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
        /// <param name="a"></param>
        /// <param name="la"></param>
        /// <param name="b"></param>
        /// <param name="lb"></param>
        /// <returns></returns>
        public static string[] Combine(string[] a, int la, string[] b, int lb)
        {
            //// i counts the lenth of a
            /// k counts the length of b
            /// j counts the length of c that is destination
            int j, i = 0, k = 0;
            //c is the destination array where both string a and b will be stored
            String[] c = new String[la + lb];
            i = 0;
            for (j = 0; j < c.Length; j++)
            {
                //if b is completely added to array then add all the elements of a
                if (k >= lb && i < la)
                {
                    c[j] = "" + a[i];
                    i++;
                }//if A is completely added to array then add b 
                else if (i >= la && k < lb)
                {
                    c[j] = "" + b[k];
                    k++;
                }
                else
                {                   
                    //if element of b is smaller than or equal to a's element
                    if (b[k].CompareTo(a[i]) <= 0 && k < lb)
                    {
                        c[j] = "" + b[k];
                        k++;
                    }//if element of b is greater than a's element then add b's element
                    else if (b[k].CompareTo(a[i]) >= 1 && i < la)
                    {
                        c[j] = "" + a[i];
                        i++;
                    }
                }
            }
            for (i = 0; i <= (la + lb - 1); i++) Console.Write(" " + c[i]);
            Console.WriteLine();
            return c;
        }
        /// <summary>
        /// Sorts Srtings using merge sort
        /// </summary>
        /// <param name="a"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public static string[] MergeSortString(string[] a, int low, int high)
        {
            int mid = low + (high - low) / 2;
            //r1 stores first half merge, r2 stores next half and c stores the combined one of both the halves
            String[] r1 = new String[mid - low + 1], r2 = new String[high - mid], c = new String[high - low + 1];
            if (low < high)
            {
                r1 = MergeSortString(a, low, mid);
                r2 = MergeSortString(a, mid + 1, high);
                c = Combine(r1, (mid - low + 1), r2, high - mid);
                return c;
            }
            else
            {
                //returning the only element in the array
                c[0] = "" + a[low];
                return c;
            }
        }
        /// <summary>
        /// Checks day of the week on the date provided
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        public static void DayOfWeek(int day,int month, int year)
        {
            int y0, x, m0, d0;
            y0 = year - (14 - month) / 12;
            x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = month + 12 * ((14 - month) / 12) - 2;
            d0 = (day + x + (31 * month) / 12) % 7;

            String[] months = new String[] {
                "January","Feb","March","April","May","June","July","August","September","October","November",
                        "December"
            };
            String[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.WriteLine("The day on this date is " + days[d0 - 1]);

        }
        /// <summary>
        /// Finds out monthly payment to be made
        /// </summary>
        /// <param name="P"></param>
        /// <param name="Y"></param>
        /// <param name="R"></param>
        public static void MonthlyPayment(int P, int Y, double R)
        {
            int n;
            double r, denominator,payment;
            n = 12 * Y;
            r = R / 1200.0;

             
            // below functionality can be done by denominator=Math.Pow(denominator, -n);
            denominator = 1;
            //calculating (1+r)^-n
            for (int i = 1; i < n; i++)
            {
                denominator = denominator * (1 + r);
            }
            //calculating 1+ (1+r)^-n
            denominator = (float)(1.0 / denominator);
            Console.WriteLine("denominator: " + denominator);
            denominator = 1 + denominator;
            payment = (P * r) / (denominator);
            Console.WriteLine("Payment to be made monthly: "+payment);
        }
        /// <summary>
        /// converts the number to binary printing 0 and 1
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int[] ToBinary(int num)
        {
            int count, i = 0, power = 1;

            //calculating the power of 2 just greater than number
            for (; num >= power; i++)
            {
                power *= 2;
            }
            /*
		 * count will keep track of n in 2^n
		 * values store 1,2,4,8
		 * nums store which number will be used to calculate the number
		 */
            count = i;
            int[] values = new int[i], nums = new int[i];
            //storing values 16 8 4 2 in values
            for (i = 0; power > 1; i++)
            {
                power = power / 2;
                values[i] = power;
            }
            //storing power into count
            count = i;
         //   for (i = 0; i < count; i++) Console.Write(" " + values[i]);
         //   Console.WriteLine();
            i = 0;
            while (num > 0)
            {
                // printing 1 for only those numbers which will be used to calculate  number
                //also storing the value 1 for the numbers that are used
                if (num >= values[i])
                {
                    num = num - values[i];
                    nums[i] = 1;
                    Console.Write("1");
                }
                else Console.Write("0");
                i++;
            }
            Console.WriteLine();
            count--;
            //count is the power
            Console.WriteLine("In 8 bits");            
            int[] nums8bit = To8Bit(nums,count);
            for (i = 0; i < 8; i++) Console.Write(nums8bit[i]);
            Console.WriteLine();
            return nums8bit;
        }
        /// <summary>
        /// Converts array of 2 or 4 bits to 8 bit binary digits
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static int[] To8Bit(int[] nums,int count)
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


