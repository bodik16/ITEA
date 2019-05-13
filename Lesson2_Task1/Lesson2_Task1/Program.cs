using System;
using System.IO;

namespace Lesson2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello, my dear friend";
        
            int countWords = word.Split().Length;
            Console.WriteLine($"Count: {countWords}");
            Console.ReadKey();



            string ourText = File.ReadAllText("C:\\Users\\Bogda\\Documents\\ITEA\\OurText.txt");
            int countWordsFromTXT = ourText.Split().Length;
            Console.WriteLine($"Count from .txt file: {countWordsFromTXT}");
            Console.ReadKey();

        }

    }
}
