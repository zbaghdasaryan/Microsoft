using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_005
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            //ThreadStart
            Thread thread = new Thread(delegate () { Console.WriteLine("1. counter = {0}", counter++); });
            thread.Start();

            Thread.Sleep(5);
            Console.WriteLine("2. counter = {0}", counter++);

            //ParameterizedThreadStart
            thread = new Thread((object argument) => { Console.WriteLine("3. counter = {0}", (int)argument); });
            thread.Start(counter);

            Console.ReadKey();
        }
    }
}
