using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Blue;


            for (i = 0; i < 21; i++) {
                Console.SetCursorPosition(i, 0);
                snail();

                Console.SetCursorPosition(i, 0);
                Console.Write("  ");
                Thread.Sleep(250);
            }
            Console.Write(" _____");
            Console.Read();
        }
        static void snail()
        {
            Console.Write("   __@_ö");
        }
    }
}
