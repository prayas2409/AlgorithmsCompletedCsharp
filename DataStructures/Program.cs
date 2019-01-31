// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures
{
    using System;

    /// <summary>
    /// The main class to execute all
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            int i, number;
            string[] programs = { "Unsorted List First enter data to file", "OrderedList" };
            do
            {
                //// printing the names of programs
                for (i = 0; i < programs.Length; i++)
                {
                    Console.WriteLine("Enter {0} for {1}", i + 1, programs[i]);
                }

                Console.WriteLine("Enter question number of program to execute it and Enter 0 to close");
                number = Utility.IsInteger(Console.ReadLine());
                
                switch (number)
                {
                    case 0:
                        return;                        
                    case 1:
                        UnorderedList ul = new UnorderedList();
                        ul.UnorderedListDemo();
                        break;
                    case 2:
                        OrderedList ol = new OrderedList();
                        ol.OrderedLinkedListDemo();
                        break;
                    default:
                        Console.WriteLine("Not yet created");
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            }
            while (number != 0);
        }    
    }
}
