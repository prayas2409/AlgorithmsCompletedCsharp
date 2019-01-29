using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BinarySearchFile
    {
        public void BinarySearchFileDemo()
        { 
            //integer elements to count  
            int i, count=0;
            Console.WriteLine("Enter the number of lines you wish to add to file");
            int num = Utility.IsInteger(Console.ReadLine());
            Console.WriteLine("Enter the strings you wish to add to file");
            String[] string1 = new string[num];
            StreamWriter sw = new StreamWriter("test.txt");
            for (i = 0; i < num; i++)
            {
                string1[i]=Utility.IsString(Console.ReadLine());
                sw.Write(string1[i]);
                if (i<num-1) sw.Write(",");
            }
            sw.Close();
            // creating a reader
            StreamReader sr=new StreamReader("test.txt");
            String copy;
            i = 0;
            copy=sr.ReadLine();            
            Console.WriteLine("reading from copies string");
            //counting number of words
            foreach (char c in copy) if (c == ',') count++;                     
            String[] stringarray = new string[count+1];
            String temp = "";
            i = 0;
            foreach (char c in copy)
            {
                if (c != ',') temp = temp + c;
                else
                {
                    stringarray[i] = temp;
                    i++;
                    temp = "";
                }
                stringarray[i] = temp;
            }            
            for (i = 0; i <= count; i++) Console.WriteLine(stringarray[i]);
        }           
    }
}