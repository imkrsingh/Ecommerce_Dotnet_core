//using System;

//class Program
//{
//    public void Show()  // Declaring a method // non-static // instance method
//    {
//        Console.WriteLine("Welcome to C# Programming..");
//        Console.WriteLine("Hey");
//    }

//    public static void Show1()  // Declaring a method // static method // instance method
//    {
//        Console.WriteLine("Welcome to C# Programming..");
//        Console.WriteLine("Hey");
//    }

//    static void Main(string[] args)
//    {
//        Program.Show1(); // calling  a function
//        /*Program p1 = new Program();
//        p1.Show(); // call   
//        p1.Show(); // call*/
//        Console.ReadLine();
//    }
//}



// Methods using with Parameters and Arguments
/*
using System;

class Program
{
    public static void Add(int num1, int num2) // Parameter
    {
        int result = num1 + num2;
        Console.WriteLine("Addition result is: " + result);
    }
    static void Main(string[] args)
    {

        Console.WriteLine("Enter first number: ");
        int a = int .Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Program.Add(a, b); // arguments
        //Program.Add(50, 30); // Arguments
        //Program.Add(20, 90); // Arguments
        Console.ReadLine();
    }
}
*/


// Example.2 Parameters and Argument
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void MyMethod(string fname) // fname is Parameter
        {
            Console.WriteLine("Hi " + fname);
        }

        static void Main(string[] args)
        {
            MyMethod("Manish"); // Arguments
            MyMethod("Kumar"); // Arguments
            MyMethod("Singh"); // Arguments
        }
    }
}

*/


// Example.3 || Multiple Parameters
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        static void Main(string[] args)
        {
            MyMethod("Liam", 5);
            MyMethod("Jenny", 8);
            MyMethod("Anja", 31);
        }
    }
}
*/


// Default Parameter Value
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        static void Main(string[] args)
        {
            MyMethod("Sweden");
            MyMethod("India");
            MyMethod();
            MyMethod("USA");
        }
    }
}
*/


// Return Value
/*
using System;

namespace MyApplication
{
    class Program
    {
        static int MyMethod(int x)
        {
            return 5 + x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(3));
        }
    }
}
*/


// Sum of Two Parameter using return keyword
/*
using System;

namespace MyApplication
{
    class Program
    {
        static int MyMethod(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(5, 3));
        }
    }
}
*/



// Sum of Two Parameter using return keyword || store the result in a variable
/*
using System;

namespace MyApplication
{
    class Program
    {
        static int MyMethod(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int z = MyMethod(5, 3);
            Console.WriteLine(z);
        }
    }
}
*/


// Named Argument
using System;

namespace MyApplication
{
    class Program
    {
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        static void Main(string[] args)
        {
            MyMethod(child3: "John", child1: "Liam", child2: "Harry");
        }
    }
}
