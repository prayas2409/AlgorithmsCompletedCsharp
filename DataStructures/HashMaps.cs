using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
//using System.Collections.Generic.IDictionary;

namespace DataStructures
{
    class HashMaps
    {
        /// <summary>
        /// Hashes the maps demo.
        /// </summary>
        public void HashMapsDemo()
        {            
            string inputnums, path = "C:\\Users\\Admin\\source\\repos\\DataStructures\\hashmap.txt";

            inputnums = Utility.ReadfromFile(path);

            int[] numbers = Utility.StringToIntArray(inputnums);

            Console.WriteLine("The numbers retrived are");

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Enter the number to be searched");
            int search = Utility.IsInteger(Console.ReadLine());
            string stringfind = search.ToString();

            Hashtable hashMap = new Hashtable();

            foreach (int i in numbers)
            {
                hashMap[i % 11] = hashMap[i % 11] + i.ToString() + " ";
            }

            Console.WriteLine("printing hashmap before search");
            foreach (DictionaryEntry de in hashMap)
            {
                Console.WriteLine(de.Key + ":" + de.Value);
            }


            Console.WriteLine("hashMap.ContainsValue "+ hashMap[search % 11].ToString().Contains(stringfind));
            if (hashMap.ContainsKey((search%11)) && hashMap[search%11].ToString().Contains(stringfind))
            {
                string temp = hashMap[search % 11].ToString();

                temp = temp.Remove(temp.LastIndexOf(stringfind), stringfind.Length);
                if(temp==" " || temp.Length == 0)
                {
                    hashMap.Remove(search % 11);
                }
                else
                {
                    hashMap[search % 11] = temp;
                }
            }
            else
            {
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
                result = result + de.Value.ToString()+" ";
            }
            result.Trim();
            Utility.WriteToFile(result, path);
        }
    }
}
