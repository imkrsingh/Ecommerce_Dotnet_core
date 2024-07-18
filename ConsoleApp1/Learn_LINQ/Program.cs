// The following example demonstrates a simple LINQ query that gets all strings from an array which contains 'a'.
// Example.1
/*
using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Data source
        string[] names = { "Bill", "Steve", "James", "Mohan" };

        // LINQ Query 
        var myLinqQuery = from name in names
                          where name.Contains('a')
                          select name;

        // Query execution
        foreach (var name in myLinqQuery)
            Console.Write(name + " ");
    }
}
*/


// Example: Use for loop to find elements from the collection in C#
// Example.2
/*
class Student
{
    public int StudentID { get; set; }
    public String StudentName { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
        };

        Student[] students = new Student[5];

        int i = 0;

        foreach (Student std in studentArray)
        {
            if (std.Age > 12 && std.Age < 20)
            {
                students[i] = std;
                i++;
                Console.WriteLine($"Student ID: {std.StudentID}, Name: {std.StudentName}, Age: {std.Age}");
            }
        }
    }
}
*/


// LINQ Query Syntax in C#
// Example.3
/*
using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // string collection
        IList<string> stringList = new List<string>() {
            "C# Tutorials",
            "JavaScript Tutorials",
            "Learn C++",
            "MVC Tutorials" ,
            "Java"
        };

        // LINQ Query Syntax
        var result = from s in stringList
                     where s.Contains("Tutorials")
                     select s;

        foreach (var str in result)
        {
            Console.WriteLine(str);
        }
    }
}
*/



// LINQ Method Syntax
// Example.4
/*
using System;
using System.Linq;
using System.Collections.Generic;

					
public class Program
{
	public static void Main()
	{
		// string collection
		IList<string> stringList = new List<string>() { 
			"C# Tutorials",
			"VB.NET Tutorials",
			"Learn C++",
			"MVC Tutorials" ,
			"Java" 
		};
		
		// LINQ Method Syntax
		var result = stringList.Where(s => s.Contains("Tutorials"));
					
		
		foreach (var str in result)
		{
			Console.WriteLine(str);
		}
	}
}
*/



// The following example shows how to use LINQ method syntax query with the IEnumerable<T> collection.
// Example.5 || Method Syntax in C#
using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

        // LINQ Query Method to find out teenager students
        var teenAgerStudent = studentList.Where(s => s.Age >= 12 && s.Age <= 20);

        Console.WriteLine("Teen age Students:");

        foreach (Student std in teenAgerStudent)
        {
            Console.WriteLine(std.StudentName);
        }
    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

}



