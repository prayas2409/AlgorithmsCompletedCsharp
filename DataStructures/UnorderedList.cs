// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnorderedList.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// The class executes the program of unsorted list
    /// </summary>
    public class UnorderedList
    {
        /// <summary>
        /// method to execute the unordered take.
        /// </summary>
        public void UnorderedListDemo()
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
                int count = 0;
                string path = "C:\\Users\\Admin\\source\\repos\\DataStructures\\UnorderedList.txt";
                string read = Utility.ReadfromFile(path);
                Console.WriteLine("I read : " + read);
                for (int i1 = 0; i1 < read.Length; i1++)
                {
                    char c = read[i1];
                    if (c.Equals(' '))
                    {
                        count++;
                    }
                }
                //// storing the words separately in array
                string[] filetostring = new string[count + 1];
                filetostring = Utility.StringToStringArray(read);

                List<string> stringlist = new List<string>();
                foreach (string s in filetostring)
                {
                    //// adding words to the list
                    stringlist.Add(s);
                }

                Console.WriteLine("Enter the word to be searched");
                string search = Utility.IsString(Console.ReadLine());
                bool found = false;
                foreach (string find in stringlist)
                {   
                    //// if the word is in the array 
                    if (find.Equals(search))
                    {
                        found = true;
                        break;
                    }
                }

                if (found == true)
                { 
                    //// if the number found
                    stringlist.Remove(search);
                }
                else
                {
                    stringlist.Add(search);
                }                            

                search = Utility.StringListtoString(stringlist);
                Console.WriteLine("Trying to write to the file");
                Utility.WriteToFile(search, path);
                Console.WriteLine("After writing to the file");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process cannot be completed because " + e.Message);
            }
        }
    }
}
