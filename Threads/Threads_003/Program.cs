using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_003
{
    class Program
    {
        static void WriteSecond()
        {
            // Thread.CurrentThread - returns a reference to the current thread instance.
            Thread thread = Thread.CurrentThread;

            // Assign name.
            thread.Name = "Secondary";

            // Display information about the current thread.
            Console.WriteLine("ID потока {0}: {1}", thread.Name, thread.GetHashCode());

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(new string(' ', 15) + thread.Name + " " + counter);
                Thread.Sleep(1000);
            }
        }

        static void Main()
        {
            Thread primaryThread = Thread.CurrentThread;

            primaryThread.Name = "Primary";

            Console.WriteLine("ID потока {0}: {1}", primaryThread.Name, primaryThread.GetHashCode());


            // Secondary thread work.
            Thread secondaryThread = new Thread(WriteSecond);
            secondaryThread.Start();

            // Primary thread work.
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(primaryThread.Name + " " + counter);
                Thread.Sleep(1500);
            }
            Console.ReadKey();
        }
    }
}
