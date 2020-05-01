using System;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork30._04
{
    class Program
    {
        protected static string[] bolsym = { "0", "1" };
        protected static string[] symbols = { "A", "X", "Z", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "S", "D", "F", "G", "H", "J", "K", "L", "C", "V", "B", "N", "M", "<", ">", ":", "?", "!", "#", "@", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "~", "{", "}", ",", ".", ";", "'" };
        protected static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
        public static void WriteWhite(int second, int third, string color)
        {
            Console.ForegroundColor = (color == "white") ? ConsoleColor.White : (color == "green") ? ConsoleColor.Green : ConsoleColor.DarkGreen;
            WriteAt(bolsym[new Random().Next(0, bolsym.Length)], second, third);
        }
        public static void ShowMatrix()
        {
            int a = new Random().Next(0, 24);
            int g = a;
            int doWhile = new Random().Next(5, 15);
            int b = new Random().Next(0, 100);
            for (int i = 0; i < doWhile; i++)
            {
                if (i < doWhile && i != doWhile - 2 && i != doWhile - 1)
                {
                    WriteWhite(b, g, "1");
                }
                else if (i == doWhile - 2)
                {
                    WriteWhite(b, g, "green");
                }
                else
                {
                    WriteWhite(b, g, "white");
                }
                g++;
            }
            // Thread.Sleep(2000);

            // for (int i = 0; i < doWhile; i++)
            // {
            //     if (i < doWhile && i != doWhile - 2 && i != doWhile - 1)
            //     {
            //         Console.ForegroundColor = ConsoleColor.DarkGreen;
            //         WriteAt(symbols[new Random().Next(0, symbols.Length-1)], b, a);
            //     }
            //     else if (i == doWhile - 2)
            //     {
            //         Console.ForegroundColor = ConsoleColor.Green;
            //         WriteAt(symbols[new Random().Next(0, 15)], b, a);
            //     }
            //     else
            //     {
            //         Console.ForegroundColor = ConsoleColor.White;
            //         WriteAt(symbols[new Random().Next(0, 15)], b, a);
            //     }
            //     a++;
            // }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                ShowMatrix();
                Thread.Sleep(1000);
            }
            // // Clear the screen, then save the top and left coordinates.
            // Console.Clear();
            // origRow = Console.CursorTop;
            // origCol = Console.CursorLeft;


            // // Draw the left side of a 5x5 rectangle, from top to bottom.
            // WriteAt("+", 0, 0);
            // WriteAt("|", 0, 1);
            // WriteAt("|", 0, 2);
            // WriteAt("|", 0, 3);
            // WriteAt("+", 0, 4);

            // // Draw the bottom side, from left to right.
            // WriteAt("-", 1, 4); // shortcut: WriteAt("---", 1, 4)
            // WriteAt("-", 2, 4); // ...
            // WriteAt("-", 3, 4); // ...
            // WriteAt("+", 4, 4);

            // // Draw the right side, from bottom to top.
            // WriteAt("|", 4, 3);
            // WriteAt("|", 4, 2);
            // WriteAt("|", 4, 1);
            // WriteAt("+", 4, 0);

            // // Draw the top side, from right to left.
            // WriteAt("-", 3, 0); // shortcut: WriteAt("---", 1, 0)
            // WriteAt("-", 2, 0); // ...
            // WriteAt("-", 1, 0); // ...
            //                     //
            // WriteAt("All done!", 100, 6);
            // Console.WriteLine();
            // Console.ReadKey();
            // Console.Write("Тестовая запись\nТестовая запись2\nТестовая запись3");
            // int posTop = Console.CursorTop;
            // int posLeft = Console.CursorLeft;

            // for (int i = 1; i <= 30; i++)
            // {
            //     Console.SetCursorPosition(posTop, posLeft);
            //     Console.Write(i);
            //     WriteAt(i.ToString(),i,i);
            //     Thread.Sleep(200);
            // }
            Console.Read();
        }
    }
}
