//Խնդիր 3։ Հաշվել զանգվածի մեջ եղած էլեմենտների գումարը
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Task_3
{
    class Program
    {
        static void SumOfRandomArray(int n, int minValueRand, int maxValueRand)
        {
            Random random = new Random();
            int[] array = new int[n];
            long sum = 0;
            Console.Write("array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValueRand, maxValueRand);
                sum += array[i];
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.Write("sum of array elements: sum = " +sum);            
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
                    SumOfRandomArray(n, minValueRand, maxValueRand);
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
