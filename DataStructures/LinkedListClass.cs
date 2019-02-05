using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public class LinkedListClass
    {        
        public Node head = null;
        public int count;

        public LinkedListClass()
        {
            this.head = null;
            count = 0;
        }

        public void Add(object o)
        {
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
                    current = current.next;
                }
                temp.SetPrev(current);
                current.next = temp;
                this.count++;
            }
        }

        public void AddFirst(object o)
        {
            if (this.IsEmpty())
            {
                this.head = new Node(o, null, null);
            }
            else
            {
                Node temp = new Node(o, null, null);
                temp.SetNext(this.head);
                this.head.SetPrev(temp);
                this.head = temp;
            }            
        }

        public void DeleteObject(object o)
        {
            if (this.IsEmpty())
            {
                //// if linked list is empty
                Console.WriteLine("Link list is empty");
                return;
            }
            else if(this.head.GetData() == o)
            {
                //// if the node is first one
                this.DeleteFirst();
                
            }
            else
            {
                Node current = this.head;

                while ( current != null)
                {
                    if(current.GetData().Equals(o))
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

        public void DeleteFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked list already empty");
                return;
            }
            else if(this.head.GetNext() == null)
            {
                this.head = null;
            }
            else
            {
                Node current = this.head;
                current = current.next;
                current.SetPrev(null);
                this.head = current;
            }            
        }

        public void DeleteLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked list already empty");
                return;
            }
            else if (this.head.GetNext() == null)
            {
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


        public bool IsEmpty()
        {
            return (this.head == null);
        }

        public void Print()
        {          
            if (this.IsEmpty())
            {
                Console.WriteLine("Empty Linked List");
            }
            else
            {
                Node current = this.head;
                while (current!=null)
                {
                    Console.Write(current.GetData() + " ");
                    current = current.next;
                }
                Console.WriteLine();
            }           
        }

    }
}

