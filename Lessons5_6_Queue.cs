using System;

namespace Lessons5_6_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Enqueue(10);
            Enqueue(20);
            Enqueue(30);
            Enqueue(40);
            Enqueue(50);
            Enqueue(60);
            Print();
            Dequeue();
            Enqueue(70);
            Print();
            Dequeue();
            Print();
        }

        public static void Enqueue(int item)
        {
            Node newNode = new Node(item);
            if (Queue.rear == null)
            {
                Queue.front = Queue.rear = newNode;
            }
            else
            {
                Queue.rear.next = newNode;
                Queue.rear = newNode;
            }

            Console.WriteLine("{0} in Queue ", item);
        }

        public static void Dequeue()
        {
            if (Queue.front == null)
            {
                Console.WriteLine("error");
            }

            Node temp = Queue.front;
            Queue.front = Queue.front.next;
            if (Queue.front == null)
            {
                Queue.rear = null;
            }

            Console.WriteLine("deleted is{0}", temp.data);
        }

        public static void Print()
        {
            if (Queue.front == null)
            {
                Console.WriteLine("The Queue is empty");
            }

            Node temp = Queue.front;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

            Console.WriteLine("--------------");
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

    public class Queue
    {
        public static Node front;
        public static Node rear;

        public Queue()
        {
            front = rear = null;
        }
    }
}
