using System;

namespace MPL
{
    class Program
    {

        public static void Loading(int timeinSecond){
            char[] chars = new char[] { '.', '-', '+', '^', '°', '*' };
            for (int i = 0; i<timeinSecond*10; i++)
            {
                if (i != 0)
                {
                    // Delete the previous char by setting it to a space
                    Console.SetCursorPosition(6 - (i-1) % 6 - 1, Console.CursorTop);
                    Console.Write(" ");
                }

                // Write the new char
                Console.SetCursorPosition(6 - i % 6 - 1, Console.CursorTop);
                Console.Write(chars[i % 6]);

                System.Threading.Thread.Sleep(100);
            }
            Console.Write(" ");
        }

        public static void Main(string[] args)
        {
            Program.Loading(5);
        }
    }
}
