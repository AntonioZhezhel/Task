using System;

namespace Lessons5_6_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();
            Queue queue = new Queue();

            operations.Enqueue(queue, 10);
            operations.Enqueue(queue, 20);
            operations.Enqueue(queue, 30);
            operations.Enqueue(queue, 40);
            operations.Enqueue(queue, 50);
            operations.Enqueue(queue, 60);
            operations.Print(queue);
            operations.Dequeue(queue);
            operations.Enqueue(queue, 70);
            operations.Print(queue);
            operations.Dequeue(queue);
            operations.Print(queue);
        }

        public class Operations
        {
            public void Enqueue(Queue queue, int item)
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

            public void Dequeue(Queue queue)
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

            public void Print(Queue queue)
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
