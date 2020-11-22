using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NVI (Non-Virtual Interface)
namespace Polimorphism_NVI
{
    class BaseClass 
    {
        //Non-Virtual method where we use virtual methodes
        public virtual void DoWork()
        {
            PreDoWork();
            OtherDoWork();
        }
        protected void PreDoWork() { Console.WriteLine("0"); }
        protected virtual void OtherDoWork() { Console.WriteLine("1"); }
    }
    class Derived : BaseClass
    {
        protected override void OtherDoWork() {Console.WriteLine("2");}
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass instance = new Derived();
            instance.DoWork();

            Console.ReadKey();
        }
    }
}
