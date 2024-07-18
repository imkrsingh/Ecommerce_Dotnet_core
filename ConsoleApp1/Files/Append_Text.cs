//////////////////////////  File Handling  /////////////////////////


// Example.1 || Checking if a File Exist or Not
/*
using System;
using System.IO;

namespace FileHandling


{
    class FileHaandling
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\manis\source\repos\ConsoleApp1\Files\File.txt";  // ==> '@' it's a verbatim literal
            if (File.Exists(path))
            {
                Console.WriteLine("Yes there is a files...");
            }
            else
            {
                Console.WriteLine("File not Found");
            }
            Console.ReadLine();
        }
    }
}
*/



// Example.2 || Reading Data From Text File
/*
using System;

namespace FileHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\\manis\\source\\repos\\ConsoleApp1\\Files\\File.txt";   
            if(File.Exists(path))
            {
                  Console.WriteLine("File Found...");
                  string data = File.ReadAllText(path);
                  Console.WriteLine(data);
            }
            else
            {
                  Console.WriteLine("File Not Found...");
            }
            Console.ReadLine();
        }
    }
}
*/



// Example.3 || How to Create a copy of a File in C#
/*
using System;

namespace FileHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\data.txt";
            string path2 = @"F:\data1.txt";
            File.Copy(path, path2, true);
            Console.ReadLine();
        }
    }
}
*/



// Example.4 || Directory Info Class
using System;
using System.IO;

namespace DirectoryInfoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"G:\My Directory";
            string path2 = @"G:\My Directory 2";
            string path3 = @"G:\new";

            DirectoryInfo dir = new DirectoryInfo(path3);
            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.FullName);
            Console.WriteLine(dir.LastAccessTime);
            Console.WriteLine(dir.CreationTime);
            Console.WriteLine(dir.Attributes);
            Console.WriteLine(dir.Parent);
            Console.WriteLine(dir.Root);
            Console.WriteLine(dir.LastWriteTime);

            //DirectoryInfo[] dirs = dir.GetDirectories();

            //foreach (var item in dirs)
            //{
            //     Console.WriteLine(item.GetFiles().Length);
            //}
            // dir.Delete(true);
            //dir.MoveTo(path2);
            //dir.Create();
            //dir.CreateSubdirectory("Another Directory");

            //Console.WriteLine("Directory Created...");
            //Console.WriteLine("Directory Moved...");
            //Console.WriteLine("Directory Deleted...");
            Console.ReadLine();
        }
    }
}









