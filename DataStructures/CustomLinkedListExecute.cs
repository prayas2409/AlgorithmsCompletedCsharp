// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomLinkedListExecute.cs" company="Bridgelabz">
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
    /// The class is to check the created Linked List
    /// </summary>
    public class CustomLinkedListExecute
    {
        /// <summary>
        /// Method to execute the Linked list
        /// </summary>
        public void CustomLinkedListExecuteDemo()
        {
            LinkedListClass llc = new LinkedListClass();
            Console.WriteLine("Entering 20");
            llc.Add(20);            
            Console.WriteLine("Entering 30");
            llc.Add(30);         
            Console.WriteLine("Entering 40");
            llc.Add(40);        
            Console.WriteLine("Entering 50");
            llc.Add(50);            
            Console.WriteLine("Entering 60");
            llc.Add(60);         
            Console.WriteLine("Entering 70");
            llc.Add(70);           
            Console.WriteLine("Entering 80");
            llc.Add(80);
            llc.Print();
            Console.WriteLine("deleting first");
            llc.DeleteFirst();
            llc.Print();
            Console.WriteLine("deleting Last");
            llc.DeleteLast();
            llc.Print();
            Console.WriteLine("Adding first 1");
            llc.AddFirst(1);
            llc.Print();
            Console.WriteLine("Adding 15 at last");
            llc.Add(15);
            llc.Print();
            Console.WriteLine("Removing 50 ");
            llc.DeleteObject(50);
            llc.Print();
        }
    }
}
