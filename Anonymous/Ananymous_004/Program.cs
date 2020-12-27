using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ananymous_004
{
    class MyClass
    {
        public int field;
        public void Method()
        {
            Console.WriteLine(field);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new { My = new MyClass { field = 1 } }.My.Method();
                       
            Console.ReadKey();
        }
    }
}
