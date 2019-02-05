// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeAnagramStack.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// ---------------------------------------------------------------------------------------------------------------------

namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The class to execute the prime anagram stack code
    /// </summary>
    public class PrimeAnagramStack
    {
        /// <summary>
        /// Method to execute the prime anagram stack demo.
        /// </summary>
        public void PrimeAnagramStackDemo()
        {
            try
            {
                int[,] primenumbers = new int[10, 50];
                int i = 0, j;
                primenumbers[0, 0] = 0;
                int[,] anagram = new int[10, 20];

                PrimeAnagram pa = new PrimeAnagram();
                anagram = pa.PrimeAnagramDemo();

                PrimeAnagramClass pac;
                //// Collection Linked list
                LinkedList<PrimeAnagramClass> llpac = new LinkedList<PrimeAnagramClass>();
                //// Custom Linked list
                LinkedListClass llc = new LinkedListClass();
                for (i = 0; i < 10; i++)
                {
                    pac = new PrimeAnagramClass();
                    pac.SetRange(anagram[i, 0]);
                    for (j = 1; anagram[i, j] != 0; j++)
                    {
                        pac.SetAnagrams(anagram[i, j]);
                    }
                    //// collection linked list
                    llpac.AddFirst(pac);
                    //// Custom Linked list
                    llc.AddFirst(pac);
                }
                //// for collection linked list
                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine("In range {0} - {1} ", llpac.First.Value.GetRange().ToString(), llpac.First.Value.GetRange() + 100);
                    int[] ana = llpac.First.Value.GetAnagrams();
                    foreach (int inte in ana)
                    {
                        if (inte != 0)
                        {
                            Console.Write(inte + " ");
                        }
                        else
                        {
                            break;
                        }
                    }

                    llpac.RemoveFirst();
                    Console.WriteLine();
                }

                //// for custom linked list
                Console.WriteLine("****************************For custom linked list**************************************");
                for (i = 0; i < 10; i++)
                {
                    pac = (PrimeAnagramClass)llc.GetFirst().GetData();
                    Console.WriteLine("In range {0} - {1} ", pac.GetRange(), pac.GetRange() + 100);
                    int[] ana = pac.GetAnagrams();
                    foreach (int inte in ana)
                    {
                        if (inte != 0)
                        {
                            Console.Write(inte + " ");
                        }
                        else
                        {
                            break;
                        }
                    }

                    llc.DeleteFirst();
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process is stopped because " + e);
            }
        }
    }
}