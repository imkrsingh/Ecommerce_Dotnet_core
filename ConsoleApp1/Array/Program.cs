// Example.1 | Access the Elements of an Array
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);
        }
    }
}
*/


// Example.2 | Change an Array Element
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
        }
    }
}
*/

// Example.3 | Array Length
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "apple", "orange", "banana", "grape", "mango"};
            Console.WriteLine(cars.Length);
        }
    }
}
*/


// Example.4 | Loop Through an Array
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
        }
    }
}
*/



// Example.5 || ForEach Loop
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Lion", "Tiger", "Deer", "Elephant", "Rhino" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}

*/

/*
using System;
using System.Linq;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // largest value
            Console.WriteLine(myNumbers.Min());  // smallest value
            Console.WriteLine(myNumbers.Sum());  // sum of myNumbers
            Console.WriteLine(myNumbers);

            Console.ReadLine();

            
        }
    }
}
*/


/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort a string
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
*/



/*
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] my_array = new int[3];
            my_array[0] = 10;
            my_array[1] = 20;
            my_array[2] = 30;
            Console.WriteLine(my_array[0]);
        }
    }
}

*/



//Example. 2D Array
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 }, {4, 7, 2 } };
            Console.WriteLine(numbers[2, 1]);
        }

    }
}