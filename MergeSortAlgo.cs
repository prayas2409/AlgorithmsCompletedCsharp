using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class MergeSortAlgo
    {
        public void MergeSortAlgoDemo()
        {
            Console.WriteLine("Enter the string whose words are to be sorted");
            String s,temp="";
            int count = 0,i=0;
            s = Console.ReadLine();
            foreach (char c in s) if(c==' ') count++;
            Console.WriteLine("count is "+count);

            String[] stringarray = new String[count+1];
            foreach (char c in s)
            {
                if ((c == ' '))
                {
                    stringarray[i] = temp;
                    temp = "";
                    i++;
                }
                else temp = temp + c;
            }
            stringarray[i] = temp;
            Console.WriteLine("Before sorting the srting is");
            for (i = 0; i <= count; i++)
            {
                Console.WriteLine(stringarray[i]);
            }
            stringarray = Utility.MergeSortString(stringarray,0,count);
            Console.WriteLine("After sorting the srting is");
            for (i = 0; i <= count; i++)
            {
                Console.WriteLine(stringarray[i]);
            }

        }
    }
}
