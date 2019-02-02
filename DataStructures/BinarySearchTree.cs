using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BinarySearchTree
    {
        
        public void BinarySearchTreeDemo()
        {
            int num, i, j, k, count=0, left, right;
            Console.WriteLine("Enter the number to find number of trees");
            num = Utility.IsPositiveInteger(Console.ReadLine());
            num++;
            int[] trees = new int[num+1];
            int[] sample;

            trees[0] = trees[1] = 1;

            for(i = 2; i < trees.Length; i++)
            {
                sample = new int[i];
                count = 0;
               
                for (j = 0; j < i; j++)
                {
                    sample[j] = j + 1;
                }

                for (j = 0; j < i; j++)
                {
                    left = right = 0;
                    for (k = 0; k < i; k++)
                    {
                        if (sample[k] < sample[j]) left++;
                        if (sample[k] > sample[j]) right++;
                        
                    }
                  count= count+ trees[left] * trees[right] ;
                }

                trees[i] = count;
            }
            Console.WriteLine("Number of trees that can be created with {0} distinct numbers is {1}",num-1, trees[num-1]);
        }        
    }
}
