using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_Lock
{
    class MyClass
    {
        object block = new object();

        public void Method()
        {
            int hesh = Thread.CurrentThread.GetHashCode();

            //lock (block)
            //{
            //    for (int count = 0; count < 10; count++)
            //    {
            //        Console.WriteLine("Thread # {0}: step {1}", hesh, count);
            //        Thread.Sleep(300);
            //    }
            //    Console.WriteLine(new string('-',20));
            //}


            //or we can use methods Monitor.Enter(onject obj)/Monitor.Exit(onject obj)
            Monitor.Enter(block);            
                for (int count = 0; count < 10; count++)
                {
                    Console.WriteLine("Thread # {0}: step {1}", hesh, count);
                    Thread.Sleep(300);
                }
                Console.WriteLine(new string('-', 20));           
            Monitor.Exit(block);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            for (int i = 0; i < 3; i++)
            {
                new Thread(instance.Method).Start();
            }

            Console.ReadKey();
        }
    }
}
