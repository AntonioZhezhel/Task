using System;

namespace Lessons5_6_Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Operations operations = new Operations();
            Stack stack = new Stack();
            
            operations.Push(stack,10);
            operations.Push(stack,30);
            operations.Push(stack,40);
            operations.Push(stack,50);
            operations.Print(stack);
            operations.Peek(stack);
            operations.Pop(stack);
            operations.Peek(stack);
            operations.Print(stack);
        }

        public class Operations
        {
            public void Push(Stack stack,int value)
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

            public void Pop(Stack stack)
            {
                if (Stack.top == null)
                {
                    Console.WriteLine("error");
                }

                Console.WriteLine("Item Pop {0}", Stack.top.data);
                Stack.top = Stack.top.next;
            }

            public void Peek(Stack stack)
            {
                if (Stack.top == null)
                {
                    Console.WriteLine("error");
                }

                Console.WriteLine("{0}Top Stack", Stack.top.data);
            }

            public void Print(Stack stack)
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
    }

    public class Stack
    {
        public static Node top;

        public Stack()
        {
            top = null;
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

}
