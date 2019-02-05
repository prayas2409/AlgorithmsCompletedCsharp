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
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                int i, number;
                string[] programs = { "Unsorted List First enter data to file", "OrderedList", "BalancedParenthesis", "BankingCashCounter", "PalindromeDeque", "HashMaps", "BinarySearchTree", "CalenderPrinter", " CalenderLinkedList", " CalenderStack", "Prime2DArray", "PrimeAnagram", " PrimeAnagramStack", "PrimeAnagramQueue", "CustomLinkedListExecute" };
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
                        case 3:
                            BalancedParenthesis bp = new BalancedParenthesis();
                            bp.BalancedParenthesisDemo();
                            break;
                        case 4:
                            BankingCashCounter bcc = new BankingCashCounter();
                            bcc.BankingCashCounterDemo();
                            break;
                        case 5:
                            PalindromeDeque pd = new PalindromeDeque();
                            pd.PalindromeDequeDemo();
                            break;
                        case 6:
                            HashMaps hm = new HashMaps();
                            hm.HashMapsDemo();
                            break;
                        case 7:
                            BinarySearchTree bst = new BinarySearchTree();
                            bst.BinarySearchTreeDemo();
                            break;
                        case 8:
                            CalenderPrinter cp = new CalenderPrinter();
                            cp.CalenderPrinterDemo();
                            break;
                        case 9:
                            CalenderLinkedList cll = new CalenderLinkedList();
                            cll.CalenderLinkedlistDemo();
                            break;
                        case 10:
                            CalenderStack cs = new CalenderStack();
                            cs.CalenderStackDemo();
                            break;
                        case 11:
                            Prime2DArray p2d = new Prime2DArray();
                            p2d.Prime2DarrayDemo();
                            break;
                        case 12:
                            PrimeAnagram pa = new PrimeAnagram();
                            pa.PrimeAnagramDemo();
                            break;
                        case 13:
                            PrimeAnagramStack pas = new PrimeAnagramStack();
                            pas.PrimeAnagramStackDemo();
                            break;
                        case 14:
                            PrimeAnagramQueue paq = new PrimeAnagramQueue();
                            paq.PrimeAnagramQueueDemo();
                            break;
                        case 15:
                            CustomLinkedListExecute clle = new CustomLinkedListExecute();
                            clle.CustomLinkedListExecuteDemo();
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
            catch (Exception e)
            {
                Console.WriteLine("The process is stopped because " + e);
            }
        }    
    }
}
