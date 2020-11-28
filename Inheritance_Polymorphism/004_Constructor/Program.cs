using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constuctor_2
{
    class Program
    {
        class BaseClass
        {
            public int baseNumber;

            // Default constructor.
            //public BaseClass()
            //{
            //}

            // Custom constructor.
            public BaseClass(int baseNumber)
            {
                this.baseNumber = baseNumber;
            }
        }

        class DerivedClass : BaseClass
        {
            public int derivedField;

            //Default constructor.
            //public DerivedClass()
            //{
            //}

            /*           
            The custom constructor of the base class is called without having to 
            assign values to inherited members in the derived class constructor.
            */
            public DerivedClass(int number1, int number2)
            : base(number1)
            {
                derivedField = number2;
            }
        }

        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass(1, 2);
            //DerivedClass instance = new DerivedClass();

            Console.WriteLine(instance.baseNumber);
            Console.WriteLine(instance.derivedField);

            Console.ReadKey();
        }
    }
}
