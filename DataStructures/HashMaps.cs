using System;
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
            int index1 = 0, index2, k, counter;
            Console.WriteLine("The numbers retrived are");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Dictionary<int, int[]> dict = new Dictionary<int, int[]>();

            int[,] map = new int[11, numbers.Length];

            //// storing -1 for all the elements in map
            for (index1 = 0; index1 < 11; index1++)
            {
                map[index1, 0] = index1;
                for (index2 = 1; index2 < numbers.Length; index2++)
                {
                    map[index1, index2] = -1;
                    
                }
            }
            //// printing after storing -1
            Console.WriteLine("Values in map after storing -1 are");
            for (counter = 0; counter <11; counter++)
            {
                for (index2 = 0; index2 < numbers.Length; index2++)
                {
                    Console.Write(map[counter, index2]);
                }
                Console.WriteLine();
            }


            int[] array = new int[numbers.Length];

            //// calculates the count of numbers
            for (counter = 0; counter < numbers.Length; counter++)
            {
                array[numbers[counter] % 11]++; 
            }
            ////Prints the count of numbers
            Console.WriteLine("Printing count of number of elements in each index ");
            for (counter = 0; counter < numbers.Length; counter++)
            {
                Console.Write(array[counter] + " ");
            }

            //// assigning values in map
            for (counter = 0; counter < numbers.Length; counter++)
            {
                index1 = numbers[counter] % 11;
                for (index2 = 0; index2<array[counter]; index2++)
                {
                    if (map[index1, index2] == -1)
                    {
                        map[index1, index2] = numbers[counter];
                        break;
                    }
                }
            }
            //// printing values map
            Console.WriteLine("Values in map are");
            for (counter = 0; counter < 11; counter++)
            {               
                for (index2 = 0; map[counter, index2] != -1; index2++)
                {
                    Console.Write(map[index1, index2]);
                }
                Console.WriteLine();
            }

            for (index1 = 0; index1 < 11; index1++)
            {
                counter = 0;
                while (map[index1, counter] != -1)
                {
                    numbers[counter] = map[index1, counter];
                    counter++;
                }
                dict.Add(index1, numbers);
            }
            Console.WriteLine("printing dictionary");
            for (index1 = 0; index1 < 11; index1++)
            {
                foreach(int i in dict[index1])
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
