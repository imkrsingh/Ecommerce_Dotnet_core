// Example.1 | Access Modifiers | private
/*
namespace Access_Modifirs
{
    class Program
    {
        
    }
    class Car
    {
         string model;
         string color;
         int price;

         void PrintCarInformation()
        {
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("Price:" + price);
        }
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.model = "Ferrari";
            myCar.color = "Black";
            myCar.price = 30000000;
            myCar.PrintCarInformation();
        }
    }
}
*/


// Example.2 | Access Modifiers | public
/*
namespace Access_Modifirs
{
    class Program
    {
         static void Main(string[] args)
        {
            Fruit myFruit = new Fruit();
            myFruit.name = "Mango";
            myFruit.color = "Yellow";
            myFruit.price = 30000000;
            myFruit.PrintFruitInformation();
        }
    }
    class Fruit
    {
        public string name;
        public string color;
        public int price;

        public void PrintFruitInformation()
        {
            Console.WriteLine("Model:" + name);
            Console.WriteLine("Color:" + color);
            Console.WriteLine("Price:" + price);
        }
       
    }
}*/



// Example.3 | Program to show the use of public Access Modifier
/*
using System;

namespace publicAccessModifier
{

    class Student
    {

        // Declaring members rollNo
        // and name as public
        public int rollNo;
        public string name;

        // Constructor
        public Student(int r, string n)
        {
            rollNo = r;
            name = n;
        }

        // methods getRollNo and getName
        // also declared as public
        public int getRollNo()
        {
            return rollNo;
        }
        public string getName()
        {
            return name;
        }
    }

    class Program
    {

        // Main Method
        static void Main(string[] args)
        {
            // Creating object of the class Student
            Student S = new Student(1, "Astrid");

            // Displaying details directly
            // using the class members
            // accessible through another method
            Console.WriteLine("Roll number: {0}", S.rollNo);
            Console.WriteLine("Name: {0}", S.name);

            Console.WriteLine();

            // Displaying details using 
            // member method also public
            Console.WriteLine("Roll number: {0}", S.getRollNo());
            Console.WriteLine("Name: {0}", S.getName());
        }
    }
}
*/


// Example.4 || protected Accessibility Level
// Example: In the code given below, the class Y inherits from X, therefore, any protected members of X can be accessed from Y but the values cannot be modified.
// protected Access Modifier

using System;

namespace protectedAccessModifier
{

    class X
    {

        // Member x declared
        // as protected
        protected int x;

        //constructor
        public X()
        {
            x = 10;
        }
    }

    // class Y inherits the 
    // class X
    class Y : X
    {

        // Members of Y can access 'x'
        public int getX()
        {
            return x;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            X obj1 = new X();
            Y obj2 = new Y();

            // Displaying the value of x
            Console.WriteLine("Value of x is : {0}", obj2.getX());
        }
    }
}





// Example.5 || internal Accessibility Level
// In the code given below, The class Complex is a part of internalAccessModifier namespace and is accessible throughout it.
// internal access modifier
/*
using System;

namespace internalAccessModifier
{

    // Declare class Complex as internal
    internal class Complex
    {

        int real;
        int img;

        public void setData(int r, int i)
        {
            real = r;
            img = i;
        }

        public void displayData()
        {
            Console.WriteLine("Real = {0}", real);
            Console.WriteLine("Imaginary = {0}", img);
        }
    }

    // Driver Class
    class Program
    {

        // Main Method
        static void Main(string[] args)
        {
            // Instantiate the class Complex
            // in separate class but within 
            // the same assembly
            Complex c = new Complex();

            // Accessible in class Program
            c.setData(2, 1);
            c.displayData();
        }
    }
}
*/



// Example.6 || private Accessibility Level
// Access is only granted to the containing class. Any other class inside the current or another assembly is not granted access to these members.
// C# Program to show use of  the private access modifier

//using System;

namespace PrivateAccessModifier
{

    class Parent
    {

        // Member is declared as private
        private int value;

        // value is Accessible 
        // only inside the class
        public void setValue(int v)
        {
            value = v;
        }

        public int getValue()
        {
            return value;
        }
    }
    class Child : Parent
    {

        public void showValue()
        {
            // Trying to access value
            // Inside a derived class
            // Console.WriteLine( "Value = " + value );
            // Gives an error
        }
    }

    // Driver Class
    class Program
    {

        static void Main(string[] args)
        {
            Parent obj = new Parent();

            // obj.value = 5;
            // Also gives an error

            // Use public functions to assign
            // and use value of the member 'value'
            obj.setValue(4);
            Console.WriteLine("Value = " + obj.getValue());
        }
    }
}


