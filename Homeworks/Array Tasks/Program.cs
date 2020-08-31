using System;

namespace Array_Tasks
{
    class Program
    {
        //Խնդիր 1։ Ստեղծել n չափանի զանգված և նրա էլեմենտները արժևորել կամայական արժեքներով
        static int[] FillArrayRandom()
        {
            //input array length
            Console.Write("Please input array length: n = ");
            var length = Console.ReadLine();
            int arrLength;
            while (!int.TryParse(length, out arrLength) || arrLength <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This is not a number or you input nagative value, please try again!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Please input array length: n = ");
                length = Console.ReadLine();
            }

            //input min valur of random interval
            Console.Write("Please input min value of random interval: a = ");
            var minValue = Console.ReadLine();
            int minValueRand;
            while (!int.TryParse(minValue, out minValueRand))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This is not a number, please try again!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Please input min value of random interval: a = ");
                minValue = Console.ReadLine();
            }

            //input max valur of random interval
            Console.Write("Please input min value of random interval: b = ");
            var maxValue = Console.ReadLine();
            int maxValueRand;
            while (!int.TryParse(maxValue, out maxValueRand))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This is not a number, please try again!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Please input min value of random interval: b = ");
                maxValue = Console.ReadLine();
            }

            Random random = new Random();
            int[] array = new int[arrLength];
            Console.Write("Array elements: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValueRand, maxValueRand);
                Console.Write(array[i] + " ");
            }
            return array;

        }

        //Խնդիր 2։ Գտնել զանգվածի մեջ եղած բոլոր դրական թվերը և տպել այն կոնսոլում
        static void PositivNumbersOfRandomArray(int[] array)
        {
            Console.Write("Positiv numbers of the array are: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                    Console.Write(array[i] + " ");
            }
        }

        //Խնդիր 3։ Հաշվել զանգվածի մեջ եղած էլեմենտների գումարը
        static void SumOfRandomArray(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.Write("The sum of array elements: sum = " + sum);
        }

        //Խնդիր 3։ Գտնել զանգվածի մեջ եղած էլեմենտներից մեծագույնը և փոքրագույնը
        static void MinMaxElementsOfRandomArray(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.Write($"\nMin element of array is {array[0]} \nMax element of array is {array[array.Length - 1]}");
        }

        static void Main(string[] args)
        {
            //FillArrayRandom()
            //PositivNumbersOfRandomArray(FillArrayRandom());
            //SumOfRandomArray(FillArrayRandom());
            //MinMaxElementsOfRandomArray(FillArrayRandom());
            Console.ReadKey();
        }
    }
}