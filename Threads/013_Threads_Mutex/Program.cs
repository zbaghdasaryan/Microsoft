using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_Mutex
{
    class Program
    {

        //static Mutex mutex = new Mutex();
        static Mutex mutex = new Mutex(false, "MyMutex");
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(Function);
                threads[i].Name = i.ToString();
                threads[i].Start();
            }
            Console.ReadKey();
        }

        static void Function()
        {
            /*
            Основную работу по синхронизации выполняют методы WaitOne() и ReleaseMutex(). 
            Метод mutexObj.WaitOne() приостанавливает выполнение потока до тех пор, пока не будет получен мьютекс mutexObj.
            После выполнения всех действий, когда мьютекс больше не нужен, поток освобождает его с помощью метода mutexObj.ReleaseMutex()
             */

            mutex.WaitOne();
            Console.WriteLine("Thread {0} enter safe area", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("Thread {0} exit safe area", Thread.CurrentThread.Name);
            mutex.ReleaseMutex();
        }
    }
}
