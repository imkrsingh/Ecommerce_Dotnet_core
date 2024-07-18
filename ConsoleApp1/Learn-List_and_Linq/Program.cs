// Example.1 || List
/*
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

class Program
{
    public static void Main()
    {
        // create a list
        List<string> languages = new List<string>() { "Python", " Java", " React.js", " Node.js", " Expression.js" };

        // access the first and second elements of languages list
        Console.WriteLine("The first element of the list is " + languages[0]);
        Console.WriteLine("The second element of the list is " + languages[1]);
        Console.WriteLine("The element of the list is " + languages[1] + languages[2] + languages[3] + languages[4]);
    }
}
*/

// Example. 1.1 || List
/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a List of integers
        List<int> numbers = new List<int>();

        // Add elements to the List
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        // Access elements using index
        Console.WriteLine(numbers[0]); // Output: 1
        Console.WriteLine(numbers[1]); // Output: 2
        Console.WriteLine(numbers[2]); // Output: 3

        // Iterate through the List using foreach
        foreach (int num in numbers)
        {
            Console.Write(num + " "); // Output: 1 2 3 
        }
    }
}
*/



// Example.2 || Generics
// C# program to show working of user defined Generic classes
/*
using System;

// We use < > to specify Parameter type
public class GFG<T>
{

    // private data members
    private T data;

    // using properties
    public T value
    {

        // using accessors
        get
        {
            return this.data;
        }
        set
        {
            this.data = value;
        }
    }
}

// Driver class
class Test
{

    // Main method
    static void Main(string[] args)
    {

        // instance of string type
        GFG<string> name = new GFG<string>();
        name.value = "Manish Singh";

        // instance of float type
        GFG<float> version = new GFG<float>();
        version.value = 25.0F;

        // display GeeksforGeeks
        Console.WriteLine(name.value);

        // display 5
        Console.WriteLine(version.value);
    }
}
*/



