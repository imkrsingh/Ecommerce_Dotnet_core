// Example.1 || C# program to illustrate encapsulation
/*
using System;

public class DemoEncap
{

    // private variables declared
    // these can only be accessed by
    // public methods of class
    private String studentName;
    private int studentAge;

    // using accessors to get and
    // set the value of studentName
    public String Name
    {

        get { return studentName; }

        set { studentName = value; }
    }

    // using accessors to get and
    // set the value of studentAge
    public int Age
    {

        get { return studentAge; }

        set { studentAge = value; }
    }
}

// Driver Class
class GFG
{

    // Main Method
    static public void Main()
    {

        // creating object
        DemoEncap obj = new DemoEncap();

        // calls set accessor of the property Name,
        // and pass "Manish" as value of the
        // standard field 'value'
        obj.Name = "Manish Singh ";

        // calls set accessor of the property Age,
        // and pass "21" as value of the
        // standard field 'value'
        obj.Age = 21;

        // Displaying values of the variables
        Console.WriteLine(" Name : " + obj.Name);
        Console.WriteLine(" Age : " + obj.Age);
    }
}
*/


// Example.2 
/*
class A
{
    private int atmPIN;

    public int getReturn()
    {
       return atmPIN;
    }
    public void setValue(int pin)
    {
        atmPIN = pin;
    }
}

class B
{
    public static void Main(String[] args)
    {
        A r = new A();
        r.setValue(4567);
        Console.WriteLine("ATM PIN " + r.getReturn());
    }
}
*/



// Example.3
namespace LearnEncapsulation { 
    class Account
     {
        private int accountBalance = 1000;

        public void SetBalance(int amount)
        {
            accountBalance = amount;
        }
        public void GetBalance()
        {
            Console.WriteLine("Your Account Balance is: " + accountBalance);
        }
     }
    class Program
     {
    static void Main(string [] args)
    {
      Account myAccount = new Account();
            // myAccount.accountBalance = 100;
            myAccount.SetBalance(10000);
            myAccount.GetBalance();
            Console.ReadLine();
    }
}
}

