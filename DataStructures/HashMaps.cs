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

            Hashtable hashMap = new Hashtable();
            foreach (int i in numbers)
            {
                hashMap[i % 11] = hashMap[i % 11] + i.ToString() + " ";
            }

           
            string result = string.Empty;
            path = "C:\\Users\\Admin\\source\\repos\\DataStructures\\hashmapresult.txt";
            ////clear the contents of the file
            Utility.ClearFile(path);

            Console.WriteLine("printing hashmap");
            foreach (DictionaryEntry de in hashMap)
            {
                result = de.Key + " : " + de.Value.ToString();
                Console.WriteLine(result);
                Utility.WriteToFile(result,path);
                result = string.Empty;
            }

        }
    }
}
