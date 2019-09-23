using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace parallel_lab4
{
    public partial class ClickDrawForm : Form
    {
        Rectangle CutRectangle = new Rectangle();
        public Point current = new Point();
        public Point old = new Point();
        Image File;
        Graphics ClickGraphic;
        bool IsMouseDown = false;
        Pen ClickPen;
        Point cursor;
        int k = 0;
        int r = 0;
        int q = 0;
        Point[] points = new Point[100000];
        List<Rectangle> AllShapes = new List<Rectangle>();

        List<Rectangle> CutShapes = new List<Rectangle>();
        Rectangle[] Shapess = new Rectangle[100000];
        //Rectangle[] Shapess1 = new Rectangle[10];

        public int BackX;
        public int BackY;

        public int BackWidth;
        public int BackHeight;

        public int[] Backsomeshape = new int[4];

        List<Shape> shapesTOSave = new List<Shape>();
        public ClickDrawForm()
        {
            InitializeComponent();
            ClickGraphic = ClickDrawPanel.CreateGraphics();
            ClickPen = new Pen(Color.Black, 3);
            ClickPen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }

        private void ClickDrawForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseButtonClickDrawing_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ClearButtonClickDrawing_Click(object sender, EventArgs e)
        {
            ClickDrawPanel.Invalidate();
            
            checkedListBox1.Items.Clear();
            //ClickDrawPanel.BackColor = Color.White;
            //ClickDrawPanel.Invalidate();
            //ClickDrawPanel.Controls.Clear();
            //ClickDrawPanel.Controls.Add();
            //ClickGraphic.Clear(Color.White);
            //ClickGraphic.Clear(Color.Red);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                ClickPen.Color = cd.Color;
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < Rectangles.Count; ++i)
            //{
            //    if (Rectangles[i].X == Convert.ToInt32(checkedListBox1.CheckedItems))
            //    {
            //        ClickGraphic.DrawRectangle(new Pen(Color.Red, 2), Rectangles[i].X, Rectangles[i].Y, 20, 20);
            //    }
            //}


            label7.Text = Convert.ToString(checkedListBox1.Items.Count);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < Rectangles.Count; ++i)
            //{
            //    if (Rectangles[i].X == Convert.ToInt32(checkedListBox1.Text))
            //    {
            //        ClickGraphic.DrawRectangle(new Pen(Color.Red, 2), Rectangles[i].X, Rectangles[i].Y, 30, 20);
            //    }
            //}
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                //ClickPen.Width = Convert.ToInt32(textBox1.Text);
                if (String.IsNullOrWhiteSpace(textBox1.Text))
                {
                    ClickPen.Width = 1;
                }
                else
                {
                    ClickPen.Width = Convert.ToInt32(textBox1.Text);
                }
                if (RadioButtonCircleClick.Checked)
                {
                   // int q = 0;
                    ClickGraphic.DrawEllipse(ClickPen, Convert.ToInt32(Xpoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Ypoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapewidth.Text));
                    points[k++] = new Point(Convert.ToInt32(Xpoint.Text), Convert.ToInt32(Ypoint.Text));
                    checkedListBox1.Items.Add("X: " + Convert.ToInt32(Xpoint.Text) + "Y: " + Convert.ToInt32(Ypoint.Text) + "Circle");
                    shapesTOSave.Add(new Shape(Convert.ToInt32(Xpoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Ypoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapewidth.Text), "Circle"));

                }


                if (RadioButtonEllipseClick.Checked)
                {
                    ClickGraphic.DrawEllipse(ClickPen, Convert.ToInt32(Xpoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Ypoint.Text) - Convert.ToInt32(Shapeheight.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapeheight.Text));
                    points[k++] = new Point(Convert.ToInt32(Xpoint.Text), Convert.ToInt32(Ypoint.Text));
                    checkedListBox1.Items.Add("X: " + Convert.ToInt32(Xpoint.Text) + "Y: " + Convert.ToInt32(Ypoint.Text) + "--Ellipse");
                    shapesTOSave.Add(new Shape(Convert.ToInt32(Xpoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Ypoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapeheight.Text), "Ellipse"));

                }



                if (RadioButtonRectangleClick.Checked)
                {
                    ClickGraphic.DrawRectangle(ClickPen, Convert.ToInt32(Xpoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Ypoint.Text) - Convert.ToInt32(Shapeheight.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapeheight.Text));
                    points[k++] = new Point(Convert.ToInt32(Xpoint.Text), Convert.ToInt32(Ypoint.Text));
                    checkedListBox1.Items.Add("X: " + Convert.ToInt32(Xpoint.Text) + "Y: " + Convert.ToInt32(Ypoint.Text) + "--Rectangle");
                    shapesTOSave.Add(new Shape(Convert.ToInt32(Xpoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Ypoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapeheight.Text), "Rectangle"));

                    //Rectangles.Add(new Rectangle(Convert.ToInt32(Xpoint.Text), Convert.ToInt32(Ypoint.Text), 30, 20));
                }

                if (RadioButtonSquareClick.Checked)
                {
                    //Shapeheight.Enabled = true;
                    Shapeheight.ReadOnly = true;
                    ClickGraphic.DrawRectangle(ClickPen, Convert.ToInt32(Xpoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Ypoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapewidth.Text));
                    //Rectangle rectangle = new Rectangle(Convert.ToInt32(Xpoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Ypoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapewidth.Text));
                    // Rectangles.Add(rectangle);
                    //textBox2.Text = rectangle.ToString();
                    //Shapess[r++] = new Rectangle(Convert.ToInt32(Xpoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Ypoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapewidth.Text));
                    points[k++] = new Point(Convert.ToInt32(Xpoint.Text), Convert.ToInt32(Ypoint.Text));
                    checkedListBox1.Items.Add("X: " + Convert.ToInt32(Xpoint.Text) + "Y: " + Convert.ToInt32(Ypoint.Text) + "--Square");
                    shapesTOSave.Add(new Shape(Convert.ToInt32(Xpoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Ypoint.Text) - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapewidth.Text), "Square"));


                }

            }
            catch
            {
                MessageBox.Show("Введіть коректні X та Y");
            }
        }

        private void ClickDrawForm_MouseClick(object sender, MouseEventArgs e)
        {
            //Xposition.Text = Convert.ToString(ClickDrawPanel.Location.X);
            //Yposition.Text = Convert.ToString(ClickDrawPanel.Location.Y);
            //Yposition.Text = Convert.ToString(MousePosition.Y);
        }

        private void ClickDrawPanel_MouseMove_1(object sender, MouseEventArgs e)
        {

            //ClickDrawPanel.Size = this.ClickDrawPanel.Size;
            //ClickDrawPanel.Width = this.ClickDrawPanel.Width;

            if (checkBox1.Checked)
            {
                if (IsMouseDown != true)
                {
                    old = e.Location;
                    Refresh();
                }
            }
            else
            {
                cursor = ClickDrawPanel.PointToClient(Cursor.Position);
                Xposition.Text = Convert.ToString(cursor.X);
                Yposition.Text = Convert.ToString(cursor.Y);
                if (FreeDrawingCheck.Checked)
                {
                    //Drawcheck.Enabled = false;
                    //LoopCheck.Enabled = false;
                    if (e.Button == MouseButtons.Left)
                    {

                        ClickGraphic = ClickDrawPanel.CreateGraphics();
                        current = e.Location;
                        ClickGraphic.DrawLine(ClickPen, old, current);
                        old = current;

                        comboBox1.Visible = true;
                        if (comboBox1.Text == "1")
                        {
                            ClickGraphic = ClickDrawPanel.CreateGraphics();
                            current = e.Location;
                            ClickGraphic.DrawLine(ClickPen, old, current);
                            old = current;
                        }


                    }
                }
            }
         
        }

        private void ClickDrawPanel_MouseClick_1(object sender, MouseEventArgs e)
        {

            int countHsapes = checkedListBox1.Items.Count;
            label8.Text = Convert.ToString(countHsapes+1);
            label8.Font = new Font(Convert.ToString(countHsapes+1), 60);
            //label8.Text = Convert.ToString(checkedListBox1.Items.Count);
            try
            {
                Random R = new Random();

            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                ClickPen.Width = 1;
            }
            else
            {
                ClickPen.Width = Convert.ToInt32(textBox1.Text);
            }

            if (checkBox1.Checked)
            {
                    Panel panel = new Panel();
                    panel.Height = CutRectangle.Height;
                    panel.Width = CutRectangle.Width;
                    //panel.Location.X = CutRectangle.X;
                    panel.BackColor = Color.Black;
                    Graphics graphicss;
                    graphicss = panel.CreateGraphics();
                    graphicss.DrawRectangle(ClickPen, CutRectangle);

                }
            else
            {
                if (Drawcheck.Checked)
                {

                    if (RadioButtonEllipseClick.Checked)
                        { 
                        //Shapeheight.Enabled = true;
                        ClickDrawPanel.Width = this.ClickDrawPanel.Width;
                        ClickDrawPanel.Height = this.ClickDrawPanel.Height;
                        ClickGraphic.DrawEllipse(ClickPen, cursor.X - Convert.ToInt32(Shapewidth.Text) / 2, cursor.Y - Convert.ToInt32(Shapeheight.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapeheight.Text));

                        Backsomeshape[0] = cursor.X - Convert.ToInt32(Shapewidth.Text) / 2;
                        Backsomeshape[1] = cursor.Y - Convert.ToInt32(Shapeheight.Text) / 2;
                        Backsomeshape[2] = Convert.ToInt32(Shapewidth.Text);
                        Backsomeshape[3] = Convert.ToInt32(Shapeheight.Text);
                        shapesTOSave.Add(new Shape(cursor.X - Convert.ToInt32(Shapewidth.Text) / 2, cursor.Y - Convert.ToInt32(Shapeheight.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapeheight.Text), "Ellipse"));
                        points[k++] = new Point(cursor.X, cursor.Y);
                        checkedListBox1.Items.Add($"X: {cursor.X}" + $"-Y: {cursor.Y}" + "--Ellipse");
                       
                    }

                    if (RadioButtonCircleClick.Checked)
                    {
                        //Shapeheight.Enabled = false;
                        ClickGraphic.DrawEllipse(ClickPen, cursor.X - Convert.ToInt32(Shapewidth.Text) / 2, cursor.Y - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapewidth.Text));

                        points[k++] = new Point(cursor.X, cursor.Y);
                        checkedListBox1.Items.Add($"X: {cursor.X}" + $"-Y: {cursor.Y}" + "--Circle");
                        Backsomeshape[0] = cursor.X - Convert.ToInt32(Shapewidth.Text) / 2;
                        Backsomeshape[1] = cursor.Y - Convert.ToInt32(Shapewidth.Text) / 2;
                        Backsomeshape[2] = Convert.ToInt32(Shapewidth.Text);
                        Backsomeshape[3] = Convert.ToInt32(Shapewidth.Text);
                        shapesTOSave.Add(new Shape(cursor.X - Convert.ToInt32(Shapewidth.Text) / 2, cursor.Y - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapewidth.Text), "Circle"));

                        }
                        if (RadioButtonRectangleClick.Checked)
                    {
                        Rectangle rectangle = new Rectangle(cursor.X - Convert.ToInt32(Shapewidth.Text) / 2, cursor.Y - Convert.ToInt32(Shapeheight.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapeheight.Text));
                        ClickGraphic.DrawRectangle(ClickPen, cursor.X - Convert.ToInt32(Shapewidth.Text) / 2, cursor.Y - Convert.ToInt32(Shapeheight.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapeheight.Text));
                        points[k++] = new Point(cursor.X, cursor.Y);
                        checkedListBox1.Items.Add($"X: {cursor.X }" + $"-Y: {cursor.Y}" + "--Rectangle");
                        //checkedListBox1.Items.Add(rectangle);
                        //Rectangles.Add(new Rectangle(cursor.X - 15, cursor.Y - 10, 30, 20));
                        Backsomeshape[0] = cursor.X - Convert.ToInt32(Shapewidth.Text) / 2;
                        Backsomeshape[1] = cursor.Y - Convert.ToInt32(Shapeheight.Text) / 2;
                        Backsomeshape[2] = Convert.ToInt32(Shapewidth.Text);
                        Backsomeshape[3] = Convert.ToInt32(Shapeheight.Text);
                          AllShapes.Add(rectangle);
                        shapesTOSave.Add( new Shape(cursor.X - Convert.ToInt32(Shapewidth.Text) / 2, cursor.Y - Convert.ToInt32(Shapeheight.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapeheight.Text), "Rectangle"));
                    }


                    if (RadioButtonSquareClick.Checked)
                    {
                        Rectangle rectangle = new Rectangle(cursor.X - Convert.ToInt32(Shapewidth.Text) / 2, cursor.Y - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapewidth.Text));
                        ClickGraphic.DrawRectangle(ClickPen, cursor.X - Convert.ToInt32(Shapewidth.Text) / 2, cursor.Y - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapewidth.Text));
                        points[k++] = new Point(cursor.X, cursor.Y);
                        checkedListBox1.Items.Add($"X: {cursor.X }" + $"-Y: {cursor.Y}" + "--Square");
                        // Shapess1[q++] = rectangle;
                            //ClickGraphic.DrawRectangle(ClickPen, rectangle);
                        Backsomeshape[0] = cursor.X - Convert.ToInt32(Shapewidth.Text) / 2;
                        Backsomeshape[1] = cursor.Y - Convert.ToInt32(Shapewidth.Text) / 2;
                        Backsomeshape[2] = Convert.ToInt32(Shapewidth.Text);
                        Backsomeshape[3] = Convert.ToInt32(Shapewidth.Text);
                            AllShapes.Add(rectangle);
                            //checkedListBox1.Items.Add(AllShapes.Count);
                            shapesTOSave.Add(new Shape(cursor.X - Convert.ToInt32(Shapewidth.Text) / 2, cursor.Y - (Convert.ToInt32(Shapeheight.Text) / 2), Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapewidth.Text), "Rectangle"));
                            //Shapeheight.Text = "0";
                        }

                    }

                if (LoopCheck.Checked == true)
                {

                    for (int i = 0; i < R.Next(0, ClickDrawPanel.Width + ClickDrawPanel.Height); i++)
                    {
                        int w = R.Next(0, ClickDrawPanel.Width);
                        int h = R.Next(0, ClickDrawPanel.Height);
                        if (RadioButtonCircleClick.Checked)
                        {

                            ClickGraphic.DrawEllipse(ClickPen, w - Convert.ToInt32(Shapewidth.Text) / 2, h - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapewidth.Text));
                            points[k++] = new Point(w, h);
                            //checkedListBox1.Items.Add("X: " + $"{cursor.X - R.Next(0, ClickDrawPanel.Width)}" + "Y: " + cursor.Y - R.Next(0, ClickDrawPanel.Height));
                            checkedListBox1.Items.Add($"X: {w}" + $"-Y: {h}" + "--Circle");
                        }


                        if (RadioButtonEllipseClick.Checked)
                        {
                            ClickGraphic.DrawEllipse(ClickPen, w - Convert.ToInt32(Shapewidth.Text) / 2, h - Convert.ToInt32(Shapeheight.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapeheight.Text));
                            points[k++] = new Point(w, h);
                            checkedListBox1.Items.Add($"X: {w}" + $"-Y: {h}" + "--Ellipse");
                        }

                        if (RadioButtonRectangleClick.Checked)
                        {
                            // Brush brush;

                            ClickGraphic.DrawRectangle(ClickPen, w - Convert.ToInt32(Shapewidth.Text) / 2, h - Convert.ToInt32(Shapeheight.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapeheight.Text));
                            points[k++] = new Point(w, h);
                            checkedListBox1.Items.Add($"X: { w }" + $"-Y: { h  }" + "--Rectangle");
                            //ClickGraphic.FillRectangle(brush, w - Convert.ToInt32(Shapewidth.Text) / 2, h - Convert.ToInt32(Shapeheight.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapeheight.Text));
                        }

                        if (RadioButtonSquareClick.Checked)
                        {
                            ClickGraphic.DrawRectangle(ClickPen, w - Convert.ToInt32(Shapewidth.Text) / 2, h - Convert.ToInt32(Shapewidth.Text) / 2, Convert.ToInt32(Shapewidth.Text), Convert.ToInt32(Shapewidth.Text));
                            points[k++] = new Point(w, h);
                            checkedListBox1.Items.Add($"X: {w}" + $"-Y: { h}" + "--Square");

                            //}

                        }
                    }
                }




            }
        }
            catch
            {
                MessageBox.Show("Введіть коректні Width та Height!");
            }
        }
                       
    private void Button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Open")
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "JPG(*.JPG)|*.jpg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File = Image.FromFile(openFileDialog.FileName);
                    //ClickDrawPanel.Image = File;
                    ClickDrawPanel.BackgroundImage = File;
                }
            }
            else if (comboBox1.Text == "Save")
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "JPG(*.JPG)|*.jpg|Bitmap|*.bmp|Gif|*.gif|JPEG(*.JPEG)|*.jpeg";

               

                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    if (checkBox1.Checked)
                    {
                        dialog.Filter = "JPG(*.JPG)|*.jpg|Bitmap|*.bmp|Gif|*.gif|JPEG(*.JPEG)|*.jpeg";
                        int width = Convert.ToInt32(CutShapes[0].Width);
                        int height = Convert.ToInt32(CutShapes[0].Height);
                        Bitmap bmp = new Bitmap(width, height);
                        ClickDrawPanel.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                        bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                    }
                    else
                    {
                        dialog.Filter = "JPG(*.JPG)|*.jpg|Bitmap|*.bmp|Gif|*.gif|JPEG(*.JPEG)|*.jpeg";
                        int width = Convert.ToInt32(ClickDrawPanel.Width);
                        int height = Convert.ToInt32(ClickDrawPanel.Height);
                        Bitmap bmp = new Bitmap(width, height);
                        ClickDrawPanel.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                        bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                    }
                }
                //}
            }
        }

        //private void ConstructFromResourceSaveAsGif(PaintEventArgs e)
        //{

        //    // Construct a bitmap from the button image resource.
        //    Bitmap bmp1 = new Bitmap(typeof(Button), "Button.bmp");

        //    // Save the image as a GIF.
        //    bmp1.Save("c:\\button.gif", System.Drawing.Imaging.ImageFormat.Jpeg);

        //    // Construct a new image from the GIF file.
        //    Bitmap bmp2 = new Bitmap("c:\\button.gif");

        //    // Draw the two images.
        //    e.Graphics.DrawImage(bmp1, new Point(10, 10));
        //    e.Graphics.DrawImage(bmp2, new Point(10, 40));

        //    // Dispose of the image files.
        //    bmp1.Dispose();
        //    bmp2.Dispose();
        //}
        private void ClickDrawPanel_Paint(object sender, PaintEventArgs e)
        {
            if (checkBox1.Checked)
            {
                e.Graphics.DrawRectangle(ClickPen, GetRect());
                CutShapes.Add(GetRect());
            }

            //ClickDrawPanel.Invalidate();

            for (int i = 0; i < shapesTOSave.Count; i++)
            {

                if(checkBox1.Checked)
                {
                    {
                        //Rectangle rectangle4 = new Rectangle(shapesTOSave[i].X, shapesTOSave[i].Y, shapesTOSave[i].Width, shapesTOSave[i].Height);

                        e.Graphics.DrawRectangle(ClickPen, CutShapes[0]);
                        CutShapes.Clear();
                    }
                }

                if (RadioButtonCircleClick.Checked)
                {//e.Graphics.DrawRectangle(ClickPen, rectangle1);
                    Rectangle rectangle1 = new Rectangle(shapesTOSave[i].X, shapesTOSave[i].Y, shapesTOSave[i].Width, shapesTOSave[i].Height);
                    e.Graphics.DrawEllipse(ClickPen, rectangle1);
                }
                else if(RadioButtonEllipseClick.Checked)
                {
                    Rectangle rectangle2 = new Rectangle(shapesTOSave[i].X, shapesTOSave[i].Y, shapesTOSave[i].Width, shapesTOSave[i].Height);
                    e.Graphics.DrawEllipse(ClickPen, rectangle2);
                }
                else if(RadioButtonRectangleClick.Checked)
                {
                    Rectangle rectangle3 = new Rectangle(shapesTOSave[i].X, shapesTOSave[i].Y, shapesTOSave[i].Width, shapesTOSave[i].Height);
                    e.Graphics.DrawRectangle(ClickPen, rectangle3);
                }
                else if(RadioButtonSquareClick.Checked)
                {
                    Rectangle rectangle4 = new Rectangle(shapesTOSave[i].X, shapesTOSave[i].Y, shapesTOSave[i].Width, shapesTOSave[i].Height);

                    e.Graphics.DrawRectangle(ClickPen, rectangle4);
                }
            }


        }
        private Rectangle GetRect()
        {
            CutRectangle = new Rectangle();
            CutRectangle.X = Math.Min(current.X, old.X);
            CutRectangle.Y = Math.Min(current.Y, old.Y);
            CutRectangle.Width = Math.Abs(current.X - old.X);
            CutRectangle.Height = Math.Abs(current.Y - old.Y);
            return CutRectangle;
        }

        private void Shapeheight_ReadOnlyChanged(object sender, EventArgs e)
        {
            if(RadioButtonCircleClick.Checked)
            {
                Shapeheight.ReadOnly = true;
            }


        }

        private void RadioButtonCircleClick_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Circle diameter:";
            Shapeheight.Enabled = false;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RadioButtonSquareClick_CheckedChanged(object sender, EventArgs e)
        {
            //Shapeheight.ReadOnly = true;
            label4.Text = "Square side:";
            Shapeheight.Enabled = false;
        }

        private void RadioButtonRectangleClick_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Rectangle width:";
            label5.Text = "Rectangle height:";
            Shapeheight.Enabled = true;
        }

        private void RadioButtonEllipseClick_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Ellipse width:";
            label5.Text = "Ellipse height:";
            Shapeheight.Enabled = true;
        }

        private void Drawcheck_CheckedChanged(object sender, EventArgs e)
        {
            trackBar1.Value = 1;
            textBox1.Text = Convert.ToString(trackBar1.Value);
            if (Drawcheck.Checked == true)
            {
                checkBox1.Enabled = false;
                FreeDrawingCheck.Enabled = false;
                LoopCheck.Enabled = false;
            }
            else 
            {
                checkBox1.Enabled = true;
                LoopCheck.Enabled = true;
                FreeDrawingCheck.Enabled = true;

            }
        }

        private void LoopCheck_CheckedChanged(object sender, EventArgs e)
        {
            trackBar1.Value = 1;
            textBox1.Text = Convert.ToString(trackBar1.Value);

            if (LoopCheck.Checked == true)
            {
                checkBox1.Enabled = false;
                FreeDrawingCheck.Enabled = false;
                Drawcheck.Enabled = false;
            }
            else 
            {
                checkBox1.Enabled = true;
                FreeDrawingCheck.Enabled = true;
                Drawcheck.Enabled =true;
            }
        }

        private void Xpoint_TextChanged(object sender, EventArgs e)
        {
           if(String.IsNullOrEmpty(Xpoint.Text) == true)
            {

            }
        }

        private void Ypoint_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Shapeheight_TextChanged(object sender, EventArgs e)
        {

        }

        private void Shapewidth_TextChanged(object sender, EventArgs e)
        {
           // if(Shapewidth.Text.GetType = )
            //ExLabel.Text = Convert.ToInt32(Shapewidth.Text.GetType().Name);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_FormatStringChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click_2(object sender, EventArgs e)
        {
            //    ClickDrawPanel.Anchor = AnchorStyles.Bottom;
            //    ClickDrawPanel.Anchor = AnchorStyles.Left;
            //ClickDrawPanel.Width = 500;
            //button2.Text = Convert.ToString(ClickDrawPanel.Width);
            ClickDrawPanel.Width = 1285;
        }

        private void ClickDrawPanel_MouseDown(object sender, MouseEventArgs e)
        {


            if (checkBox1.Checked)
            {
                IsMouseDown = true;
                current = e.Location;
            }
            else
            {
                old = e.Location;
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    ClickPen.Width = 2;
                }
                else
                {
                    ClickPen.Width = Convert.ToInt32(textBox1.Text);
                }
            }


           
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(trackBar1.Value);
        }

        private void FreeDrawingCheck_CheckedChanged(object sender, EventArgs e)
        {
            trackBar1.Value = 1;
            textBox1.Text = Convert.ToString(trackBar1.Value);

            if (FreeDrawingCheck.Checked)
            {
                checkBox1.Enabled = false;
                Drawcheck.Enabled = false;
                LoopCheck.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                Drawcheck.Enabled = true;
                LoopCheck.Enabled = true;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {

            }
            else
            {
                MessageBox.Show("Choose 'Cut' to cut some place from board");
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            trackBar1.Value = 1;
            textBox1.Text = Convert.ToString(trackBar1.Value);
            if (checkBox1.Checked)
            {

                ClickDrawPanel.Cursor = Cursors.Cross;
                LoopCheck.Enabled = false;
                Drawcheck.Enabled = false;
                FreeDrawingCheck.Enabled = false;
            }
            else
            {
                ClickDrawPanel.Cursor = Cursors.Default;
                LoopCheck.Enabled = true;
                Drawcheck.Enabled = true;
                FreeDrawingCheck.Enabled = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
            Pen A = new Pen(Color.White, trackBar1.Value);

            if (RadioButtonEllipseClick.Checked)
            {
                ClickGraphic.DrawEllipse(A, Backsomeshape[0], Backsomeshape[1], Backsomeshape[2], Backsomeshape[3]);
            }
           else if (RadioButtonCircleClick.Checked)
            {
                ClickGraphic.DrawEllipse(A, Backsomeshape[0], Backsomeshape[1], Backsomeshape[2], Backsomeshape[3]);
            }
           else if (RadioButtonSquareClick.Checked)
            {
                //ClickGraphic.DrawRectangle(A, Backsomeshape[0], Backsomeshape[1], Backsomeshape[2], Backsomeshape[3]);
              
                ClickGraphic.DrawRectangle(A, AllShapes[AllShapes.Count-1]);
                AllShapes.RemoveAt(AllShapes.Count-1);
                checkedListBox1.Items.RemoveAt(checkedListBox1.Items.Count-1);
                
            }
          else  if (RadioButtonRectangleClick.Checked)
            {
                ClickGraphic.DrawRectangle(A, Backsomeshape[0], Backsomeshape[1], Backsomeshape[2], Backsomeshape[3]);
                ClickGraphic.DrawRectangle(A, AllShapes[AllShapes.Count - 1]);
                AllShapes.RemoveAt(AllShapes.Count - 1);
                checkedListBox1.Items.RemoveAt(checkedListBox1.Items.Count-1);
            }
          
        }

        private void Button2_Click_3(object sender, EventArgs e)
        {
            Form1_2 form1_2 = new Form1_2();
            form1_2.ShowDialog();
        }

        private void ClickDrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown = true)
            {
                old = e.Location;
                IsMouseDown = false;
            }
        }

        private void Xposition_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_Click(object sender, EventArgs e)
        {
            label7.Text = Convert.ToString(checkedListBox1.Items.Count);
        }

        private void Gumka_Click(object sender, EventArgs e)
        {
            ClickPen.Width = 20;
            ClickDrawPanel.UseWaitCursor = true;
        }

        private void Elastic_CheckedChanged(object sender, EventArgs e)
        {

            if (Elastic.Checked == true)
            {
                ClickPen.Color = Color.White;
                //ClickDrawPanel.UseWaitCursor = true;
                ClickDrawPanel.Cursor = Cursors.No;
                LoopCheck.Enabled = false;
                LoopCheck.Checked = false;
                checkBox1.Enabled = false;
                checkBox1.Checked = false;
                FreeDrawingCheck.Enabled = false;
                FreeDrawingCheck.Checked = true;
                Drawcheck.Enabled = false;
                Drawcheck.Checked = false;

            }
            else
            {
                ClickDrawPanel.Cursor = Cursors.Default;
                FreeDrawingCheck.Checked = false;
                LoopCheck.Enabled = true;
                checkBox1.Enabled = true;
                FreeDrawingCheck.Enabled = true;
                Drawcheck.Enabled = true;
            }
        }
    }
        }
    

