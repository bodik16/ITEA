using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace parallel_lab4
{
    public partial class Form1 : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        public Pen firstPen = new Pen(Color.Black, 5);
        public Graphics graphicsFree;
        int count=1;
        public Form1()
        {
            InitializeComponent();
            graphicsFree = panel1.CreateGraphics();
            graphicsFree = FreePanel.CreateGraphics();
           
            firstPen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }

        private void Form1_2Animation()
        {
            Form1_2 f1_2 = new Form1_2();

            f1_2.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            new Thread(Form1_2Animation).Start();
        }


        private void Button5_Click(object sender, EventArgs e)
        {

            this.Width = this.Width + FreePanel.Width+20;
            this.Height = Height + 370;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if(comboBox1.Visible == false)
            {
                FreePanel.BackColor = Color.White;
                FreePanel.Invalidate();
            }
            else if (comboBox1.Text == "1")
            {
                FreePanel.BackColor = Color.White;
                FreePanel.Invalidate();
            }
            else if(comboBox1.Text == "2")
            {
                panel1.BackColor = Color.White;
                panel1.Invalidate();

            }
        }

        private void FreePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FreePanel_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                firstPen.Width = 2;
            }
            else if(textBox1.Text.Contains($"{0}") || textBox1.Text.Contains($"{1}")|| textBox1.Text.Contains($"{2}")|| textBox1.Text.Contains($"{3}")|| textBox1.Text.Contains($"{6}")|| textBox1.Text.Contains($"{7}")|| textBox1.Text.Contains($"{8}")|| textBox1.Text.Contains($"{9}")|| textBox1.Text.Contains($"{4}")|| textBox1.Text.Contains($"{5}"))
            {
                firstPen.Width = Convert.ToInt32(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Please, input some number");
            }
        }


        private void FreePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (comboBox1.Visible == false)
                {
                    graphicsFree = FreePanel.CreateGraphics();
                    current = e.Location;
                    graphicsFree.DrawLine(firstPen, old, current);
                    old = current;
                }
                else
                {
                    comboBox1.Visible = true;
                    if (comboBox1.Text == "1")
                    {
                        graphicsFree = FreePanel.CreateGraphics();
                        current = e.Location;
                        graphicsFree.DrawLine(firstPen, old, current);
                        old = current;
                    }
                   
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                firstPen.Color = cd.Color;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Form1_2 form1_2 = new Form1_2();
            form1_2.ShowDialog();
            //this.Height = 550;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Width = this.Width + FreePanel.Width + 10;
        }

        private void Button9_Click_1(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                if (comboBox1.Text == "1")
                {
                    FreePanel.BackColor = cd.Color;
                }
            else if(comboBox1.Text == "2")
                {
                    panel1.BackColor = cd.Color;
                }
        }

        private void ClickDrawButton_Click(object sender, EventArgs e)
        {
            ClickDrawForm a = new ClickDrawForm();
            a.ShowDialog();
            
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            SavePicture savePicture = new SavePicture();
            savePicture.ShowDialog();
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
              
                  
                     if (comboBox1.Text == "2")
                    {
                        graphicsFree = panel1.CreateGraphics();
                        current = e.Location;
                        graphicsFree.DrawLine(firstPen, old, current);
                        old = current;
                    }
                
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            count++;
            comboBox1.Visible = true;
            panel1.Visible = true;
            this.Width += FreePanel.Width+10;
            comboBox1.Items.Add(count);
            //comboBox1.Location.X = comboBox1.Location.X + FreePanel.Width;
        }

        private void Button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.Width = button5.Width + 200-button5.Width;
        }

        private void Button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Width = button5.Width - button5.Width + 160;   
        }


        private void ClickDrawButton_MouseMove(object sender, MouseEventArgs e)
        {
            ClickDrawButton.Width = button5.Width + 200 - button5.Width;
        }

        private void ClickDrawButton_MouseLeave(object sender, EventArgs e)
        {
            ClickDrawButton.Width = button5.Width - button5.Width + 160;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "1")
            {
                label1.BackColor = Color.Lime;
                label3.BackColor = Color.WhiteSmoke;
            }
            else if (comboBox1.Text == "2")
            {
                label3.BackColor = Color.Lime;
                label1.BackColor = Color.WhiteSmoke;

            }

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                firstPen.Width = 2;
            }
            else
            {
                firstPen.Width = Convert.ToInt32(textBox1.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.ReadOnly = true;
            textBox1.Text = Convert.ToString(trackBar1.Value);
           
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
