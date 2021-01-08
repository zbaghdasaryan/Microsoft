using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_002
{
    class Program
    {       
        static void WriteSecond()
        {
            int counter = 0;
            while (counter < 10)
            {
                Thread.Sleep(500);
                Console.WriteLine("Thread Id {0}, counter = {1}", Thread.CurrentThread.GetHashCode(), counter);
                counter++;
            }
        }
        static void Main(string[] args)
        {
            //Secondary thread
            Thread thread = new Thread(WriteSecond);
            thread.Start();

            //Primary thread
            //WriteSecond static method but it creating one more time when we use threads (copy), every method use 1mb stack.
            WriteSecond();
        }
    }
}
