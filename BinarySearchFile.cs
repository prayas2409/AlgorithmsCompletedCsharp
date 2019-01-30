// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearchFile.cs" company="Bridgelabz">
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
    /// The class is to execute the program for the Binary Search on elements of file 
    /// </summary>
    public class BinarySearchFile
    {
        /// <summary>
        /// Reads and writes data to file
        /// </summary>
        public void BinarySearchFileDemo()
        { 
            //// integer elements to count  
            int i, count = 0;
            Console.WriteLine("Enter the number of lines you wish to add to file");
            int num = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("Enter the strings you wish to add to file");
            string[] string1 = new string[num];
            StreamWriter sw;
            try
            { 
            sw = new StreamWriter("test.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            sw = new StreamWriter("test.txt");
            for (i = 0; i < num; i++)
            {
                string1[i] = Utility.IsString(Console.ReadLine());
                sw.Write(string1[i]);
                if (i < num - 1)
                {
                    sw.Write(",");
                }
            }

            sw.Close();
            //// creating a reader
            StreamReader sr = new StreamReader("test.txt");
            string copy;
            i = 0;
            copy = sr.ReadLine();            
            Console.WriteLine("reading from copies string");
            //// counting number of words
            foreach (char c in copy)
            {
                if (c == ',')
                {
                    count++;
                }
            }

            string[] stringarray = new string[count + 1];
            string temp = "";
            i = 0;
            //// separates the complete string into words
            foreach (char c in copy)
            {
                if (c != ',')
                {
                    temp = temp + c;
                }
                else
                {
                    stringarray[i] = temp;
                    i++;
                    temp = "";
                }

                stringarray[i] = temp;
            }

            for (i = 0; i <= count; i++)
            {
                Console.WriteLine(stringarray[i]);
            }
        }           
    }
}