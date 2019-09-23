using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parallel_lab4
{
    public  class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public  int Width { get; set; }
        public  int Height { get; set; }
        public string Name { get; set; }

        public Shape(int x, int y, int w, int h, string n)
        {
            X = x;
            Y = y;
            Width = w;
            Height = h;
            Name = n;
        }
    }
}
