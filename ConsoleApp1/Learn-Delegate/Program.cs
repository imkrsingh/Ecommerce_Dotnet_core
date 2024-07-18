// Example.1 || Invoke a Delegate
/*
using System;

public delegate void MyDelegate(string msg);

public class Program
{
    public static void Main()
    {
        MyDelegate del = ClassA.MethodA;
        del("Hello World");

        del = ClassB.MethodB;
        del("Hello World");

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


// Example.2 || Passing Delegate as a Parameter
/*
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



// Example.3 || Multicast Delegates
/*
using System;

public delegate void MyDelegate(string msg);
public class Program
{
    public static void Main()
    {
        MyDelegate del1 = ClassA.MethodA;
        MyDelegate del2 = ClassB.MethodB;

        MyDelegate del = del1 + del2;
        Console.WriteLine("After del1 + del2");
        del("Hello World");

        MyDelegate del3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        del += del3;
        Console.WriteLine("After del1 + del2 + del3");
        del("Hello World");

        del = del - del2;
        Console.WriteLine("After del - del2");
        del("Hello World");

        del -= del1;
        Console.WriteLine("After del1 - del1");
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


/*
// Example.4 || Generic Delegate
using System;

public delegate T add<T>(T param1, T param2);

public class Program
{

    public static void Main()
    {
        add<int> sum = Sum;

        Console.WriteLine(sum(10, 20));

        add<string> conct = Concat;

        Console.WriteLine(conct("Hello", "World!!"));
    }

    public static int Sum(int val1, int val2)
    {
        return val1 + val2;
    }

    public static string Concat(string str1, string str2)
    {
        return str1 + str2;
    }
}
*/


///////////////////////
/////////////////////////////   Function Delegate   /////////////////////////////
//////////////////////

// Example.5 || Function Delegate
/*
using System;
public class Program
{
    static Func<int, int, int> operation;


    public static int Sum(int x, int y)
    {
        return x + y;
    }

    public static void Main()
    {
        Func<int, int, int> add = Sum;

        int result = add(10, 10);

        Console.WriteLine(result);
    }
}
*/


// Example.6 || Function Delegate
/*
// C# program to illustrate Func delegate 
using System;

class GFG
{
    // Method 
    public static int mymethod(int s, int d, int f, int g)
    {
        return s * d * f * g;
    }

    // Main method 
    static public void Main()
    {
        Func<int, int, int, int, int> val = mymethod;
        Console.WriteLine(val(10, 100, 1000, 1));
    }
}
*/


// Example.7 || Function Delegate
/*
// C# program to illustrate Func delegate 
using System;

class GFG
{

    // Method 
    public static int method(int num)
    {
        return num + num;
    }

    // Main method 
    static public void Main()
    {

        // Using Func delegate 
        Func<int, int> myfun = method;
        Console.WriteLine(myfun(100));
    }
}
*/


///////////////////////
/////////////////////////////   Action Delegate   /////////////////////////////
//////////////////////
// Example.8 
/*
using System;

public class Program
{
    public static void Main()
    {
        Action<int> printActionDel = ConsolePrint;

        //Or
        //Action<int> printActionDel = new Action<int>(ConsolePrint);

        printActionDel(100);
    }

    public static void ConsolePrint(int i)
    {
        Console.WriteLine(i);
    }
}
*/


// Example.9 || Anonymous method with Action delegate
/*
using System;

public class Program
{
    public static void Main()
    {
        Action<int> printActionDel = delegate (int i)
        {
            Console.WriteLine(i);
        };

        printActionDel(101);
    }
}
*/


// Example.10 || Lambda expression with Action delegate
/*
using System;

public class Program
{
    public static void Main()
    {
        Action<int> printActionDel = i => Console.WriteLine(i);

        printActionDel(10);
    }
}
*/



///////////////////////
/////////////////////////////   Predicate Delegate   /////////////////////////////
//////////////////////
//Example.11 Predicate delegate
/*
using System;

public class Program
{
    public static void Main()
    {
        Predicate<string> isUpper = IsUpperCase;

        bool result = isUpper("hello world!!");

        Console.WriteLine(result);
    }

    public static bool IsUpperCase(string str)
    {
        return str.Equals(str);
    }

}
*/


// Example.12 || Predicate delegate with anonymous method
/*
using System;

public class Program
{
    public static void Main()
    {
        Predicate<string> isUpper = delegate (string s) { return s.Equals(s.ToUpper()); };
        bool result = isUpper("hello world!!");

        Console.Write(result);
    }
}
*/


// Example.13 || Predicate delegate with Lambda expression
/*
using System;

public class Program
{
    public static void Main()
    {
        Predicate<string> isUpper = s => s.Equals(s.ToUpper());
        bool result = isUpper("hello world!!");

        Console.Write(result);
    }
}
*/


///////////////////////
/////////////////////////////   Anonymous Method Delegate   /////////////////////////////
//////////////////////
// Example.1 || Anonymous method
using System;
					
public class Program
{
    public delegate void Print(int value);

    public static void Main()
    {
        Print print = delegate (int val) {
            Console.WriteLine("Inside Anonymous method. Value: {0}", val);
        };

        print(100);
    }
}




