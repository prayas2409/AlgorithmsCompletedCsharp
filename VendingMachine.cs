using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class VendingMachine
    {
        public void VendingMachineDemo() {
            int[] array = { 1000, 500, 100, 50 , 10, 5, 2, 1 };
            int i=0,num,count=0;
            Console.WriteLine(" Enter the amount to be withdrawn");
            num = Utility.IsInteger(Console.ReadLine());
            
                while( num>0 )
                {
                if (num / array[i] > 0)
                {
                    Console.WriteLine("{0} {1} rupee notes", num / array[i], array[i]);
                    count = count + num / array[i];
                    num = num - (array[i] * (num / array[i]));
                }
                else i++;
                }
            
            Console.WriteLine("THe minimum notes required is {0}",count);
        }
    }
}
