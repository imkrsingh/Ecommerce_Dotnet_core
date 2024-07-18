// Example
/*
using System;

namespace MyApplication
{
    class Car
    {
        string color = "red";
        int maxSpeed = 200;

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
        }
    }
}
*/


// Example.2
/*
using System;

namespace MyApplication
{
    class Car
    {
        string color;
        int maxSpeed;

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.color = "red";
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
        }
    }
}
*/


//Multiple objects of one class
/*
using System;

namespace MyApplication
{
    class Car
    {
        string model; //instance
        string color; //instance
        int year;     //instance

        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.year + " " + Opel.color);
            Console.WriteLine(Opel.model);
        }
    }
}
*/



// Object Methods
/*
using System;

namespace MyApplication
{
    class Car
    {
        string color;                 // field
        int maxSpeed;                 // field
        public void fullThrottle()    // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.fullThrottle();  // Call the method
        }
    }
}
*/


// Multiple Classes
using System;
using Learn_Class_Member;

namespace MyApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;


            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
            //fullThrottle()
        }
    }
}
