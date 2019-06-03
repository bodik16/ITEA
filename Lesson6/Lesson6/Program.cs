using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            AllFiles(@"C:\Users\Bogda\Documents\ITEA\Lesson6\Lesson6");
           // string path = @"C:\Users\Bogda\Documents\ITEA\Lesson6\Lesson6";

                // Set a variable to the My Documents path.
                //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            
            Console.ReadKey();

        }
        private static void AllFiles(string path)
        {
            List<string> dirs = new List<string>(Directory.EnumerateDirectories(path));
            List<string> Files = new List<string>(Directory.EnumerateFiles(path));
            foreach (var dir in dirs)
            {
                int i = 0;
                Console.WriteLine($"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) +1)}");
                Console.WriteLine($"{Files[i]}");
                ++i;
            }
         
            for (int i = 0; i < dirs.Count; i++)
            {
                AllFiles($@"{dirs[i]}");    
            }
           
        }
    }

}
