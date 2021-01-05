using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_001
{
    class Program
    {
        static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine(new string(' ',15) + "SecondaryThread");
            }
        }
        static void Main(string[] args)
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start();

            while (true)
            {         
                Console.WriteLine("PrimaryThread");
            }
        }
    }
}
