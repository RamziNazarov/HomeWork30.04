using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HomeWork30._04
{
    class Program2
    {
        static List<int> width = new List<int>();
        static object locker = new object();
        protected static string[] symbols = { "A", "X", "Z", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "S", "D", "F", "G", "H", "J", "K", "L", "C", "V", "B", "N", "M", "!", "#", "@", "$", "%", "^", "&", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "~" };
        public static void WriteWithSomeColor(int second, int third, string color)
        {
            Console.ForegroundColor = (color == "white") ? ConsoleColor.White : (color == "green") ? ConsoleColor.Green : ConsoleColor.DarkGreen;
            Console.SetCursorPosition(second, third);
            Console.Write(symbols[new Random().Next(0, symbols.Length)]);
        }
        static Task[] tasks = new Task[50];
        public static void ShowMatrix(int lengthes, int x, int b, int q)
        {
                x += q;
                for (int i = lengthes; i > -1; i--)
                {
                        WriteWithSomeColor(b, x, (i < lengthes && i != lengthes - 2 && i != lengthes - 1) ? "darkgreen" : (i == lengthes - 2) ? "green" : "white");

                    x--;
                }
                int p = Console.CursorTop;
                while(p != 0)
                {
                    Console.SetCursorPosition(b, p);
                        Console.Write(" ");
                        p--;
                }
        }
        static void AddNumberToList()
        {
            for (int i = 0; i < 100; i++)
            {
                if(i%2==0)
                    width.Add(i);
            }
        }
        static void AddNumberToArray(ref int[] array, int from, int untill)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(from, untill);
            }
        }
        static void Main1(string[] args)
        {
            AddNumberToList();
            int[] lengthesOfString = new int[50];
            AddNumberToArray(ref lengthesOfString, 4, 11);
            int[] stringPosFromTop = new int[50];
            AddNumberToArray(ref stringPosFromTop, 11, 16);
            int x = 0;
            while (x != 15)
            {
                for (int i = 0; i < 50; i++)
                {
                    tasks[i] = new Task(() => ShowMatrix(lengthesOfString[i], stringPosFromTop[i], width[i], x));
                    tasks[i].Start();
                    tasks[i].Wait();
                    Thread.Sleep(10);
                }
                Thread.Sleep(100);
                x++;
                if (x == 15)
                {
                    Console.Clear();
                    x = 0;
                }
            }
            Console.Read();
        }
    }
}
