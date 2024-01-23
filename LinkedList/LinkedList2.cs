using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList2
    {
        Node Head;
        Node Tail;

        public LinkedList2()
        {
            Head = null;
            Tail = null;
        }

        public void AddatEnd(int Data)
        {
            Node newNode = new Node(Data);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
        }

        public void AddFirstly(int Data)
        {
            Node newNode = new Node(Data);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        public void AddAtMid(int Data, int location)
        {
            Node newNode = new Node(Data);
            Node tempHead = Head;

            if (Head == null)
            {
                AddatEnd(Data);
            }
            else if (location > 1)
            {
                AddFirstly(Data);
            }
            else
            {
                for (int i = 0; i < location - 1; i++)
                {
                    tempHead = tempHead.Next;
                }
                newNode.Next = tempHead.Next;
                tempHead.Next = newNode;
            }
        }

        public void Print()
        {
            Node tempHead = Head;

            if (tempHead == null)
            {
                Console.WriteLine("There is No Data");
            }
            else
            {
                while (tempHead != null)
                {
                    Console.WriteLine(tempHead.Data);
                    tempHead = tempHead.Next;
                }
            }
        }


        public void Count()
        {
            Node tempHead = Head;
            int count = 0;
            while (tempHead != null)
            {
                tempHead = tempHead.Next;
                count++;
            }
            
            Console.WriteLine("There Are {0} Nodes", count);
        }

        public void Search(int userInput)
        {
            Node tempHead = Head;
            int get = 0;
            while (tempHead != null)
            {
                if (tempHead.Data == userInput)
                {
                    get = tempHead.Data;
                }
                
                tempHead = tempHead.Next;
            }

            if (get == userInput)
            {
                Console.WriteLine("{0} is Exist", userInput);
            }
            else
            {
                Console.WriteLine("{0} not Exist", userInput);
            }
            
        }


        public void Delete(int Data)
        {
            Node prev = Head;
            Node curr = Head.Next;

            if (Head.Data == Data)
            {
                Head = curr;
            }
            else if (Tail.Data == Data)
            {
                while (curr.Data != Data)
                {
                    prev = prev.Next;
                    curr = curr.Next;
                }
                if (curr.Data == Data)
                {
                    Tail = prev;
                }
            }
            else
            {
                while (curr.Data != Data)
                {
                    prev = prev.Next;
                    curr = curr.Next;
                }

                if (curr.Data == Data)
                {
                    prev.Next = curr.Next;
                }
            }

            
        }
    }
}
