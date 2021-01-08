using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPool_012
{
    class Program
    {
        static void Report()
        {
            //give time for starting threads
            Thread.Sleep(200);
            int availibleWorkThreads, availibleIOThreads, maxWorkThreads, maxIOThreads;
            ThreadPool.GetAvailableThreads(out availibleWorkThreads, out availibleIOThreads);
            ThreadPool.GetMaxThreads(out maxWorkThreads, out maxIOThreads);

            Console.WriteLine("Availible working Threads {0} of {1}", availibleWorkThreads, maxWorkThreads);
            Console.WriteLine("Availible IO Threads {0} of {1}", availibleIOThreads, maxIOThreads);
            Console.WriteLine();
        }

        static void Task1(Object state)
        {
            Thread.CurrentThread.Name = "1";
            Console.WriteLine("Start Thread {0}\n", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("End Thread {0}\n", Thread.CurrentThread.Name);
        }

        static void Task2(Object state)
        {
            Thread.CurrentThread.Name = "2";
            Console.WriteLine("Start Thread {0}\n", Thread.CurrentThread.Name);
            Thread.Sleep(500);
            Console.WriteLine("End Thread {0}\n", Thread.CurrentThread.Name);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            
            //availible threads
            Report();

            //run task1 in ThreadPool
            ThreadPool.QueueUserWorkItem(new WaitCallback(Task1));
            Report();

            //run task2 in ThreadPool
            ThreadPool.QueueUserWorkItem(new WaitCallback(Task2));
            Report();

            Thread.Sleep(3000);
            Console.WriteLine("Finish");

            Console.ReadKey();
        }
    }
}
