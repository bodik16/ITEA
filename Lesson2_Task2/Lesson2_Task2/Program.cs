using System;

namespace Lesson2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i <= 255)
            {
                Console.WriteLine(i + " = " + (char)i);

                i++;
            }
            //for (int i = 0; i < 255; i++)
            //{
            //    Console.WriteLine($"number: [{i}] = [{(char)i}]");
            //}
            //Console.ReadKey();
        }
    }
}
