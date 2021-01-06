using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _011_Threads_InterLocked
{
    class Program
    {
        static long counter;
        static object block = new object();

        static void Procedure()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Increment(ref counter);
                //lock (block)
                //{
                //    counter++;
                //}
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Expected counter value = 7.000.000");
            Thread[] threads = new Thread[7];
            for (int i = 0; i < 7; i++)
            {
                (threads[i] = new Thread(Procedure)).Start();
            }
            for (int i = 0; i < 7; i++)
            {
                threads[i].Join();
            }
            Console.WriteLine("Real value of counter = {0}", counter);

            Console.ReadKey();
        }
    }
}
