using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2
{
    class BaseClass
    {
        // Fields

        // public fields.
        public string publicField = "BaseClass.publicField";

        // protected fields.
        protected string protectedField = "BaseClass.protectedField";

        // private fields.
        private string privateField = "BaseClass.privateField";

        public void Show()
        {
            Console.WriteLine(privateField);
        }
    }

    class DerivedClass : BaseClass
    {
        // Constructor.
        public DerivedClass()
        {
            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";
            //privateField = "DerivedClass.privateField";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();

            Console.WriteLine(instance.publicField);

            instance.Show();

            Console.ReadKey();
        }
    }
}
