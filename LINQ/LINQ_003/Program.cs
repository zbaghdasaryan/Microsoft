using System;
using System.Linq;

namespace LINQ_003
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection1 = Enumerable.Range(1, 9);
            var collection2 = Enumerable.Range(1, 10);

            var query = from x in collection1
                        from y in collection2
                        select new
                        {
                            x = x,
                            y = y,
                            Product = x * y
                        };

            foreach (var item in query)
            {
                Console.WriteLine("{0} * {1} = {2}", item.x, item.y, item.Product);
            }

            Console.ReadKey();
        }
    }
}
