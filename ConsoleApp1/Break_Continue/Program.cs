// Break and Continue Keyword using in for loop

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    //break; // output will be 0, 1, 2, 3
                    continue; // output will be 0,1,2,3,5,6,7,8,9 // 4 is not here bcoz (i == 4)
                }
                Console.WriteLine(i);
            }
        }
    }
}




// Break and Continue Keyword using in while loop
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                   // break; // output will be 0, 1, 2, 3
                   continue; // output will be 0,1,2,3,5,6,7,8,9 // 4 is not here bcoz (i == 4)
                }
            }
        }
    }
}

*/