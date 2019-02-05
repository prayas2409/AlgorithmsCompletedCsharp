// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySearchTree.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The class to execute the BinarySearch tree
    /// </summary>
    public class BinarySearchTree
    {
        /// <summary>
        /// Method to count the number of trees that can be formed using some number of nodes 
        /// </summary>
        public void BinarySearchTreeDemo()
        {
            try
            {
                int num, i, j, k, count = 0, left, right;
                Console.WriteLine("Enter the number to find number of trees");
                num = Utility.IsPositiveInteger(Console.ReadLine());
                num++;
                //// num + 1 as 0 also has to be stored
                int[] trees = new int[num + 1];
                int[] sample;
                //// index of number of trees
                trees[0] = trees[1] = 1;
                //// starting from 2 till the number provided
                for (i = 2; i < trees.Length; i++)
                {
                    //// if 3 elements it'll store {1,2,3} and first checks for 2 stores value and proceeds further
                    sample = new int[i];
                    count = 0;
                    //// initializing the sample array from one till the entered number
                    for (j = 0; j < i; j++)
                    {
                        sample[j] = j + 1;
                    }
                    //// calculationg number of left and right sub trees for the same
                    for (j = 0; j < i; j++)
                    {
                        left = right = 0;
                        for (k = 0; k < i; k++)
                        {
                            if (sample[k] < sample[j])
                            {
                                left++;
                            }

                            if (sample[k] > sample[j])
                            {
                                right++;
                            }
                        }
                        //// adding the count of number of subtrees of left and right
                        count = count + (trees[left] * trees[right]);
                    }
                    //// storing the number of trees that can be created by the number of the elements
                    trees[i] = count;
                }

                Console.WriteLine("Number of trees that can be created with {0} distinct numbers is {1}", num - 1, trees[num - 1]);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process is stopped because " + e);
            }
        }
    }
}
