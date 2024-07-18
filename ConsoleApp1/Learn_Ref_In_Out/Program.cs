// Example.1 || ref keyword
/*
using System;

class Program
{
    static void Main()
    {
        int number = 10;
        Console.WriteLine("Before: " + number);  // Output: Before: 10
        
        // Passing 'number' by reference using 'ref' keyword
        ModifyNumber(ref number);
        
        Console.WriteLine("After: " + number);  // Output: After: 20
    }

    static void ModifyNumber(ref int num)
    {
        num = 20;  // Modifying the original variable
    }
}
*/



// Example.2 || out keyword | allow changes

class Program
{
    static void Main()
    {
        int x;
        int y;

        // Passing x and y as out parameters to GetValues method
        GetValues(out x, out y);

        // Outputting the values returned by the method
        Console.WriteLine("x: " + x); // Output: x: 10
        Console.WriteLine("y: " + y); // Output: y: 20
    }

    static void GetValues(out int a, out int b)
    {
        // Assigning values to the out parameters
        a = 10;
        b = 20;
    }
}




// Example.3 || in keyword || not allow changes (read-only)
/*
using System;

class Program
{
    static void Main()
    {
        int number = 10;
        Console.WriteLine("Before: " + number);  // Output: Before: 10

        // Passing 'number' by reference using 'in' keyword
        DisplayNumber(in number);

        Console.WriteLine("After: " + number);  // Output: After: 10 (original value remains unchanged)
    }

    static void DisplayNumber(in int num)
    {
        Console.WriteLine("Number: " + num);
    }
}
*/