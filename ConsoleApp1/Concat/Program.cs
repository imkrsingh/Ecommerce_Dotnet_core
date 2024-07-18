using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Manish ";
            string lastName = "Singh";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);
        }
    }
}
