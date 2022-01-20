using System;
using System.IO;

namespace DirectoryDemo
{
    internal class Program
    {
        static void Main()
        {
            //string currentDir = Directory.GetCurrentDirectory();
            //Console.WriteLine(currentDir);
            //string directoryOne = @"\textfiles";
            ////string directoryOne = ConfigurationManager.AppSettings["directoryname"];
            //Directory.CreateDirectory(directoryOne);
            //Directory.CreateDirectory(@"textfiles_1");

            //if (Directory.Exists(@"DirOne"))
            //{
            //    Console.WriteLine("Directory allready exists!!!");
            //}
            //else
            //{
            //    Directory.CreateDirectory(@"DirOne");
            //}

            //string files1 = string.Join("\n", Directory.GetFiles(Directory.GetCurrentDirectory()));
            //Console.WriteLine(files1);
            string[] files = Directory.GetFiles(@"c:\windows");

            foreach (var item in files)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
