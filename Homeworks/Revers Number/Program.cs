using System;

namespace Revers_Number
{
    class Program
    {
        static void ReversNumber(int number)
        {
            int n = number.ToString().Length;
            int sum = 0;
            int[] arrayDigit = new int[n];

            while (number > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    arrayDigit[i] = number % 10;
                    number /= 10;
                    sum += arrayDigit[i];
                }
            }
            Console.Write("Revers number is: ");
            for (int j = 0; j < arrayDigit.Length; j++)
            {
                Console.Write(arrayDigit[j]);
            }
            Console.WriteLine("\nNumber digits sum is: " + sum);
        }
        static void Main(string[] args)
        {
            Console.Write("Please input the number: ");
            string inputNumber = Console.ReadLine();
            int numberForRevers;
            while (!int.TryParse(inputNumber, out numberForRevers))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number, please try again!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Please input the number: ");
                inputNumber = Console.ReadLine();
            }

            ReversNumber(numberForRevers);
            Console.ReadLine();
        }
    }
}