using System;

namespace Lessons5_6_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();
            List list = new List();

            operations.Add(list, 10);
            operations.Add(list, 12);
            operations.Add(list, 13);
            operations.Add(list, 14);
            operations.Print(list);
            Console.WriteLine("---------------------");
            operations.DeleteByKey(list, 12);
            operations.Print(list);
            Console.WriteLine("---------------------");
            operations.Search(list, 55);
            operations.Search(list, 13);
        }

        public class Operations
        {

            public void Add(List list, int newData)
            {
                Node newNode = new Node(newData);
                newNode.next = list.head;
                newNode.prev = null;
                if (list.head != null)
                {
                    list.head.prev = newNode;
                }

                list.head = newNode;
            }

            public void DeleteByKey(List list, int key)
            {
                Node temp = list.head;
                if (temp != null && temp.data == key)
                {
                    list.head = temp.next;
                    list.head.prev = null;
                    return;
                }

                while (temp != null && temp.data != key)
                {
                    temp = temp.next;
                }

                if (temp == null)
                {
                    return;
                }

                if (temp.next != null)
                {
                    temp.next.prev = temp.prev;
                }

                if (temp.prev != null)
                {
                    temp.prev.next = temp.next;
                }
            }

            public void Search(List list, int value)
            {
                Node temp = list.head;
                while (temp != null)
                {
                    if (temp.data == value)
                    {
                        Console.WriteLine("element{0}", value);
                        return;
                    }

                    temp = temp.next;
                }

                Console.WriteLine("error");
            }

            public void Print(List list)
            {
                Node node = list.head;
                while (node != null)
                {
                    Console.WriteLine(node.data);
                    node = node.next;
                }
            }
        }
    }

    public class List
    {
        public Node head;
    }

    public class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int d)
        {
            data = d;
            next = null;
            prev = null;
        }
    }
}
