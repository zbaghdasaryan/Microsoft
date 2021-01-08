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
        //Method for secondary Thread
        static void Function()
        {
            Console.WriteLine("Secondary Thread ID: {0}", Thread.CurrentThread.GetHashCode());
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(30);
                Console.Write('.');
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Secondary Thread");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Primary Thread ID: {0}", Thread.CurrentThread.GetHashCode());

            Thread thread = new Thread(new ThreadStart(Function));
            thread.Start();
            //Primary Thread wait Secondary Thread
            thread.Join();

            Console.WriteLine("Secondary Thread ID: {0}", Thread.CurrentThread.GetHashCode());
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(30);
                Console.Write('-');
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Primary Thread");

            Console.ReadKey();
        }       
    }
}
