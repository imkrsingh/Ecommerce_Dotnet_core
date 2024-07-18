// Example.1 || Enums
/*
using System;

namespace MyApplication
{
    enum Level
    {
        Low,
        Medium,
        High
    }
    class Program
    {
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);
        }
    }
}
*/


// Example.2 || Enum inside a Class
/*
using System;

namespace MyApplication
{
    class Program
    {
        enum Level
        {
            Developer,
            Tester,
            Sales
        }
        static void Main(string[] args)
        {
            Level myVar = Level.Developer;
            Console.WriteLine(myVar);
        }
    }
}
*/


// Example.3 || Enum Value
/*
using System;

namespace MyApplication
{
    class Program
    {
        enum Months
        {
            January,    // 0
            February,   // 1
            March,      // 2
            April,      // 3
            May,        // 4
            June,       // 5
            July        // 6

        }
        static void Main(string[] args)
        {
            int myNum = (int)Months.April;
            Console.WriteLine(myNum);
        }
    }
}
*/



// Example.4 || You can also assign your own enum values, and the next items will update their numbers accordingly:
/*
using System;

namespace MyApplication
{
    class Program
    {
        enum Months
        {
            January,    // 0
            February,   // 1
            March = 6,  // 6
            April,      // 7
            May,        // 8
            June,       // 9
            July        // 10
        }
        static void Main(string[] args)
        {
            int myNum = (int)Months.April;
            Console.WriteLine(myNum);
        }
    }
}
*/



// Example.5 || Enum in a Switch Statement

using System;

namespace MyApplication
{
    class Program
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        static void Main(string[] args)
        {

            Level myVar = Level.Medium;
            switch (myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
            }
        }
    }
}

