// Example.1 || Method Overloading
/*
using System;

class Program
{
    public void Add()
    {
        int a = 20;
        int b = 30;
        int c = a + b;
        Console.WriteLine(c);
    }
    public void Add(int a, int b)
    {
        int c = a + b;
        Console.WriteLine(c);
    }
    public void Add(string a, string b)
    {
        string c = a + " " + b;
        Console.WriteLine(c);
    }
    public void Add(float a, float b)
    {
        float c = a + b;
        Console.WriteLine(c);
    }

    static void Main(string[] args)
    {
        Program p = new Program();
        p.Add();
        p.Add("Manish", "Singh");
        p.Add(2.5f, 1.6f);
        p.Add(10,5);
        Console.ReadLine();


    }
}
*/


// Example.1 || Polymorphism 
// Now we can create Pig and Dog objects and call the animalSound() method on both of them:
/*
class Animal  // Base class (parent) 
{
    public void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class (child) 
{
    public void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();  // Create a Animal object
        Animal myPig = new Pig();  // Create a Pig object
        Dog myDog = new Dog();  // Create a Dog object

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
    }
}
*/



// Example.2 || Polymorphism 
using System;

namespace MyApplication
{
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {   
            
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}



