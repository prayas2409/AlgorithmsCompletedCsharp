using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class InsertionSortLine
    {
        public void InsertionSortLineDemo()
        {
            String string1, temp="";
            int i = 0,count=0;
            Console.WriteLine("Enter the line for sorting its words");
            string1 = Console.ReadLine();
            foreach (char c in string1) if(c==' ') count++;
            Console.WriteLine("count is {0}",count);
            String[] stringArray = new String[count+1];
            
            foreach (char c in string1)
            {
               if (c==' '){
                    stringArray[i] = temp;
                    temp = "";
                    i++;
                    Console.WriteLine();
               }
                temp = temp + c;
            }
           
            Console.WriteLine("temp is "+ temp);
            stringArray[i] = temp;
            Console.WriteLine("Before sorting ");
            for (i = 0; i < stringArray.Length; i++) Console.WriteLine(stringArray[i]);
            stringArray =Utility.InsertionSortString(stringArray,stringArray.Length);
            Console.WriteLine("After sorting array");
            for (i = 0; i < stringArray.Length; i++) Console.WriteLine(stringArray[i]);
        }
    }
}
