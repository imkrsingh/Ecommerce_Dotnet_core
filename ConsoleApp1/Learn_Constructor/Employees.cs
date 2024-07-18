// Default Constructor
// Example.1
/*
class Employees
{
    //parameterized constructor
    int EmpId;
    string EmpName;
    int EmpAge;

    public Employees(int empId, string empName, int empAge)
    {
        this.EmpId = empId;
        this.EmpName = empName;
        this.EmpAge = empAge;
    }

    public int getId()
    {
        return this.EmpId;
    }
    public string getName()
    {
        return this.EmpName;
    }

    public int getAge()
    {
        return this.EmpAge;
    }
*/

    // default Constructor
    /*
    public Employees()
    {
        Console.WriteLine("Constructor called !");
    }
    static void Main(string[] args)
    {
        Employees Manish = new Employees(11, "Manish_Singh", 25);
        Employees Jain = new Employees(12, "Malik_Jain", 26);

        Console.WriteLine("Employee Id is " + Manish.getId());
        Console.WriteLine("Employee Name is " + Manish.getName());
        Console.WriteLine("Employee Age is " + Manish.getAge());
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Employee Id is " + Jain.getId());
        Console.WriteLine("Employee Name is " + Jain.getName());
        Console.WriteLine("Employee Age is " + Jain.getAge());
        Console.ReadLine();
    }
}
*/


// Default Constructor
// Example.2
/*
using System;

namespace MyApplication
{
    // Create a Car class
    class Name
    {
        public string fullName;  // Create a field

        // Create a class constructor for the Car class
        public Name()
        {
            fullName = "Manish Singh"; // Set the initial value for model
        }

        static void Main(string[] args)
        {
            Name Ford = new Name();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford.fullName);  // Print the value of model
        }
    }
}
*/



// Many Parameter
using System;

namespace MyApplication
{
    class Car
    {
        public string model;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
        }
    }
}
