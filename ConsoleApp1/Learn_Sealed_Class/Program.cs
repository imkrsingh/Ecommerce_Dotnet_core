// Example.1 || Sealed Class
/*
using System;

namespace Sealed_Class
{
   sealed class BaseClass
    {
       public void Show1()
        {
            Console.WriteLine("Method of Base Class...");
        } 
    }

    class DerivedClass : BaseClass
    {
        public void Show2()
        {
            Console.WriteLine("Method of Derived Class...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            dc.Show1();
            Console.ReadLine();
        }
    }
}
*/



//Example.2 || Sealed Methodsusing System;

namespace SEALED_METHOD
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("This is a method of class A !!");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("This is a method of Class B !!");
        }
    }

    class C : B
    {
        public override void Print()
        {
            Console.WriteLine("This is a method of Class C !!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C obj = new C();
            obj.Print();
            Console.ReadLine();
        }
    }
}



