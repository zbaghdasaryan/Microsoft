using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_007
{
    public class Result
    {
        public int Input { get; set; }
        public int Output { get; set; }
        public Result(int input, int output)
        {
            Input = input;
            Output = output;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            var query = from x in numbers
                        select new Result(x, x * 2);

            //without class using anaymous type
            //var query = from x in numbers
            //            select new {Input = x, Output = x * 2);

            numbers[0] = 777;

            foreach (var item in query)
            {
                Console.WriteLine("Input = {0}, Output = {1}", item.Input, item.Output);
            }
            
            Console.ReadKey();
        }
    }
}
