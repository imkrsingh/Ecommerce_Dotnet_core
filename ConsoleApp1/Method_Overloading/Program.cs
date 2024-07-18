

//Example.1 || Method Overloading | By changing the Number of Parameters 
/*
using System;
class GFG
{

    // adding two integer values.
    public int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    // adding three integer values.
    public int Add(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }

    // Main Method
    public static void Main(String[] args)
    {

        // Creating Object
        GFG ob = new GFG();

        int sum1 = ob.Add(1, 2);
        Console.WriteLine("sum of the two "
                        + "integer value : " + sum1);

        int sum2 = ob.Add(1, 2, 3);
        Console.WriteLine("sum of the three "
                        + "integer value : " + sum2);
    }
}
*/


//Example.2
/*
using System;
class GFG
{

    // adding three integer values.
    public int Add(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }

    // adding three double values.
    public double Add(double a, double b, double c)
    {
        double sum = a + b + c;
        return sum;
    }

    // Main Method
    public static void Main(String[] args)
    {

        // Creating Object
        GFG ob = new GFG();

        int sum2 = ob.Add(1, 2, 3);
        Console.WriteLine("sum of the three "
                        + "integer value : " + sum2);
        double sum3 = ob.Add(1.0, 2.0, 3.6);
        Console.WriteLine("sum of the three "
                        + "double value : " + sum3);
    }
}
*/


// Example.3 || By changing the Order of the parameters


