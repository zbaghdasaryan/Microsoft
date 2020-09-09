using System;

namespace Method_Task2
{
    class Program
    {

        static void Params(params int[] array)
        {
            //Խնդիր 3։ Ստեղծել մեթոդ որին կփոխանցեք զանգված ու այն կտպի բոլոր էլեմենտների արժեքները
            //Խնդիր 4։ Ստեղծել ֆունկցիա որին կփոխանցեք թվեր ու այն կհաշվի մեծագույնը ու հետ կվերադարձնի այն
            int maxValue = array[0];

            Console.Write("Array elements: ");
            for (int i = 0; i < array.Length; i++)
            {               
                Console.Write(array[i] + " ");
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }                
            }
            Console.Write("\nMax value of array elements: ");
            Console.WriteLine(maxValue);
        }
        static void Main(string[] args)
        {
            Params(0, 12, 22, 5, 125, 7, 89);
            //int[] array = new int[] { 1, 2, 351, 4, 47, 0 };
            //Params(array);
            //Params();
            Console.ReadLine();
        }
    }
}
