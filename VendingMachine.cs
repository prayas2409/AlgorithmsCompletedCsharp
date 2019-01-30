// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="Bridgelabz">
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
    /// The class is to execute the vending machine
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// Executes the vending machine program
        /// </summary>
        public void VendingMachineDemo()
        {
            ////Stores the notes 
            int[] array = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            //// i is used to traverse the array of notes, num stores amount to be stored
            //// count counts the number of notes required to be given to withdraw the amount
            int i = 0, num, count = 0;
            Console.WriteLine(" Enter the amount to be withdrawn");
            num = Utility.IsInteger(Console.ReadLine());

            while (num > 0)
            {
                if (num / array[i] > 0)
                {
                    Console.WriteLine("{0} {1} rupee notes", num / array[i], array[i]);
                    count = count + (num / array[i]);
                    num = num - (array[i] * (num / array[i]));
                }
                else
                {
                    i++;
                }
            }
            
            Console.WriteLine("THe minimum notes required is {0}", count);
        }
    }
}
