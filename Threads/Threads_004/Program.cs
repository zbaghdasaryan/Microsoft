using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_004
{
    class Program
    {
        static void WriteSecond(object argument)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(argument);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            ParameterizedThreadStart writeSecond = new ParameterizedThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start("Method with argument");
           
            Console.ReadKey();
        }
    }
}
