﻿
/*
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 25;
            int votingAge = 18;
            Console.WriteLine(myAge >= votingAge);  // returns True, meaning 25 year olds are allowed to vote!
        }
    }
}

*/


using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge = 25;
            int votingAge = 18;

            if (myAge >= votingAge)
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote.");
            }
        }
    }
}