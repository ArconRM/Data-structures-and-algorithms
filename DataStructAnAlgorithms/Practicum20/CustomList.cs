using System;
using System.Xml.Linq;

namespace DataStructAnAlgorithms.Practicum20
{
    public class Node
    {
        private int inf;
        private Node next;

        public Node(int nodeInfo)
        {
            inf = nodeInfo;
            next = null;
        }

        public Node Next
        {
            get => next;
            set { next = value; }
        }

        public int Inf
        {
            get => inf;
            set { inf = value; }
        }
    }

    public class CustomList
    {
        private Node head;
        private Node tail;

        public CustomList()
        {
            head = null;
            tail = null;
        }

        public void AddToEnd(int nodeInfo)
        {
            Node r = new Node(nodeInfo);
            if (head == null)
            {
                head = r;
                tail = r;
            }
            else
            {
                tail.Next = r;
                tail = r;
            }
        }

        public object TakeFromBegin()
        {
            if (head == null)
            {
                throw new Exception("Список пуст");
            }

            Node r = head;
            head = head.Next;
            if (head == null)
            {
                tail = null;
            }
            return r.Inf;
        }

        public void Show()
        {
            Node r = head;
            while (r is not null)
            {
                Console.Write($"{r.Inf} ");
                r = r.Next;
            }
            Console.WriteLine();
        }

        public void ReplaceRepeatingOccurences(int x)
        {
            Node firstRepeating = head;
            Node r = head.Next;

            while (r is not null)
            {
                if (firstRepeating.Inf == r.Inf)
                {
                    if (r.Next is not null)
                    {
                        firstRepeating.Next = r.Next.Next;
                    }
                }
                else
                {
                    if (firstRepeating.Next != r)
                    {
                        firstRepeating.Next = r;
                        firstRepeating.Inf = x;
                    }
                    firstRepeating = r;
                }

                //Show();

                r = r.Next;
            }

            if (firstRepeating.Next is not null)
            {
                firstRepeating.Next = r;
                firstRepeating.Inf = x;
            }
        }

        public void Delete(object key)
        {
            if (head == null)
            {
                throw new Exception("Список пуст");
            }
            else
            {
                if (head.Inf.CompareTo(key) == 0)
                {
                    head = head.Next;
                }
                else
                {
                    Node r = head;
                    while (r.Next != null)
                    {
                        if (r.Next.Inf.CompareTo(key) == 0)
                        {
                            r.Next = r.Next.Next;
                            break;
                        }
                        else
                        {
                            r = r.Next;
                        }
                    }
                }
            }
        }
    }
}