using System;
using System.Collections.Generic;

namespace LINQ_002
{
    public static class MySet
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            Console.WriteLine("Where from our method");
            return System.Linq.Enumerable.Where(source, predicate);
        }

        public static IEnumerable<T> Select<R, T>(this IEnumerable<R> source, Func<R, T> selector)
        {
            Console.WriteLine("Select from our method");
            return System.Linq.Enumerable.Select(source, selector);
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 5, 6, 7, 8, 11, 12, 17 };

            var query = from x in numbers
                        where x % 2 == 0
                        select x * 2;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
