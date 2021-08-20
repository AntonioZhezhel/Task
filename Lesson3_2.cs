using System;

namespace Lesson3Delegat
{
    public delegate void MyDelegate(String name);

    public class Tasck2
    {
        private static void Popup(String name)
        {
            name = "popup1";
            Console.WriteLine(name);
            Console.Write("Press 'Enter' to exit popup\n");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }

        private static void Popup2(String name)
        {
            name = "popup2";
            Console.WriteLine(name);
            Console.Write("Press 'Enter' to exit popup\n");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
        }

        public static void StartPopup()
        {
            MyDelegate[] myDelegates =
            {
                Popup, Popup2
            };

            for (int i = 0; i < myDelegates.Length; i++)
            {
                myDelegates[i](Convert.ToString(i));
            }
        }
    }
}
