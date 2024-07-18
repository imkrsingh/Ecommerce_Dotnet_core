using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a Dictionary with string keys and int values
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        // Adding key-value pairs to the Dictionary
        myDictionary.Add("One", 1);
        myDictionary.Add("Two", 2);
        myDictionary.Add("Three", 3);

        // Accessing values by key
        Console.WriteLine("Value for key 'Two': " + myDictionary["Two"]);

        // Checking if a key exists
        if (myDictionary.ContainsKey("Four"))
        {
            Console.WriteLine("Value for key 'Four': " + myDictionary["Four"]);
        }
        else
        {
            Console.WriteLine("Key 'Four' not found in the Dictionary.");
        }

        // Iterating over key-value pairs
        foreach (var pair in myDictionary)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
    }
}