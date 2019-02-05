// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HashMaps.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this class is to execute the hash maps program
    /// </summary>
    public class HashMaps
    {
        /// <summary>
        /// Executes the hash map demo
        /// </summary>
        public void HashMapsDemo()
        {
            try
            {
                //// path of file from where to read
                string inputnums, path = "C:\\Users\\Admin\\source\\repos\\DataStructures\\hashmap.txt";

                inputnums = Utility.ReadfromFile(path);
                //// converting string to array
                int[] numbers = Utility.StringToIntArray(inputnums);

                Console.WriteLine("The numbers retrived are");

                foreach (int i in numbers)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();

                Console.WriteLine("Enter the number to be searched");
                int search = Utility.IsInteger(Console.ReadLine());
                //// converting the number ot be searched as string
                string stringfind = search.ToString();

                //// creating the object of hashmap table
                Hashtable hashMap = new Hashtable();

                //// hashing the numbers and keys into the hashtable
                foreach (int i in numbers)
                {
                    hashMap[i % 11] = hashMap[i % 11] + i.ToString() + " ";
                }

                Console.WriteLine("printing hashmap before search");
                //// using dictionary entry object to iterate the hashtable
                foreach (DictionaryEntry de in hashMap)
                {
                    Console.WriteLine(de.Key + ":" + de.Value);
                }

                //// Console.WriteLine("hashMap.ContainsValue " + hashMap[search % 11].ToString().Contains(stringfind));
                //// If the number is in the hashtable
                if (hashMap.ContainsKey(search % 11) && hashMap[search % 11].ToString().Contains(stringfind))
                {
                    string temp = hashMap[search % 11].ToString();

                    temp = temp.Remove(temp.LastIndexOf(stringfind), stringfind.Length);
                    //// if after deleting the there are no elements with that key delete the row
                    if (temp == " " || temp.Length == 0)
                    {
                        hashMap.Remove(search % 11);
                    }
                    else
                    {
                        //// else add the array with the number removed
                        hashMap[search % 11] = temp;
                    }
                }
                else
                {
                    //// if number not found enter the number in the hashmap
                    hashMap[search % 11] = hashMap[search % 11] + stringfind + " ";
                }

                string result = string.Empty;
                path = "C:\\Users\\Admin\\source\\repos\\DataStructures\\hashmapresult.txt";
                ////clear the contents of the file
                Utility.ClearFile(path);
                result = string.Empty;
                Console.WriteLine("printing hashmap");
                foreach (DictionaryEntry de in hashMap)
                {
                    Console.WriteLine(de.Key + ":" + de.Value);
                }

                foreach (DictionaryEntry de in hashMap)
                {
                    result = result + de.Value.ToString() + " ";
                }

                result.Trim();
                Utility.WriteToFile(result, path);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process is stopped because " + e);
            }
        }
    }
}
