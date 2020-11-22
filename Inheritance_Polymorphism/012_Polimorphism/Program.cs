using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NVI (Non-Virtual Interface)
namespace Polimorphism
{
    class BaseClass
    {
        //Non-Virtual method where we use virtual methodes
        public virtual void SomeMethod()
        {
            SomeMethod1();
            SomeMethod2();
        }
        protected virtual void SomeMethod1() { Console.Write("1."); }
        protected virtual void SomeMethod2() { Console.Write("2."); }
    }
    class Derived : BaseClass
    {
        public new void SomeMethod()
        {
            SomeMethod1();
            SomeMethod2();
        }
        protected new void SomeMethod1() { Console.Write("3."); }
        protected override void SomeMethod2() { Console.Write("4."); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter key 0, 1 or 2");
                string key = Console.ReadLine();
                if (key == "0")
                    new BaseClass().SomeMethod();

                if (key == "1")
                    (new Derived() as BaseClass).SomeMethod();

                if (key == "2")
                    new Derived().SomeMethod();

                Console.WriteLine("\n");
            }
        }
    }
}
