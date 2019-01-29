using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AlgorithmPrograms
{
    class BubbleSortFileInt
    {
        public void BubbleSortFileIntDemo()
        {
            Console.WriteLine("Enter the numbers of elements for int array");
            int i,count = Utility.IsInteger(Console.ReadLine());
            int[] array = new int[count];
            Console.WriteLine("Enter the integer elements for int array");
            for (i = 0; i < count; i++)
            {
                array[i] = Utility.IsInteger(Console.ReadLine());
            }
            String s = "";
            for (i = 0; i < count; i++) s = s + (array[i].ToString()+ " ");
            StreamWriter sw = new StreamWriter("integers.txt");
            sw.WriteLine(s);
            sw.Close();
            StreamReader sr = new StreamReader("integers.txt");
            count = 0;
            s = sr.ReadLine();
            sr.Close();
            s.TrimEnd();
            foreach(char c in s)
            {
                if (c == ' ') count++;
            }
            Console.WriteLine("count is "+count);
            int[] newarray = new int[count];
            i = 0;
            int temp=0;
            foreach (char c in s)
            {
                if (c.ToString().Equals(" "))
                {
                    newarray[i] = temp;
                    temp = 0;
                    i++;
                }
                else if (i < count)
                {
                    temp = temp * 10 + Convert.ToInt32(c.ToString());
                }
                 
            }
           
            newarray =Utility.BubbleSortInt(newarray,count);
            Console.WriteLine("After sort array is");
            for (i = 0; i < count; i++)
            {
                Console.Write("{0} ", newarray[i]);
            }
        }
    }
}
