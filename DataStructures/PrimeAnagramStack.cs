using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PrimeAnagramStack
    {
        public void PrimeAnagramStackDemo()
        {
            int[,] primenumbers = new int[10, 50];
            int i = 0, j; 
            primenumbers[0, 0] = 0;
            int[,] anagram = new int[10, 20];
            
            PrimeAnagram pa = new PrimeAnagram();
            anagram = pa.PrimeAnagramDemo();

            PrimeAnagramClass pac;
            LinkedList<PrimeAnagramClass> llpac = new LinkedList<PrimeAnagramClass>();
            for (i = 0; i < 10; i++)
            {
                pac = new PrimeAnagramClass();
                pac.SetRange(anagram[i,0]);
                for (j = 1; anagram[i, j] != 0; j++)
                {
                    pac.SetAnagrams(anagram[i,j]);
                }
                llpac.AddFirst(pac);
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("In range {0} - {1} ",llpac.First.Value.GetRange().ToString(), (llpac.First.Value.GetRange()+100));
                int[] ana = llpac.First.Value.GetAnagrams();
                foreach(int inte in ana)
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
        }
    }
}
