// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrderedList.cs" company="Bridgelabz">
//   Copyright © 2015 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using DataStructures;
    using System.Text;
    using System.Linq;

    /// <summary>
    /// class to execute ordered list 
    /// </summary>
    class OrderedList
    {
        /// <summary>
        /// Tp execute the ordered list.
        /// </summary>
        public void OrderedListDemo()
        {
            try
            {
                //// To write in the file
                /*
                 * Console.WriteLine("Enter the line to be endtered in the file");
                   string input = Utility.IsString(Console.ReadLine());
                 * StreamWriter sw = new StreamWriter(@"C:\Users\Admin\source\repos\DataStructures\UnorderedList.txt");
                sw.WriteLine(input);
                sw.Close();
                */
                string path = "C:\\Users\\Admin\\source\\repos\\DataStructures\\OrderedListInt.txt";
                              
                StreamReader sr = new StreamReader(path);
                string read = sr.ReadLine();
                sr.Close();
                int[] filetointarray = Utility.StringToIntArray(read);
                int i = 0;
                
                List<int> intlist = new List<int>();
                foreach (int s in filetointarray)
                {
                    intlist.Add(s);
                }
                                
                Console.WriteLine();
                intlist.Sort();
                Console.WriteLine("Enter the integer to be added ");
                int search = Utility.IsInteger(Console.ReadLine());                
                intlist.Add(search);                               
                intlist.Sort();
                
                string result = string.Empty;
                
                foreach (int s in intlist)
                {
                    result = result + s.ToString();
                    i++;
                    if(i != (intlist.Count))
                    {
                        result = result + " ";
                    }
                }
                
                Utility.WriteToFile(result,path);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process cannot be completed because " + e.Message);
            }
        }
        public void OrderedLinkedListDemo()
        {
            string path = "C:\\Users\\Admin\\source\\repos\\DataStructures\\OrderedListInt.txt";

            StreamReader sr = new StreamReader(path);
            string read = sr.ReadLine();
            sr.Close();
            int[] filetointarray = Utility.StringToIntArray(read);
            List<int> ilist = new List<int>();
            LinkedList<int> intlist = new LinkedList<int>();
            foreach (int s in filetointarray)
            {
                intlist.AddLast(s);
                
            }
            Console.WriteLine("Enter the integer to be added ");
            int search = Utility.IsInteger(Console.ReadLine());
            intlist.AddLast(search);
            foreach (int s in intlist)
            {
                ilist.Add(s);
            }
            ilist.Sort();
            intlist.Clear();
            foreach (int s in ilist)
            {
                intlist.AddLast(s);
            }

            string result = string.Empty;
            int i = 0;
            foreach (int s in intlist)
            {
                result = result + s.ToString();
                i++;
                if (i != (intlist.Count))
                {
                    result = result + " ";
                }
            }

            Utility.WriteToFile(result, path);
            //intlist.
        }
    }
}