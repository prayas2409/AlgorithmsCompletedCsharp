// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PalindromeDeque.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    
    /// <summary>
    /// used to execute the Palindrome Deque using LInked list
    /// </summary>
    public class PalindromeDeque
    {
        /// <summary>
        /// Its the method to execute the palindrome using deque 
        /// </summary>
        public void PalindromeDequeDemo()
        {
            try
            {
                Console.WriteLine("Enter the string to check if its a plaindrome");
                string input = Utility.IsString(Console.ReadLine());
                LinkedList<char> string1 = new LinkedList<char>();
                bool flag = true;
                foreach (char c in input)
                {
                    string1.AddLast(c);
                }

                Console.WriteLine("String in list is ");
                foreach (char c in string1)
                {
                    Console.Write(c + " ");
                }

                while (string1.Count > 1)
                {
                    if (string1.First.Value.Equals(string1.Last.Value))
                    {
                        string1.RemoveFirst();
                        string1.RemoveLast();
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a palindrome ", input);
                        flag = false;
                        break;
                    }
                }

                if (flag == true)
                {
                    Console.WriteLine("The string is a palindrome");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process is stopped because " + e);
            }
        }        
    }
}
