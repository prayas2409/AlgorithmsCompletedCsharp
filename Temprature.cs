using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Temprature
    {
        public void TempratureDemo()
        {
           
            Console.WriteLine("Press 1 to convert to Celcius and 2 to convert to Farenheit");
            int type = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("Enter the temprature");
            int temp = Utility.IsInteger(Console.ReadLine());
            if (type == 1)
            {
                float f = temp * (9 / 5) + 32;
                Console.WriteLine("The temprature in Celcius is {0}",f);
            }
            else if (type == 2)
            {
                float f = (float)(((temp) - 32.0) * (5.0 / 9));
                Console.WriteLine("The temprature in Farenheit is {0}", f);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
           
        } 

    }
}