using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_001
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new { Name = "Armen", Age = 25 };

            Console.WriteLine("Name={0}, Age={1}", instance.Name, instance.Age);

            Type type = instance.GetType();

            Console.WriteLine(type.ToString());

            Console.ReadKey();
        }
    }
}
