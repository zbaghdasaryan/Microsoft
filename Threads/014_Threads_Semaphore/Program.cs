using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Семафоры позволяют ограничить доступ определенным количеством объектов.
namespace Threads_Semaphore
{
    class Program
    {
        static Semaphore pool;

        static void Function(object number)
        {
            /*
            В начале для ожидания получения семафора используется метод sem.WaitOne(). 
            После того, как в семафоре освободится место, данный поток заполняет свободное 
            место и начинает выполнять все дальнейшие действия. После окончания чтения мы 
            высвобождаем семафор с помощью метода sem.Release(). После этого в семафоре 
            освобождается одно место, которое заполняет другой поток.
             */
            pool.WaitOne();
            Console.WriteLine("Thread {0} used semaphore slot", number );
            Thread.Sleep(2000);
            Console.WriteLine("Thread {0} freed semaphore slot", number);
            pool.Release();
        }
        static void Main(string[] args)
        {
            pool = new Semaphore(2, 4, "MySemaphore");
            for (int i = 0; i < 8; i++)
            {
                new Thread(Function).Start();
            }
            Console.ReadKey();
        }
    }
}
