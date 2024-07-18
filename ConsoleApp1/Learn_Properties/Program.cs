// Example.1
/*
using System;

namespace Learn_Properties
{
    class Student
    {
        private int _StdId;
        private string _Name;
        private string _Fname;

        public int StdId
        {
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Id cannot be zero or negative");
                }
                else
                {
                    this._StdId = value;
                }
            }
            get
            {
             return this._StdId;
            }
        }

        public string Name
        {
            set
            {
             if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter your name: ");
                }
                else
                {
                    this._Name = value; 
                }
            }
            get
            {
                return this._Name;   
            }
        }


        public string FName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please enter your Father name: ");
                }
                else
                {
                    this._Fname = value;
                }
            }
            get
            {
                return this._Fname;
            }
        }

        class Program 
        { 
        static void Main(string[] args)
        {
                Student s = new Student();
                s.StdId = 23;
                s.Name = "Manish";
                s.FName = "xyz";
                Console.WriteLine(s.StdId);
                Console.WriteLine(s.Name);
                Console.WriteLine(s.FName);
                Console.ReadLine(); 
                //Console.WriteLine("Hello World!");
            }
        }
    }
}
*/


//Example.2
/*
using System;

namespace Learn_Properties
{
    class Student
    {
        private int _StdId;
        private string _Name;
        private string _Fname;
        private int _SubjectTotalMarks = 100;
       

        public int StdId
        {
            set
            {
             this._StdId = value;
            }
            
        }
        public int SubjectTotalMarks
        {
            get
            {
                return this._SubjectTotalMarks;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Student s = new Student();
                Console.WriteLine(s.SubjectTotalMarks);
                s.StdId = 23;
                
                Console.ReadLine();
                //Console.WriteLine("Hello World!");
            }
        }
    }
}
*/


// Example.3 || Auto Implemented Property
using System;

namespace Learn_Properties
{
    class Student
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public Student(string fname, string lname)
        {
            firstName = fname;
            lastName = lname;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Student s = new Student("Manish", "kumar");
               // s.firstName = "Manish";

               // s.lastName = "Singh";

                Console.WriteLine(s.firstName + " " + s.lastName);

                Console.ReadLine();
                //Console.WriteLine("Hello World!");
            }
        }
    }
}


