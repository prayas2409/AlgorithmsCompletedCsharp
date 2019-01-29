using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class GuessGame
    {
        public void GuessGameDemo(int num)
        {
            int power=Utility.IsPowerOfTwo(num);
            if (power == 0) Console.WriteLine(" number is not a power of 2");
            else
            {
                int i, low = 0, high = num, mid;
                int[] array = new int[num];
                for (i = 0; i < num; i++) array[i] = i;
                Console.WriteLine("Guess a number in your mind in range 0 to {0} press enter once guessed", num - 1);
                //taking guess number as input
                Console.ReadLine();
                while (power > 0)
                {
                    mid = (low + high) / 2;
                    
                    Console.WriteLine("Is the number {0} true or false",array[mid]);
                    if (Utility.IsBoolean(Console.ReadLine()))
                    {
                        Console.WriteLine("Yeah we won");
                        return;
                    }
                    Console.WriteLine("Is the number less than {0} true or false", array[mid]);
                    if (Utility.IsBoolean(Console.ReadLine()))
                    {
                        high = mid;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                    power--;
                }
            }        
        }
    }
}
