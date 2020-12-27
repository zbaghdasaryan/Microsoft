using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new { Name = "Armen", Age = 25, Id = new { Number = 1} };

            Console.WriteLine("Name={0}, Age={1}, Id={2}", instance.Name, instance.Age, instance.Id.Number);

            Console.ReadKey();
        }
    }
}
