// Example.1 || Interfaces 
/*
using System;

namespace INTERFACES
{
    interface IEmployee
    {
        void show();
    }

    class PartTimeEmployees : IEmployee
    {
        public void show()
        {
            Console.WriteLine("This is a method of IEmployee Interface !!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployees pte = new PartTimeEmployees();   
            pte.show();
            Console.ReadLine(); 
        }
    }
}
*/



// Example.2 || Interface Inheritance
/*
using System;

namespace INTERFACES
{
    interface i1
    {
        void print();
    }
    interface i2
    {
        void print1();
    }
    interface i3 : i1, i2
    {
        void print2();
    }
    class Program : i3
    {
        public void print()
        {
            Console.WriteLine("This is a method of Interface 1 !! ");
        }
        public void print1()
        {
            Console.WriteLine("This is a method of Interface 2 !! ");
        }
        public void print2()
        {
            Console.WriteLine("This is a method of Interface 3 !! ");
        }
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.print();
            //p.print1();
            //p.print2();


            i3 myinterface = new Program();
            myinterface.print();

            Console.ReadLine();
        }
    }
}
*/




// Example.3 || Interface Inheritance
/*
interface IPoint
{
    // Property signatures:
    int X { get; set; }

    int Y { get; set; }

    double Distance { get; }
}

class Point : IPoint
{
    // Constructor:
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Property implementation:
    public int X { get; set; }

    public int Y { get; set; }

    // Property implementation
    public double Distance =>
       Math.Sqrt(X * X + Y * Y);
}

class MainClass
{
    static void PrintPoint(IPoint p)
    {
        Console.WriteLine("x = {0}, y = {1}", p.X, p.Y);
    }

    static void Main()
    {
        IPoint p = new Point(2, 3);
        Console.Write("My Point: ");
        PrintPoint(p);
    }
}
*/


// Example.4 || Multiple Interface
using System;

namespace MyApplication
{
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
        }
    }
}