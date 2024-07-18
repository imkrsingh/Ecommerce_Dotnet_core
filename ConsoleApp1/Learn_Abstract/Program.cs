// Example.1 || Abstract Class
/*
using System;

namespace MyApplication
{
    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
            myPig.sleep();
        }
    }
}
*/


// Example.2 || Abstract Class
/*
using System;

namespace ABSTRACT_CLASS
{
    abstract class Person
    {
        public string FirstName;
        public string LastName;
        public int age;
        public string PhoneNumber;

        public abstract void PrintDetails();
    }
    class student : Person
    {
        public int RollNo;
        public int Fees;

        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Student Name Is: {0}", name);
            Console.WriteLine("Student Age Is: {0}", this.age);
            Console.WriteLine("Student Phone number Is: {0}", this.PhoneNumber);
            Console.WriteLine("Student Roll No. Is: {0}", this.RollNo);
            Console.WriteLine("Student Fees Is: {0}", this.Fees);
        }
    }
    class teacher : Person
    {
        public string qualification;
        public int salary;

        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Teacher Name Is: {0}", name);
            Console.WriteLine("Teacher Age Is: {0}", this.age);
            Console.WriteLine("Teacher Phone number Is: {0}", this.PhoneNumber);
            Console.WriteLine("Teacher Qualification Is: {0}", this.qualification);
            Console.WriteLine("Teacher Salary Is: {0}", this.salary);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             student Manish = new student();
            Manish.FirstName = "Manish";
            Manish.LastName = "Singh";
            Manish.age = 25;
            Manish.PhoneNumber = "0123456789";
            Manish.RollNo = 10;
            Manish.Fees = 50000;
            Manish.PrintDetails();
            

            Console.WriteLine("________________________________________");

            teacher Asad = new teacher();
            Asad.FirstName = "Asad";
            Asad.LastName = "Mughal";
            Asad.age = 63;
            Asad.PhoneNumber = "7894561230";
            Asad.qualification = "M.Tech";
            Asad.salary = 30000;
            Asad.PrintDetails();
            Console.ReadLine(); 
        }
    }
}
*/



//Example.3 || Abstract Class
using System;

namespace ABSTRACT_CLASS
{
    abstract class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected int _age;
        protected string _phoneNumber;

        protected Person(string firstName, string lastName, int age, string phoneNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _phoneNumber = phoneNumber;
        }
        /*
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        */
        public abstract void PrintDetails();

        protected void Print(string message)
        {
            Console.WriteLine(message);
        }
    }

    class student : Person
    {
        public int RollNo;
        public int Fees;

        public student(string firstName, string lastName, int age, string phoneNumber, int rollNo, int fees):base(firstName, lastName, age, phoneNumber)    
        {
           /* FirstName = firstName;
            LastName = lastName;
            Age = age;
            PhoneNumber = phoneNumber;*/
            RollNo = rollNo;
            Fees = fees;
        }

        public override void PrintDetails()
        {
            string name = _firstName + " " + _lastName;
            Print("Student Name Is: " + name);
            Print("Student Age Is: " + _age);
            Print("Student Phone number Is: " + _phoneNumber);
            Print("Student Roll No. Is: " + RollNo);
            Print("Student Fees Is: " + Fees);
        }
    }

    class teacher : Person
    {
        public string Qualification;
        public int Salary;

        public teacher(string firstName, string lastName, int age, string phoneNumber, string qualification, int salary) : base(firstName, lastName, age, phoneNumber)
        {
           /* FirstName = firstName;
            LastName = lastName;
            Age = age;
            PhoneNumber = phoneNumber;*/
            Qualification = qualification;
            Salary = salary;
        }

        public override void PrintDetails()
        {
            string name = _firstName + " " + _lastName;
            Print("Teacher Name Is: " + name);
            Print("Teacher Age Is: " + _age);
            Print("Teacher Phone number Is: " + _phoneNumber);
            Print("Teacher Qualification Is: " + Qualification);
            Print("Teacher Salary Is: " + Salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            student Manish = new student("Maniishhh", "Singh", 25, "0123456789", 10, 50000);
            Manish.PrintDetails();

            Console.WriteLine("___________________________________________________________");

            teacher Asad = new teacher("Asssaad", "Mughal", 63, "07894561230", "M.Tech", 30000);
            Asad.PrintDetails();

            Console.ReadLine();
        }
    }
}






