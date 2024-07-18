///////////////////// Example:1 Where clause - LINQ query syntax C# //////////////////////////////////
/*
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

        // LINQ Query Syntax to find out teenager students
        var teenAgerStudent = from s in studentList
                              where s.Age > 12 && s.Age < 20
                              select s;
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
*/


///////////////////// Example: 2 Linq - Where extension method in C# /////////////////////////////////
/*
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

        var filteredResult = studentList.Where((s, i) => {
            if (i % 2 == 0) // if it is even element
                return true;

            return false;
        });

        foreach (var std in filteredResult)
            Console.WriteLine(std.StudentName);
    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

}
*/



// Example.3 || Multiple WHERE method
/*
using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Department { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 101, Name = "John", Salary = 50000, Department = "IT" },
            new Employee { ID = 102, Name = "Mary", Salary = 60000, Department = "HR" },
            new Employee { ID = 103, Name = "Bob", Salary = 45000, Department = "IT" },
            new Employee { ID = 104, Name = "Alice", Salary = 55000, Department = "HR" },
            new Employee { ID = 105, Name = "Tom", Salary = 40000, Department = "IT" }
        };

        // Using multiple WHERE clauses with query syntax
        var result1 = from emp in employees
                      where emp.Salary > 45000
                      where emp.Department == "IT"
                      select emp;

        Console.WriteLine("Using query syntax:");
        foreach (var emp in result1)
        {
            Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Salary: {emp.Salary}, Department: {emp.Department}");
        }

        Console.WriteLine("\nUsing method syntax:");

        // Using multiple WHERE clauses with method syntax
        var result2 = employees.Where(emp => emp.Salary > 45000)
                               .Where(emp => emp.Department == "IT");

        foreach (var emp in result2)
        {
            Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Salary: {emp.Salary}, Department: {emp.Department}");
        }
    }
}
*/



///////////////////////////Example:4 OfType operator in C# /////////////////////////////////
/*
using System;
using System.Linq;
using System.Collections;

public class Program
{
    public static void Main()
    {
        IList mixedList = new ArrayList();
        mixedList.Add(0);
        mixedList.Add("One");
        mixedList.Add("Two");
        mixedList.Add(3);
        mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

        //var stringResult = from s in mixedList.OfType<int>()
        var stringResult = from s in mixedList.OfType<string>()
                           select s;

        foreach (var str in stringResult)
            Console.WriteLine(str);

    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

}
*/



///////////////////////////// Sorting Operators: OrderBy & OrderByDescending /////////////////////////////////////////
/// Example.5 || OrderBy
/*
using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

        var orderByResult = from s in studentList
                            orderby s.StudentName //Sorts the studentList collection in ascending order
                            select s;

        var orderByDescendingResult = from s in studentList //Sorts the studentList collection in descending order
                                      orderby s.StudentName descending
                                      select s;

        Console.WriteLine("Ascending Order:");

        foreach (var std in orderByResult)
            Console.WriteLine(std.StudentName);

        Console.WriteLine("Descending Order:");

        foreach (var std in orderByDescendingResult)
            Console.WriteLine(std.StudentName);

    }

}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

}
*/



// The following example sorts the studentList collection in ascending order of StudentName using OrderBy extension method.
// Example.6 || OrderBy in Method Syntax C#
/*
using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

        var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);

        var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);


        Console.WriteLine("Ascending Order:");

        foreach (var std in studentsInAscOrder)
            Console.WriteLine(std.StudentName);

        Console.WriteLine("Descending Order:");

        foreach (var std in studentsInDescOrder)
            Console.WriteLine(std.StudentName);

    }

}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

}
*/


// Example:7 Multiple sorting in Query syntax C#
/*
using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

        var multiSortingResult = from s in studentList
                                 orderby s.StudentName, s.Age
                                 select s;

        foreach (var std in multiSortingResult)
            Console.WriteLine("Name: {0}, Age {1}", std.StudentName, std.Age);

    }

}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

}
*/



///////////////////////////// Sorting Operators: ThenBy & ThenByDescending /////////////////////////////////////////
/// Example.5 || OrderBy
/*
using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };

        var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

        var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

        Console.WriteLine("ThenBy:");

        foreach (var std in thenByResult)
            Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);

        Console.WriteLine("ThenByDescending:");

        foreach (var std in thenByDescResult)
            Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);

    }

}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

}
*/


/////////////////////////////// Grouping Operators: GroupBy & ToLookup ////////////////////////////////
/// Example.6
/*
using System;
using System.Linq;
using System.Collections.Generic;

					
public class Program
{
    public static void Main()
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

        var groupedResult = from s in studentList
                            group s by s.Age;

        //iterate each group        
        foreach (var ageGroup in groupedResult)
        {
            Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

            foreach (Student s in ageGroup) // Each group has inner collection
                Console.WriteLine("Student Name: {0}", s.StudentName);
        }

    }

}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

}
*/



// Example.7 || GroupBy in Method Syntax
/*
using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

        var groupedResult = studentList.GroupBy(s => s.Age);

        foreach (var ageGroup in groupedResult)
        {
            Console.WriteLine("Age Group: {0}", ageGroup.Key);  //Each group has a key 

            foreach (Student s in ageGroup)  //Each group has a inner collection  
                Console.WriteLine("Student Name: {0}", s.StudentName);
        }

    }

}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

}
*/


