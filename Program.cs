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
            int flag = 1;
            string[] array = { "Anagram", "Prime Number", "AnagramPalindrome mix", " Algorithm StopWatch", "Guess game", "BinarySearch in File ", "Insertion Sort Line ", "Bubble Sort File int", "Merge Sort String", "Vending Machine", "Day of Week", "Temprature convert", "Monthly Payment", "Sqrt Newton", "to Binary", "Nibble binary" };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter {0} for {1}", i + 1, array[i]);
            }

            do
            {
                Console.WriteLine("Enter question number of program to execute it and Enter 0 to close");
                int number = Utility.IsInteger(Console.ReadLine());
                Console.WriteLine("num : {0}", number);
                switch (number)
                {
                    case 0:
                        return;
                    case 1:
                        Utility.Anagram("hum","muh");
                        break;
                    case 2:
                        PrimeNumbers pn = new PrimeNumbers();
                        pn.PrimeNumbersDemo();
                        break;
                    case 3:
                        AnagramPalindromeInt api = new AnagramPalindromeInt();
                        api.AnagramPalindromeIntDemo();
                        break;
                    case 4:
                        StopwatchForAlgos sa = new StopwatchForAlgos();
                        sa.ElapsedTimeForAlgos();
                        break;
                    case 5:
                        GuessGame gg = new GuessGame();
                        gg.GuessGameDemo(8);
                        break;
                    case 6:
                        BinarySearchFile bsf = new BinarySearchFile();
                        bsf.BinarySearchFileDemo();
                        break;
                    case 7:
                        InsertionSortLine isl = new InsertionSortLine();
                        isl.InsertionSortLineDemo();
                        break;
                    case 8:
                        BubbleSortFileInt bsfi = new BubbleSortFileInt();
                        bsfi.BubbleSortFileIntDemo();
                        break;
                    case 9:
                        MergeSortAlgo msa = new MergeSortAlgo();
                        msa.MergeSortAlgoDemo();
                        break;
                    case 10:
                        VendingMachine vm = new VendingMachine();
                        vm.VendingMachineDemo();
                        break;
                    case 11:
                        Utility.DayOfWeek(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2]));
                        break;
                    case 12:
                        Temprature tem = new Temprature();
                        tem.TempratureDemo();
                        break;
                    case 13:
                        Utility.MonthlyPayment(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToDouble(args[2]));
                        break;
                    case 14:
                        NewtonSqrt.NewtonSqrtDemo();
                        break;
                    case 15:
                        Console.WriteLine("Enter the value to conver to binary");        
                        Utility.ToBinary(Utility.IsInteger(Console.ReadLine()));
                        break;
                    case 16:
                        Binary bin = new Binary();
                        bin.NibblesSwap();
                        break;
                    default:
                        Console.WriteLine("Not yet created");
                        Console.ReadLine();
                        flag = 0;
                        break;
                }
            }
            while (flag == 1);
        }
    }
}