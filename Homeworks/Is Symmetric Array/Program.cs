using System;

namespace Two_Dimensional_Array_Task
{
    class Program
    {
        //Խնդիր 5։ Ստեղծել n x m երկչափ զանգված և նրա էլեմենտները արժևորել կամայական արժեքներով

        static int ParseToNaturalNumber(string stringForPars, string text)
        {
            int parsedNumber;
            while (!int.TryParse(stringForPars, out parsedNumber) || parsedNumber < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a natural number, please try again!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(text);
                stringForPars = Console.ReadLine();
            }
            return parsedNumber;
        }

        static int ParseToNumber(string stringForPars, string text)
        {
            int parsedNumber;
            while (!int.TryParse(stringForPars, out parsedNumber))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number, please try again!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(text);
                stringForPars = Console.ReadLine();
            }
            return parsedNumber;
        }

        static int ParseToNumberRandomMaxValue(string stringForPars, string text, int minValue)
        {
            int parsedNumber;
            while (!int.TryParse(stringForPars, out parsedNumber) || parsedNumber <= minValue)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number, or max value of random interval less then min value please try again!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(text);
                stringForPars = Console.ReadLine();
            }
            return parsedNumber;
        }

        static int[,] FillTwoDimensionalArrayRandom()
        {
            //input array rows length
            string text1 = "Please input two-dimensional array rows length (natural number greater than 1): r = ";
            Console.Write(text1);
            string length1 = Console.ReadLine();
            int rowLength = ParseToNaturalNumber(length1, text1);

            //input array columns length
            string text2 = "Please input two-dimensional array columns length (natural number greater than 1): c = ";
            Console.Write(text2);
            string length2 = Console.ReadLine();
            int colLength = ParseToNaturalNumber(length2, text2);

            //input min valur of random interval
            string text3 = "Please input min value of random interval: a = ";
            Console.Write(text3);
            var minValue = Console.ReadLine();
            int minValueRand = ParseToNumber(minValue, text3);

            //input max valur of random interval
            string text4 = "Please input max value of random interval: b = ";
            Console.Write(text4);
            var maxValue = Console.ReadLine();
            int maxValueRand = ParseToNumberRandomMaxValue(maxValue, text4, minValueRand);


            //fill random two-dimensional array  
            Random random = new Random();
            int[,] array = new int[rowLength, colLength];
            Console.WriteLine("Two-dimensional array elements: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValueRand, maxValueRand);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return array;
        }
        static void Main(string[] args)
        {
            FillTwoDimensionalArrayRandom();
            Console.ReadKey();
        }
    }
}