using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ananymous_005
{
    delegate void MyDlegate(string text);
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new 
            { 
                MyDel = new MyDlegate((string text) => Console.WriteLine(text)) 
            };
            instance.MyDel.Invoke("Hello Ananymous Type");

            Console.ReadKey();
        }
    }
}
