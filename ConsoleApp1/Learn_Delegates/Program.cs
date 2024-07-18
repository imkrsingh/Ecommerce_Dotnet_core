using System;

// Example.1 || Delegates
/*
namespace Learn_Delegates
{
    public delegate void Calulation(int a , int b);
    class Program
    {
        public static void Addition(int a , int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is: {0}", result);
        }

        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Substraction result is: {0}", result);
        }

        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication result is: {0}", result);
        }

        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division result is: {0}", result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Program.Addition);
            Program.Addition(20, 20);

            Calculation obj1 = new Calculation(Program.Substraction);
            Program.Substraction(20, 10);

            Calculation obj2 = new Calculation(Program.Multiplication);
            Program.Multiplication(20, 10);

            Calculation obj3 = new Calculation(Program.Division);
            Program.Division(20, 10);

            Console.ReadLine();
        }
    }
}
*/



//Example.2 || Single Cast Delegates
/*
namespace Single_Cast_Delegates
{
    public delegate void Calculation(int num1 , int num2);
    class Program
    {
        public static void Addition(int num1 , int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition result is: {0}",result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Addition);
            obj(50,100);
            Console.ReadLine();

        }
    }
}
*/


//Example.2 || Multiple Delegates
/*
namespace Multiple_Delegates
{
    public delegate void Calculation(int num1, int num2);
    public delegate void Show_Delegate();
    public delegate void Calculation2(int num);
    class Program
    {
        public static void Square(int num)
        {
           int square = num * num;
            Console.WriteLine("Square of {0} is {1}", num, square);
        }
        public static void Cube(int num)
        {
            int cube = num * num * num;
            Console.WriteLine("Cube of {0} is {1}", num, cube);
        }
        public static void Show()
        {
            Console.WriteLine("This is a Show method !!");
        }
        public static void Addition(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition result is: {0}", result);
        }
        static void Main(string[] args)
        {

            Calculation2 obj = new Calculation2(Square);
            obj.Invoke(5);

            Calculation2 obj1 = new Calculation2(Cube);
            obj1.Invoke(3);
            //Calculation obj = new Calculation(Addition);
            //obj(50, 100);

            //Show_Delegate obj = new Show_Delegate(Show);
            //obj.Invoke();
            Console.ReadLine();

        }
    }
}
*/



// Example.3 || The following is a full example of a delegate.
/*
using System;

public delegate void MyDelegate(string msg);

public class Program
{
    public static void Main()
    {
        MyDelegate del = ClassA.MethodA;
        del("Hello World from Class A");

        del = ClassB.MethodB;
        del("Hello World from Class B");

        del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        del("Hello World");

    }
}

public class ClassA
{
    public static void MethodA(string message)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
    }
}

public class ClassB
{
    public static void MethodB(string message)
    {
        Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
    }
}
*/



// Example.4 || Passing Delegate as a Parameter

using System;

public delegate void MyDelegate(string msg);

public class Program
{
    public static void Main()
    {
        MyDelegate del = ClassA.MethodA;
        InvokeDelegate(del);

        del = ClassB.MethodB;
        InvokeDelegate(del);

        del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        InvokeDelegate(del);

    }

    public static void InvokeDelegate(MyDelegate del)
    {
        del("Hello World!!!");
    }
}

public class ClassA
{
    public static void MethodA(string message)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
    }
}

public class ClassB
{
    public static void MethodB(string message)
    {
        Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
    }
}










