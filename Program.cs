// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2015 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// This class consist the main method for the project AlgorithmPrograms
    /// </summary>  
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            int i, number;
            string[] programs = { "Anagram", "Prime Number", "AnagramPalindrome mix", " Algorithm StopWatch", "Guess game", "BinarySearch in File ", "Insertion Sort Line ", "Bubble Sort File int", "Merge Sort String", "Vending Machine", "Day of Week NEEDS COMMANDLINE ARGUMENTS", "Temprature convert", "Monthly Payment NEEDS COMMANDLINE ARGUMENTS", "Sqrt Newton", "to Binary", "Nibble binary" };
            do
            {                
                for (i = 0; i < programs.Length; i++)
                {
                    Console.WriteLine("Enter {0} for {1}", i + 1, programs[i]);
                }

                Console.WriteLine("Enter question number of program to execute it and Enter 0 to close");
                number = Utility.IsInteger(Console.ReadLine());
                Console.WriteLine("num : {0}", number);
                switch (number)
                {
                    case 0:
                        return;
                    case 1:
                        Utility.Anagram("hum", "muh");                        
                        Console.ReadKey();
                        break;
                    case 2:
                        PrimeNumbers pn = new PrimeNumbers();
                        pn.PrimeNumbersDemo();
                        Console.ReadKey();
                        break;
                    case 3:
                        AnagramPalindromeInt api = new AnagramPalindromeInt();
                        api.AnagramPalindromeIntDemo();
                        Console.ReadKey();
                        break;
                    case 4:
                        StopwatchForAlgos sa = new StopwatchForAlgos();
                        sa.ElapsedTimeForAlgos();
                        Console.ReadKey();
                        break;
                    case 5:
                        GuessGame gg = new GuessGame();
                        gg.GuessGameDemo(8);
                        Console.ReadKey();
                        break;
                    case 6:
                        BinarySearchFile bsf = new BinarySearchFile();
                        bsf.BinarySearchFileDemo();
                        Console.ReadKey();
                        break;
                    case 7:
                        InsertionSortLine isl = new InsertionSortLine();
                        isl.InsertionSortLineDemo();
                        Console.ReadKey();
                        break;
                    case 8:
                        BubbleSortFileInt bsfi = new BubbleSortFileInt();
                        bsfi.BubbleSortFileIntDemo();
                        Console.ReadKey();
                        break;
                    case 9:
                        MergeSortAlgo msa = new MergeSortAlgo();
                        msa.MergeSortAlgoDemo();
                        Console.ReadKey();
                        break;
                    case 10:
                        VendingMachine vm = new VendingMachine();
                        vm.VendingMachineDemo();
                        Console.ReadKey();
                        break;
                    case 11:
                        Utility.DayOfWeek(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2]));
                        Console.ReadKey();
                        break;
                    case 12:
                        Temprature tem = new Temprature();
                        tem.TempratureDemo();
                        Console.ReadKey();
                        break;
                    case 13:
                        Utility.MonthlyPayment(Convert.ToInt32(args[2]), Convert.ToInt32(args[3]), Convert.ToDouble(args[2]));
                        Console.ReadKey();
                        break;
                    case 14:
                        NewtonSqrt.NewtonSqrtDemo();
                        Console.ReadKey();
                        break;
                    case 15:
                        Console.WriteLine("Enter the value to conver to binary");        
                        Utility.ToBinary(Utility.IsInteger(Console.ReadLine()));
                        Console.ReadKey();
                        break;
                    case 16:
                        Binary bin = new Binary();
                        bin.NibblesSwap();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Not yet created");
                        Console.ReadLine();
                        break;    
                }

                Console.Clear();
            }
            while (number != 0);
        }
    }
}