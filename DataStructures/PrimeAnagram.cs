using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PrimeAnagram
    {
        public int[,] PrimeAnagramDemo()
        {
            try
            {
                int[,] primenumbers = new int[10, 50];
                int i = 0, j, count, k;
                primenumbers[0, 0] = 0;
                int[,] anagram = new int[10, 20];
                anagram[0, 0] = 0;

                for (i = 1; i < 10; i++)
                {
                    primenumbers[i, 0] = primenumbers[i - 1, 0] + 100;
                    anagram[i, 0] = primenumbers[i - 1, 0] + 100;
                }
                for (i = 0; i < 10; i++)
                {
                    count = 0;
                    for (j = 1; j < 100; j++)
                    {
                        //// WriteLine("For i= {0}, j= {1}, count= {2} ",i,j,count);
                        if (Utility.IsPrime((primenumbers[i, 0] + j)))
                        {
                            count++;
                            primenumbers[i, count] = primenumbers[i, 0] + j;
                        }
                    }
                }
                Console.WriteLine("Printing the prime numbers");
                for (i = 0; i < 10; i++)
                {
                    Console.Write("For {0} - {1}: ", primenumbers[i, 0], (primenumbers[i, 0] + 100));

                    for (j = 1; primenumbers[i, j] != 0; j++)
                    {
                        Console.Write(primenumbers[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                for (i = 0; i < 10; i++)
                {
                    count = 0;
                    //// converting the numbers to string

                    for (j = 1; primenumbers[i, j] != 0; j++)
                    {

                        for (k = j + 1; primenumbers[i, k] != 0; k++)
                        {
                            //// Console.WriteLine("For i: {0} comparing number1: {1} number2: {2} gives {3}",i, primenumbers[i, j], primenumbers[i, k], Utility.Anagram(Convert.ToString(primenumbers[i, j]), Convert.ToString(primenumbers[i, k])));
                            if (Utility.Anagram(Convert.ToString(primenumbers[i, j]), Convert.ToString(primenumbers[i, k])))
                            {
                                count++;
                                anagram[i, count++] = primenumbers[i, j];
                                anagram[i, count] = primenumbers[i, k];
                            }
                        }
                    }
                }
                Console.WriteLine("Printing the prime numbers that are Anagrams");
                for (i = 0; i < 10; i++)
                {
                    Console.Write("For {0} - {1}: ", anagram[i, 0], (anagram[i, 0] + 100));

                    for (j = 1; anagram[i, j] != 0; j++)
                    {
                        Console.Write(anagram[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                return anagram;
            }
            catch (Exception e)
            {
                int[,] anagram = new int[10, 20];
                Console.WriteLine("The process is stopped because " + e);                
                return anagram;
            }
        }
    }
}