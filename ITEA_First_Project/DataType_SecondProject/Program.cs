using System;

namespace DataType_SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int width;
            Console.Write("Input Width of the Arr: ");
            width = Convert.ToInt32(Console.ReadLine());
            int value;
            int H = width;
            Console.Write("Input Value of the Arr: ");
            value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j <width;  j++)
                {
                    Console.Write($"{value}");
                }
                Console.WriteLine();
                width--;
                
            }
            Console.ReadKey();
        }
    }
}


