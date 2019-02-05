// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BankingCashCounter.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The class is to execute the Cash counter in bank
    /// </summary>
    public class BankingCashCounter
    {
        /// <summary>
        /// method executing the counter demo.
        /// </summary>
        public void BankingCashCounterDemo()
        {
            try
            { 
            Console.WriteLine("Enter the number of people in queue");
            int length = Utility.IsInteger(Console.ReadLine()), operation = 0, bankamount = 100000, amount;
                Queue<int> bankqueue = new Queue<int>();
                //// fectching the need of the person in the queue
                while (length > 0)
                {
                    Console.WriteLine("To Withdraw enter 1 \nTo Deposit enter 2");
                    operation = Utility.IsIntegerInRange(Console.ReadLine(), 1, 2);   
                    //// Withdraw
                    if (operation == 1)
                    {
                        bankqueue.Enqueue(1);                        
                    }                    
                    else if (operation == 2)                    
                    {
                        //// Deposits
                        bankqueue.Enqueue(2);                        
                    }

                    length--;
                }   
                //// while there is something in queue
                while (bankqueue.Count > 0)
                {
                    //// if next element is to be withdrawn
                    if (bankqueue.Peek() == 1)
                    {
                        Console.WriteLine("enter the amount to be withdrawn");
                        amount = Utility.IsPositiveInteger(Console.ReadLine());
                        //// if bank has required funds
                        if (bankamount > amount)
                        {
                            bankamount -= amount;
                            Console.WriteLine("Withdraw Succesful");
                            bankqueue.Dequeue();
                        }
                        else
                        {
                            Console.Write("Bank does not have sufficient funds please Re");
                        }                        
                    }                    
                    else
                    {
                        //// For depositing money
                        Console.WriteLine("Enter the amount to be Deposited");
                        amount = Utility.IsPositiveInteger(Console.ReadLine());
                        Console.WriteLine("Thank you for depositing");
                        bankamount += amount;
                        bankqueue.Dequeue();
                    }                    
                }

                Console.WriteLine("The amount in the bank is " + bankamount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Process terminated because" + e);
            }
        }
    }
}
