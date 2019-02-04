using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PrimeAnagramClass
    {
        int range;
        int[] anagrams = new int[20];

        public int GetRange()
        {
            return this.range;
        }

        public int[] GetAnagrams()
        {
            return this.anagrams;
        }

        public void SetRange(int num)
        {
            this.range = num;
        }

        public void SetAnagrams(int num)
        {
            int i = 0;
            while (anagrams[i] != 0)
            {
                i++;
            }
            anagrams[i] = num;
        }
    }
}
