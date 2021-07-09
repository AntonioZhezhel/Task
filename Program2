using System;
using System.Collections.Generic;

namespace ConsoleCSharp1
{
     static class Program
     {
          static public void AddValues<T>(this IEnumerable<T> myList)
          {
              foreach (T v in myList)
                    Console.WriteLine(v);
          }
          static void Main()
          {
              List<string> list = new List<string>{"5","5","5"};
                list.AddValues();
                int[] list2 = new int[]{6,6,6};
                list2.AddValues();
          }
     }
}
