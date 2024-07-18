// Create an Object
/*
using System;

namespace MyApplication
{
    class Car
    {
        string color = "Green";
        int weight = 500;

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.weight + " kg");
        }
    }
}
*/


// Multiple Classes and Objects
// Multiple Object
/*
using System;

namespace MyApplication
{
    class Car
    {
        string color = "blue";

        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
        }
    }
}
*/


// Using Multiple Classes

using System;

namespace MyApplication
{
    class Car
    {
        public string color = "Brown";
    }
}


namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
}






