  using System;

namespace Lesson3Delegat
{
    internal class Program
    {
        public delegate string D(string x, string y, string z);

        public static string a = "first";
        public static string b = "second";
        public static string c = "third";

        public static void Main(string[] args)
        {
            MyClass myClass = new MyClass((x, y, z) =>
            {
                Console.WriteLine(a);
                M(b);
                Console.WriteLine(c);
                return null;
            });
            myClass.Foo();
        }

        public static string M(string x)
        {
            Console.WriteLine(x);
            return x;
        }

        public class MyClass
        {
            private D d;

            public MyClass(D d)
            {
                this.d = d;
            }

            public void Foo()
            {
                MyInvoke();
            }

            private void MyInvoke()
            {
                if (d != null)
                    d.Invoke("", "", "");
            }
        }
    }
}
