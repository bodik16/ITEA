using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DataTypes_FirstProgetc
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            char b;
            char c;
            WriteLine("Input first letter: ");

            a = Convert.ToChar(ReadLine());

            WriteLine("Input second letter: ");

            b = Convert.ToChar(ReadLine());

            WriteLine("Input third letter: ");

            c = Convert.ToChar(ReadLine());

            WriteLine($"{c} -> {b} -> {a}");
            ReadKey();
        }
    }
}
