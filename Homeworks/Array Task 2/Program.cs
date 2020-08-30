//Խնդիր 2։ Գտնել զանգվածի մեջ եղած բոլոր դրական թվերը և տպել այն կոնսոլում
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Task_2
{
    class Program
    {
        static void PositivNumbersOfRandomArray(int n, int minValueRand, int maxValueRand)
        {
            Random random = new Random();
            int[] array = new int[n];
            Console.Write("array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValueRand, maxValueRand);
                Console.Write(array[i] + " ");               
            }
            Console.WriteLine();
            Console.Write("positiv numbers of the array: ");
            for (int j = 0; j < array.Length; j++)
            {
                if(array[j] >=0)
                Console.Write(array[j] + " ");
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
                    PositivNumbersOfRandomArray(n, minValueRand, maxValueRand);
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
