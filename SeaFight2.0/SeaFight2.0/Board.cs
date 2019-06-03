using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaFight2._0
{
     static class Board
    {
       public static List<Rectangle> MyPlaces = new List<Rectangle>();
       // private static Pen a;
        

        public static void FillPlace(Graphics graphicss)
        {
            Pen a = new Pen(Color.Black, 1);
                int t = 0;
                for (int i = 0; i < 10; i++)
                {
                    int y = 0;
                    for (int j = 0; j < 10; j++)
                    {
                        graphicss.DrawRectangle(a, y, t, 35, 35);
                        y = y + 37;
                        MyPlaces.Add(new Rectangle(y, t, 35, 35));
                    }
                    t = t + 37;
                }
        }
    }
}
