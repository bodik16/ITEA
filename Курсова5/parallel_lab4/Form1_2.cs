using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace parallel_lab4
{ 

        public partial class Form1_2 : Form
    {
        //Ellipse ellipse = new Ellipse();
        Rectangle rectangle = new Rectangle();
        Point pointXY = new Point();
        Point pointX1Y1 = new Point();
        bool IsMouseDown = false;
        private Graphics graphics;
        Pen ShapesPen = new Pen(Color.Red);

        List<Rectangle> Rectangless = new List<Rectangle>();
        List<Rectangle> Squares = new List<Rectangle>();
        public Form1_2()
        {
            InitializeComponent();
            graphics = panel1.CreateGraphics();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                ShapesPen.Color = cd.Color;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            pointXY = e.Location;
            if (radioButton7.Checked)
                ShapesPen.Width = 1;
            if (radioButton9.Checked)
                ShapesPen.Width = 3;
            if (radioButton10.Checked)
                ShapesPen.Width = 4;
            if (radioButton11.Checked)
                ShapesPen.Width = 10;
            if (radioButton12.Checked)
                ShapesPen.Width = 30;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(IsMouseDown != true)
            {
                pointX1Y1 = e.Location;
                Refresh();
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if(IsMouseDown = true)
            {
                pointX1Y1 = e.Location;
                IsMouseDown = false;
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {





                textBox1.Enabled = false;
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Red;
                ShapesPen.Width = trackBar1.Value;
                textBox1.Text = Convert.ToString(trackBar1.Value);

            if (radioButton7.Checked)
                e.Graphics.DrawEllipse(ShapesPen, Math.Min(pointXY.X, pointX1Y1.X)- Math.Abs(pointXY.X - pointX1Y1.X)/2, Math.Min(pointXY.Y, pointX1Y1.Y)- Math.Abs(pointXY.X - pointX1Y1.X)/2, Math.Abs(pointXY.X - pointX1Y1.X), Math.Abs(pointXY.X - pointX1Y1.X));
                if (radioButton9.Checked)
                    e.Graphics.DrawRectangle(ShapesPen, GetSquare());
                if (radioButton10.Checked)
                    e.Graphics.DrawRectangle(ShapesPen, GetRect());
            if (radioButton11.Checked)
                e.Graphics.DrawLine(ShapesPen, pointXY, pointX1Y1);
                if (radioButton12.Checked)
                    e.Graphics.DrawEllipse(ShapesPen, Math.Min(pointXY.X, pointX1Y1.X)- Math.Abs(pointXY.X - pointX1Y1.X)/2, Math.Min(pointXY.Y, pointX1Y1.Y)- Math.Abs(pointXY.Y - pointX1Y1.Y)/2, Math.Abs(pointXY.X - pointX1Y1.X), Math.Abs(pointXY.Y - pointX1Y1.Y) );
            
        }
        private Rectangle GetRect()
        {
            rectangle = new Rectangle();
            rectangle.X = Math.Min(pointXY.X, pointX1Y1.X);
            rectangle.Y = Math.Min(pointXY.Y, pointX1Y1.Y);
            rectangle.Width = Math.Abs(pointXY.X - pointX1Y1.X);
            rectangle.Height = Math.Abs(pointXY.Y - pointX1Y1.Y);
            return rectangle;
            //Rectangless.Add(rectangle);
        }
        private Rectangle GetSquare()
        {
            rectangle = new Rectangle();
            rectangle.X = Math.Min(pointXY.X, pointX1Y1.X);
            rectangle.Y = Math.Min(pointXY.Y, pointX1Y1.Y);
            rectangle.Width = Math.Abs(pointXY.X - pointX1Y1.X);
            rectangle.Height = rectangle.Width;
            return rectangle;
            Squares.Add(rectangle);
            
        }


        private void Button2_Click_1(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
         
        }

        private void ListOfShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           this.Height = 700;
        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }

        private void Form1_2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListOfShapes.Items.Add($"->" + $"-{rectangle.Width}|" + $"|-{rectangle.Height}|" + $"|{pointXY.X - rectangle.Width / 2}|" + $"|{pointXY.Y - rectangle.Height / 2}");

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            ShapesPen.Width = trackBar1.Value;
            //TrackBar trackBar = new TrackBar();
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            ShapesPen.Width = trackBar1.Value;
        }
    }
}
