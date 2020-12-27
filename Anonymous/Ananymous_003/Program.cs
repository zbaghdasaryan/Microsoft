using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ananymous_003
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
            var instence = new { My = new MyClass() };
            instence.My.field = 1;
            instence.My.Method();

            Console.ReadKey();
        }
    }
}
