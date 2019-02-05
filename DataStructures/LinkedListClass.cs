// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedListClass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Linked list 
    /// </summary>
    public class LinkedListClass
    {
        /// <summary>
        /// The head node
        /// </summary>
        private Node head = null;

        /// <summary>
        /// The count of number of nodes
        /// </summary>
        private int count;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListClass"/> class.
        /// </summary>
        public LinkedListClass()
        {
            this.head = null;
            this.count = 0;
        }

        /// <summary>
        /// Gets the first.
        /// </summary>
        /// <returns>Returns the first object in the Linked list</returns>
        public Node GetFirst()
        {
            return this.head;
        }

        /// <summary>
        /// Gets the last.
        /// </summary>
        /// <returns>Object of class node</returns>
        public Node GetLast()
        {
            Node current = this.head;
            while (current.GetNext() != null)
            {
                current = current.GetNext();
            } 

            return current;
        }

        /// <summary>
        /// Adds a new node with specified object to the linked list.
        /// </summary>
        /// <param name="o">The o is the object of variable type</param>
        public void Add(object o)
        {
            //// if no element in the linked list
            if (this.IsEmpty())
            {
                this.head = new Node(o, null, null);
                this.count++;
            }
            else
            {
                Node current = this.head;
                Node temp = new Node(o, null, null);
                while (current.GetNext() != null)
                {
                    current = current.GetNext();
                }

                temp.SetPrev(current);
                current.SetNext(temp);
                this.count++;
            }
        }

        /// <summary>
        /// Adds the element to first position in the linked list.
        /// </summary>
        /// <param name="o">The o.</param>
        public void AddFirst(object o)
        {
            if (this.IsEmpty())
            {
                //// if empty just iniitialize the fist node
                this.head = new Node(o, null, null);
            }
            else
            {
                //// add a new node infront
                Node temp = new Node(o, null, null);
                temp.SetNext(this.head);
                this.head.SetPrev(temp);
                this.head = temp;
            }            
        }

        /// <summary>
        /// Pushes the specified object to the Linked List.
        /// </summary>
        /// <param name="o">The object to be added in the linked list</param>
        public void Push(object o)
        {
            this.AddFirst(o);
        }

        /// <summary>
        /// remove the first element in the linked list.
        /// </summary>
        /// <returns> if the element was popped successfully</returns>
        public bool Pop()
        {
            return this.DeleteFirst();
        }

        /// <summary>
        /// Deletes the specified object.
        /// </summary>
        /// <param name="o">The object to be deleted</param>
        public void DeleteObject(object o)
        {
            if (this.IsEmpty())
            {
                //// if linked list is empty
                Console.WriteLine("Link list is empty");
                return;
            }
            else if (this.head.GetData() == o)
            {
                //// if the node is first one
                this.DeleteFirst();
            }
            else
            {
                Node current = this.head;
                //// traversing the linked list
                while (current != null)
                {
                    if (current.GetData().Equals(o))
                    {
                        break;
                    }

                    current = current.GetNext();
                }

                if (current == null)
                {
                    //// object not found
                    Console.WriteLine("Object not found");
                    return;
                }
                else if (current.GetNext() == null)
                {
                    //// deleting Last node
                    this.DeleteLast();
                }
                else
                {
                    Node temp = current.GetPrev();
                    temp.SetNext(current.GetNext());
                    current = current.GetNext();
                    current.SetPrev(temp);
                }
            }
        }

        /// <summary>
        /// Deletes the first element in the Linked list.
        /// </summary>
        /// <returns>if deleted first node successfully</returns>
        public bool DeleteFirst()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("Linked list already empty");
                return false;
            }
            else if (this.head.GetNext() == null)
            {
                //// If only 1 element in the linked list
                this.head = null;
                return true;
            }
            else
            {
                Node current = this.head;
                current = current.GetNext();
                current.SetPrev(null);
                this.head = current;
                return true;
            }            
        }

        /// <summary>
        /// Deletes the last node in the linked list.
        /// </summary>
        public void DeleteLast()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("Linked list already empty");
                return;
            }
            else if (this.head.GetNext() == null)
            {
                //// only 1 element in the array
                this.head = null;
            }
            else
            {
                Node current = this.head;
                while (current.GetNext() != null)
                {
                    current = current.GetNext();
                }

                Node temp = current.GetPrev();
                temp.SetNext(null);
            }
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            return this.head == null;
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {          
            if (this.IsEmpty())
            {
                Console.WriteLine("Empty Linked List");
            }
            else
            {
                Node current = this.head;
                while (current != null)
                {
                    Console.Write(current.GetData() + " ");
                    current = current.GetNext();
                }

                Console.WriteLine();
            }           
        }

        /// <summary>
        /// Adds the node with object to start of linked list.
        /// </summary>
        /// <param name="o">The object to be  added to the linked list</param>
        public void Enque(object o)
        {
            this.AddFirst(o);
        }

        /// <summary>
        /// Takes the last element out
        /// </summary>
        public void Deque()
        {
            this.DeleteLast();
        }
    }
}