//////////////////////////////////// || ToLookup || ////////////////////////////////////////
// Example.8 
/*
using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

        var lookupResult = studentList.ToLookup(s => s.Age);

        foreach (var group in lookupResult)
        {
            Console.WriteLine("Age Group: {0}", group.Key);  //Each group has a key 

            foreach (Student s in group)  //Each group has a inner collection  
                Console.WriteLine("Student Name: {0}", s.StudentName);
        }

    }

}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }

}
*/



//////////////////////////////// | Joining Operator: Join | ///////////////////////////////////
/*
using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        // Student collection
        IList<string> strList1 = new List<string>() {
            "One",
            "Two",
            "Three",
            "Four"
            };

        IList<string> strList2 = new List<string>() {
            "One",
            "Two",
            "Five",
            "Six"
            };

        var innerJoinResult = strList1.Join(// outer sequence 
                      strList2,  // inner sequence 
                      str1 => str1,    // outerKeySelector
                      str2 => str2,  // innerKeySelector
                      (str1, str2) => str1);

        foreach (var str in innerJoinResult)
        {
            Console.WriteLine("{0} ", str);
        }

    }
}
*/


//////////////////////////////// | Joining Operator: GroupJoin | ///////////////////////////////////
/*
using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 },
                new Student() { StudentID = 6, StudentName = "Manish" , Age = 25, StandardID = 3 } ,
            };

        IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

        var groupJoin = from std in standardList
                        join s in studentList
                        on std.StandardID equals s.StandardID
                            into studentGroup
                        select new
                        {
                            Students = studentGroup,
                            StandardName = std.StandardName
                        };


        foreach (var item in groupJoin)
        {
            Console.WriteLine(item.StandardName);

            foreach (var stud in item.Students)
                Console.WriteLine(stud.StudentName);
        }

    }

}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
    public int StandardID { get; set; }
}

public class Standard
{

    public int StandardID { get; set; }
    public string StandardName { get; set; }
}
*/



//////////////////////////  |Select in Query Syntax C#  |////////////////////////////
///Example.1
/*
using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        // Student collection
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John" } ,
                new Student() { StudentID = 2, StudentName = "Moin" } ,
                new Student() { StudentID = 3, StudentName = "Bill" } ,
                new Student() { StudentID = 4, StudentName = "Ram" } ,
                new Student() { StudentID = 5, StudentName = "Ron"  }
            };

        var selectResult = from s in studentList
                           select s.StudentName;

        foreach (var name in selectResult)
        {
            Console.WriteLine(name);
        }
    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
}
*/



//// Example.2
/*
using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };

        // returns collection of anonymous objects with Name and Age property
        var selectResult = from s in studentList
                           select new { Name = "Mr. " + s.StudentName, Age = s.Age };

        // iterate selectResult
        foreach (var item in selectResult)
            Console.WriteLine("Student Name: {0}, Age: {1}", item.Name, item.Age);
    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}
*/



///////////////////////// All //////////////////////////
/*
using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };

        // checks whether all the students are teenagers    
        bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);


        Console.WriteLine(areAllStudentsTeenAger);
    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}
*/



///////////////////////////// Any //////////////////////////
/*
using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };

        // checks whether any of the students is teenager   
        bool isAnyStudentTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);


        Console.WriteLine(isAnyStudentTeenAger);
    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}
*/



/////////////////////////// Quantifier Operator: Contains ////////////////////////
// Example.1
/*
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };

        bool result = intList.Contains(3);

        Console.WriteLine(result);

    }
}
*/



// Example.2
/*
using System;
using System.Linq;
using System.Collections.Generic;

					
public class Program
{
    public static void Main()
    {
        IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 15 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
        };

        Student std = new Student() { StudentID = 3, StudentName = "Bill" };

        bool result = studentList.Contains(std, new StudentComparer());

        Console.WriteLine(result);
    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}

public class StudentComparer : IEqualityComparer<Student>
{
    public bool Equals(Student x, Student y)
    {
        if (x.StudentID == y.StudentID &&
                 x.StudentName.ToLower() == y.StudentName.ToLower())
            return true;

        return false;
    }

    public int GetHashCode(Student obj)
    {
        return obj.GetHashCode();
    }
}
*/



/////////////////////////// | Aggregation Operators: Aggregate | ///////////////////////////////
//Example.1
/*
using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };

        var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + " : " + s2);

        Console.WriteLine(commaSeperatedString);
    }
}
*/



//Example.2
/*
using System;
using System.Linq;
using System.Collections.Generic;

					
public class Program
{
    public static void Main()
    {
        IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13 } ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };

        string commaSeparatedStudentNames = studentList.Aggregate<Student, string>(
                                        "Student Names: ",  // seed value
                                        (str, s) => str += s.StudentName + " :> ");

        Console.WriteLine(commaSeparatedStudentNames);

    }
}

public class Student
{

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}
*/



///////////////////////// | Aggregation Operator: Average | //////////////////////////
/*
using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IList<int> intList = new List<int>() { 10, 20, 30 };

        var avg = intList.Average();

        Console.WriteLine("Average: {0}", avg);
    }
}
*/




