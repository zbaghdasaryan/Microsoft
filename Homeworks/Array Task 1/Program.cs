//Խնդիր 1։ Ստեղծել զանգված n չափանի և նրա էլեմենտները արժևորել կամայական արժեքներով

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Task_1
{
    class Program
    {
        static void FillArrayRandom(int n, int minValueRand, int maxValueRand)
        {
            Random random = new Random();
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValueRand, maxValueRand);
                Console.Write(array[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            {
                try
                {
                    Console.Write("Enter array length: n = ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter min value of random interval: a = ");
                    int minValueRand = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter max value of random interval: b = ");
                    int maxValueRand = Convert.ToInt32(Console.ReadLine());
                    FillArrayRandom(n, minValueRand, maxValueRand);
                }
                catch (Exception)
                {
                    Console.WriteLine("please enter the numbers");
                }
            }
            Console.ReadKey();
        }
    }
}