using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constuctor_1
{
    class Program
    {
        class BaseClass
        {
            public int baseNumber;

            // Default constructor.
            public BaseClass()
            {
            }

            // Custom constructor.
            public BaseClass(int baseNumber)
            {
                this.baseNumber = baseNumber;
            }
        }

        class DerivedClass : BaseClass
        {
            public int derivedField;

            // Default constructor.
            //public DerivedClass() 
            //{
            //}

            /*           
            When you create an object of a derived class, the constructor of the derived class 
            automatically calls the default constructor from the base class.
            The constructor of the base class will assign some of its safe values to all data.
            After that, the constructor of the derived class will start working, 
            which will redefine the values for the inherited members. (DOUBLE WORK)!
             */
            public DerivedClass(int number1, int number2)
            {
                // Initialization field of the base class.
                baseNumber = number1;

                // Initialization field of the derived class.
                derivedField = number2;
            }
        }

        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass(1, 2);

            Console.WriteLine(instance.baseNumber);
            Console.WriteLine(instance.derivedField);

            Console.ReadKey();
        }
    }
}
