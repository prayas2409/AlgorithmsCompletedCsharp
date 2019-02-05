using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node
    {
        public object data;
        public Node next;
        public Node prev;

        public Node(object o, Node n, Node p)
        {
            this.data = o;
            this.next = n;
            this.prev = p; 
        }

        public object GetData()
        {
            return this.data;
        }

        public void SetData(object o)
        {
            this.data = o;
        }

        public void SetNext(Node n)
        {
            this.next = n ;
        }

        public Node GetNext()
        {
            return this.next;
        }

        public void SetPrev(Node n)
        {
            this.prev = n;
        }

        public Node GetPrev()
        {
            return this.prev;
        }
    }
}
