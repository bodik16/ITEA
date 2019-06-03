using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SeaFight2._0
{
    public partial class Form1 : Form
    {
        Point s;
        Graphics graphics;
        Pen a = new Pen(Color.Black, 1);
        //List<Rectangle> MyPlaces = new List<Rectangle>();
        public Form1()
        {
            InitializeComponent();
            graphics = MainPanel.CreateGraphics();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Board.FillPlace(graphics);
            for (int i = 0; i < Board.MyPlaces.Count; i++)
            {
                Places.Items.Add(Board.MyPlaces[i]);
            }
           
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            s = MainPanel.PointToClient(Cursor.Position);
            MousePosition.Text = Convert.ToString(s.X);
        }

        private void Places_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //Pen q = new Pen(Color.Red, 1);
            //graphics.DrawRectangle();
            ////for (int i = 0; i < Board.MyPlaces.Count; i++)
            ////{
            ////    graphics.DrawRectangle(q, Board.MyPlaces[].X, Board.MyPlaces[i].Y, Board.MyPlaces[i].Width, Board.MyPlaces[i].Height);
            ////}
        }
    }
}
