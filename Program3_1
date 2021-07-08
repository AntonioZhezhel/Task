sing System;

namespace Task3_1
{
     
        
        class Program3_1
        {
            static void Main()
            {
                 int x = 0;
                 Iterating unused1 = new Iterating { Value = x};
                 Iterating unused = x;
            }
        }
        class Iterating
        {
            public int Value { get; set; }
  
            public static implicit operator Iterating(int x)
            {
                while (x < 11)
                {
                    if (x == 10)
                    {
                        x = 0;
                    }
                    x++ ;
                    Console.WriteLine(x);
                }
            
                return new Iterating { Value = x };
            }
        }
}
