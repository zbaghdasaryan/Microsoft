using System;

namespace factorial_recursion
{
    class Program
    {
        static int factNumber(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
                return number * factNumber(number - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(factNumber(20));
            Console.ReadKey();
        }
    }
}