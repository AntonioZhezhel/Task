using System;

namespace ConsoleApplication1
{
    class Program
    {
         static void Main()
        {
            string s = "55";
            string b = "fgfg";
            s.SafeParse();
            b.SafeParse();
        }
    }

    public static class StringExtetions
    {
        public static int SafeParse(this string s)
        {
            bool result = int.TryParse(s, out _);
            if (result)
                Console.WriteLine(s);
            return 0;
        }

        public static int TryPaadrse()
        {
            
        }
    }
    
}
