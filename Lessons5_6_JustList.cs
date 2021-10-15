using System;

namespace Lessons5_6_JustList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(4);
            list.Add(10);
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Print(list);
            Console.WriteLine("---------------------");
            list.Delete(1);
            list.Print(list);
            Console.WriteLine("---------------------");
        }

        public class List<T>
        {
            private T[] data;
            private int size = 0;
            private int capacity;

            public List(int initialCapacity = 8)
            {
                if (initialCapacity < 1) initialCapacity = 1;
                capacity = initialCapacity;
                data = new T[initialCapacity];
            }

            private void Resize()
            {
                T[] resized = new T[capacity * 2];
                for (int i = 0; i < capacity; i++)
                {
                    resized[i] = data[i];
                }

                data = resized;
                capacity = capacity * 2;
            }

            public void Add(T newElement)
            {
                if (size == capacity)
                {
                    Resize();
                }

                data[size] = newElement;
                size++;
            }

            public void Delete(int index)
            {
                Console.WriteLine("deleted number"+ data[index]);
                for (int i = index; i < size - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                
                data[size - 1] = default;
                size--;
            }

            public void Print(List<T> list)
            {
                T[] data = list.data;
                Console.WriteLine(string.Join("\n", data));
            }
        }
    }
}
