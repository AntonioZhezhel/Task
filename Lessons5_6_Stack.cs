using System;

namespace Lessons5_6_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Push(10);
            Push(30);
            Push(40);
            Push(50);
            Print();
            Peek();
            Pop();
            Peek();
            Print();
        }

        public static void Push(int value)
        {
            Node newNode = new Node(value);

            if (Stack.top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = Stack.top;
            }

            Stack.top = newNode;
            Console.WriteLine("{0}pushed", value);
        }

        public static void Pop()
        {
            if (Stack.top == null)
            {
                Console.WriteLine("error");
            }

            Console.WriteLine("Item Pop {0}", Stack.top.data);
            Stack.top = Stack.top.next;
        }

        public static void Peek()
        {
            if (Stack.top == null)
            {
                Console.WriteLine("error");
            }

            Console.WriteLine("{0}Top Stack", Stack.top.data);
        }

        public static void Print()
        {
            if (Stack.top == null)
            {
                Console.WriteLine("error");
            }

            Node temp = Stack.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

            Console.WriteLine("-----------");
        }
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

    public class Stack
    {
        public static Node top;

        public Stack()
        {
            top = null;
        }
    }
}
