using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adt
{
    public class MyLinkedList
    {
        //peger på den første instans af node
        //antal elementer i listen
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        //klassen Node intager et object som constructor
        private Node Head;
        private class Node
        {
            public Node(Object obj)
            {
                Data = obj;
            }

            private Object data;
            public Object Data
            {
                get { return data; }
                set { data = value; }
            }

            private Node next;
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
        }

        public void Insert(Object obj)
        {
            Insert(obj, 0);
            
        }
        public void Insert(Object obj, int index)
        {
            Node n = new Node(obj);
            if (index == 0)
            {
                n.Next = Head;
                Head = n;
            }
            else
            {
                Node temp = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.Next;
                }
                n.Next = temp.Next;
                temp.Next = n;
                Head = temp;

                //Node temp = new Node(obj);
                //temp = Head;
                //Head.Next = temp;
            }
            

            

            n.Next = temp.Next;
            temp.Next = n;
        }
        public void Delete()
        {

        }
        public void Delete(int index)
        {

        }
        public Object ItemAt(int index)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
