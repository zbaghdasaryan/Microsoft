using System;
using System.Collections;
using System.Linq;

namespace LINQ_004
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);

            //public class ArrayList : IList, ICollection, IEnumerable, ICloneable
            //not generic IEnumerable thats why we need to add concret type for n
            var query = from int n in numbers
                        select n * 2;

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
