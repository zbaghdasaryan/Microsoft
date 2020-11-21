using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_7
{
    class BaseClass
    {
        public virtual void Method()
        {
            Console.WriteLine("Method from BaseClass");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            // UpCast
            BaseClass instanceUp = instance;
            instanceUp.Method();

            // DownCast
            DerivedClass instanceDown = (DerivedClass)instanceUp;
            instanceDown.Method();

            Console.ReadKey();
        }
    }
}
