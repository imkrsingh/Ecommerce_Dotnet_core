// Example.1 || Expression 
/*
namespace LearnExpression
{
    public delegate int MyDelegate(int num);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate obj = (a) => a * a;
            MyDelegate obj1 = (a) => a * a * a;
            Console.WriteLine(obj.Invoke(5));
            Console.WriteLine(obj1.Invoke(3));

            int cube = obj1.Invoke(5);  
            Console.WriteLine(cube);

            //MyDelegate obj = (a) =>
            //{
            //    a += 5;
            //    return a;
            //};

            //Console.WriteLine(obj(10));
            Console.ReadLine();
        }
    }
}
*/



// Example.2 || Expression Tree
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

class Program
{
    static void Main(String[] args)
    {
        Expression<Func<int, bool>> lambda = num => num < 5;
        bool result = lambda.Compile()(8);

        Console.WriteLine(result);
    }
}




