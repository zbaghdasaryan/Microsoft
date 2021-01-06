using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_Join
{
    class Program
    {
        static void WriteChar(char chr, int count, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < count; i++)
            {
                Thread.Sleep(30);
                Console.Write(chr);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //Method for third Thread
        static void Method3()
        {
            Console.WriteLine(" 3rd Thread ID: {0}", Thread.CurrentThread.GetHashCode());
            WriteChar('3', 80, ConsoleColor.Yellow);
            Console.WriteLine(" 3rd Thread has finished work");
        }

        //Method for second Thread
        static void Method2()
        {
            Console.WriteLine(" 2rd Thread ID: {0}", Thread.CurrentThread.GetHashCode());
            WriteChar('2', 80, ConsoleColor.Blue);

            //Creating third Thread
            Thread thread = new Thread(Method3);
            thread.Start();
            thread.Join();

            WriteChar('2', 80, ConsoleColor.Blue);
            Console.WriteLine(" 2nd Thread has finished work");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" 1st Thread ID: {0}", Thread.CurrentThread.GetHashCode());
            WriteChar('1', 80, ConsoleColor.Red);

            //Creating second Thread
            Thread thread = new Thread(Method2);
            thread.Start();
            thread.Join();

            WriteChar('1', 80, ConsoleColor.Red);
            Console.WriteLine(" 1st Thread has finished work");

            Console.ReadKey();
        }
    }
}
