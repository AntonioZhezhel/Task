using System;

namespace Lessons5_6_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

            Add(list, 10);
            Add(list, 12);
            Add(list, 13);
            Add(list, 14);
            Print(list);
            Console.WriteLine("---------------------");
            DeleteByKey(list, 12);
            Print(list);
            Console.WriteLine("---------------------");
            Search(list, 55);
            Search(list, 13);
        }

        public static void Add(List list, int newData)
        {
            Node newNode = new Node(newData);
            newNode.next = list.head;
            list.head = newNode;
        }

        public static void DeleteByKey(List list, int key)
        {
            Node temp = list.head;
            Node prev = null;
            if (temp != null && temp.data == key)
            {
                list.head = temp.next;
            }

            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
            {
                return;
            }

            prev.next = temp.next;
        }

        public static void Search(List list, int value)
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

        public static void Print(List list)
        {
            Node node = list.head;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
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

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
