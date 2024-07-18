// While Loop
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
*/



// Do While Loops
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 6);
        }
    }
}
*/



// For Loop (Example.1)
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
*/


// For Loop (Example.2)
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i = i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
*/


// For Loop (Example.3)
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outer loop
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j);  // Executes 6 times (2 * 3)
                }
            }
        }
    }
}
*/



// Nested Loop

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outer loop
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j);
                }
            }
        }
    }
}