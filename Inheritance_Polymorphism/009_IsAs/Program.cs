using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAs
{
    class ClassA { /* ... */ }

    class ClassB : ClassA { /* ... */ }

    class Program
    {
        static void Main()
        {
            ClassB b = new ClassB();
            ClassA a = null;

            // Оператор is - проверяет совместимость объекта с заданным типом. 
            // Если предоставленный объект может быть приведен к предоставленному типу не вызывая исключение, выражение is принимает значение true.
            // Например, в следующем коде определяется, является ли объект экземпляром типа A или типа, производного от A:

            if (b is ClassA)
            {
                a = (ClassA)b;
            }
            else
            {
                a = null;
            }

            // Оператор as подобен оператору приведения. Однако, если преобразование невозможно, as возвращает значение null, а не вызывает исключение.


            a = b as ClassA;

            // Delay.
            Console.ReadKey();
        }
    }
}
