using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataStructAnAlgorithms.Practicum20
{

    public class CustomList
    {
        private class Node
        {
            public int Inf { get; set; }

            [JsonIgnore]
            public Node Next { get; set; }

            public Node(int nodeInfo)
            {
                Inf = nodeInfo;
                Next = null;
            }
        }

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

        public override string ToString()
        {
            string result = "";
            Node r = head;
            while (r is not null)
            {
                result += $"{r.Inf} ";
                r = r.Next;
            }
            return result;
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

                Show();

                r = r.Next;
            }

            if (firstRepeating.Next is not null)
            {
                firstRepeating.Next = r;
                firstRepeating.Inf = x;
            }
        }

        public string Serialize()
        {
            List<int> values = new List<int>();
            Node r = head;
            while (r != null)
            {
                values.Add(r.Inf);
                r = r.Next;
            }
            return JsonSerializer.Serialize(values);
        }

        public static CustomList Deserialize(string json)
        {
            List<int> values = JsonSerializer.Deserialize<List<int>>(json);
            CustomList list = new CustomList();
            foreach (int val in values)
            {
                list.AddToEnd(val);
            }
            return list;
        }
    }
}