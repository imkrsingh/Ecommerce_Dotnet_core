// Example.1 || Single level Inheritance
/*
using System;
public class Employee
{
    public float salary = 40000;
}
public class Programmer : Employee
{
    public float bonus = 10000;
}
class TestInheritance
{
    public static void Main(string[] args)
    {
        Programmer p1 = new Programmer();

        Console.WriteLine("Salary: " + p1.salary);
        Console.WriteLine("Bonus: " + p1.bonus);

    }
}
*/

// Example.2 || Single level Inheritance
/*
using System;  
   public class Animal
{
    public void eat() { Console.WriteLine("Eating..."); }
}
public class Dog : Animal
{
    public void bark() { Console.WriteLine("Barking..."); }
}
class TestInheritance2
{
    public static void Main(string[] args)
    {
        Dog d1 = new Dog();
        d1.eat();
        d1.bark();
    }
}
*/


// Example.3 || Inheritance
/*
using System;

namespace Inheritance_Csharp
{
    class VisitingEmployees : Employees
    {
        public int VisitingSalary;
        public int VisitingHours; 
    }
    class PermanentEmployees : Employees
    {
        public int PermanentSalary;
        public int PermanentHours;
    }
    class Employees
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
        public int EmpContactNo;

        public void show()
        {
            Console.WriteLine("This is method of base class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             PermanentEmployees Manish =  new PermanentEmployees();
            Manish.EmpId = 12;
            Manish.show();


            VisitingEmployees Singh = new VisitingEmployees();
            Singh.EmpId = 24;

            Console.WriteLine(Manish.EmpId);
            Console.WriteLine(Singh.EmpId);
            Console.ReadLine();
        }
    }
}
*/



// Example.4 || Hierarchical Inheritance
/*
using System;

// Base Class 
public class Father
{
    //private string address;

    //public Father(string addr)
    //{
    //    address = addr;
    //}
    public string FatherName()
    {
        return "Ravi";
    }

    public string Address()
    {
        return "#2123 Parents Address"
    }


}

// Derived Class 
public class ChildFirst : Father
{
    //public ChildFirst(string address):base(address)
    //{
        
    //}
    public string ChildDName()
    {
         return "Rohan";
    }
}

// Derived Class 
public class ChildSecond : Father
{
    //public ChildSecond(string address):base(address)
    //{
        
    //}
    public string ChildDName()
    {
        return "Nikhil";
    }
}

class GFG
{

    static public void Main()
    {
        ChildFirst first = new ChildFirst();

        // Displaying Child Name and Father Name for 
        // ChildFirst 
        Console.WriteLine("My name is " + first.ChildDName() +
                          ". My father name is " +
                          first.FatherName() + ".");
        ChildSecond second = new ChildSecond();

        // Displaying Child Name and Father Name for 
        // ChildSecond 
        Console.WriteLine("My name is " + second.ChildDName() +
                          ". My father name is " +
                          second.FatherName() + ".");
    }
}


*/


// Example 4.1 || Hierarchical Inheritance
namespace LearningInheritance
{
    class ParentClass
    {
        public string animal = "Lion";
        public int age = 30;
        private string color;

        public ParentClass(string clr)
        {
           color = clr;
        }

        public void displayParentClassDetails()
        {
            Console.WriteLine($"Color is {color}");
            //Console.WriteLine($"ID : {age}");
        }
    }

    class ChildClass : ParentClass
    {
        public ChildClass(string color): base(color)
        {
            
        }
        public void getIdFromParentClass()
        {
            Console.WriteLine("Displaying from my Child Class");
            Console.WriteLine($"I am  a : {animal}.");
        }
    }

    //class AnotherChildClass : ParentClass
    //{
    //    public void getIdFromParentClass()
    //    {
    //        Console.WriteLine("Displaying from my other Child Class");
    //        Console.WriteLine($"My age is : {age}");
    //        Console.WriteLine($"My color is : {color}");
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //accessing the inherited members in the parent class (from the child class)
            ChildClass child = new ChildClass("red");
            //child.getIdFromParentClass();
            child.displayParentClassDetails();

            //accessing the inherited members in the parent class (from the other child class)
            //AnotherChildClass anotherChild = new AnotherChildClass();
            //anotherChild.getIdFromParentClass();

        }
    }
}

/*
// Example.5 || Multilevel Inheritance
using System;

public class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

public class Mammal : Animal
{
    public void Walk()
    {
        Console.WriteLine("The mammal is walking.");
    }
}

public class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}

public class Program
{
    public static void Main()
    {
        Dog myDog = new Dog();
        myDog.Eat();
        myDog.Walk();
        myDog.Bark();
    }
}

*/
