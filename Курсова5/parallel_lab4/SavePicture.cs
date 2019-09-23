using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parallel_lab4
{
    public partial class SavePicture : Form
    {
        Pen pen = new Pen(Color.Blue, 2);
        Graphics PictureGraphic;
        Graphics panell;
        Image File;
        List<Rectangle> Shapes = new List<Rectangle>();

        //public PictureBox pictureBox1 = new PictureBox(); 
        public SavePicture()
        {
            InitializeComponent();
            PictureGraphic = pictureBox1.CreateGraphics();
            panell = panel1.CreateGraphics();
            
        }
        //private Bitmap DrawControlToBitmap(Control control)
        //{
        //    //Graphics graphics;
        //    ////pictureBox1.CreateGraphics();
        //    //Bitmap bitmap = new Bitmap(control.Width, control.Height);
        //    //graphics = Graphics.FromImage(bitmap);
        //    //Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
        //    //graphics.CopyFromScreen(rect.Location, Point.Empty, control.Size);
        //    //return bitmap;
        //    //Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        //    //PictureGraphic = Graphics.FromImage(bitmap);
        //    //Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
        //    //rect.Location = pictureBox1.Location;
        //    //PictureGraphic.CopyFromScreen(pictureBox1.Location, Point.Empty, control.Size = pictureBox1.Size);
        //    //return bitmap;

        //}
        private void Button1_Click(object sender, EventArgs e)
        {
            PictureGraphic.DrawEllipse(pen, new Rectangle(100, 100, 50, 50));
            pictureBox1.BackColor = Color.Red;
            pictureBox1.CreateGraphics().DrawRectangle(pen, 100, 100, 50, 29);
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
                    pictureBox1.Image = File;
                }
            }
            else if (comboBox1.Text == "Save")
            {

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "JPG(*.JPG)|*.jpg|Bitmap|*.bmp|Gif|*.gif";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                   
                    int width = Convert.ToInt32(panel1.Width);
                    int height = Convert.ToInt32(panel1.Height);
                    Bitmap bmp = new Bitmap(width, height);
                    panel1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    bmp.Save(dialog.FileName, ImageFormat.Bmp);
                }


                //using (Bitmap bitmap = new Bitmap(panel1.ClientSize.Width,
                //                  panel1.ClientSize.Height))
                //{
                //    panel1.DrawToBitmap(bitmap, panel1.ClientRectangle);
                //    bitmap.Save("C:\\" + pagAtual + ".bmp", ImageFormat.Bmp);




                //SaveFileDialog dialog = new SaveFileDialog();
                //if (dialog.ShowDialog() == DialogResult.OK)
                //{
                //    int width = Convert.ToInt32(panel1.Width);
                //    int height = Convert.ToInt32(panel1.Height);
                //    Bitmap bmp = new Bitmap(width, height);
                //    panel1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                //    bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                //}




                //    SaveFileDialog s = new SaveFileDialog();
                //    s.Filter = "JPG(*.JPG)|*.jpg";

                //    if (s.ShowDialog() == DialogResult.OK)
                //    {

                //        bmpScreenshot = new Bitmap(pictureBox1.Bounds.Width, pictureBox1.Bounds.Height, PixelFormat.Format32bppArgb);

                //        PictureGraphic = Graphics.FromImage(bmpScreenshot);

                //        PictureGraphic.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

                //        bmpScreenshot.Save(s.FileName, ImageFormat.Png);

                //    }
                //}
            }
            }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //PictureGraphic.DrawEllipse(pen, new Rectangle(100, 100, 50, 50));
            //pictureBox1.PointToScreen;
        }
       

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //Bitmap bitmap = DrawControlToBitmap(pictureBox1);
            //bitmap.Save("Box.bmp");
            //System.Diagnostics.Process.Start("Box.bmp");
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
           // panell.DrawEllipse(pen, panel1.Width - 250, panel1.Height - 250, 50, 100);

            panel1.DrawToBitmap(bmp, new System.Drawing.Rectangle(150, 150, panel1.Width, panel1.Height));
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); //you could ave in BPM, PNG  etc format.
            byte[] Pic_arr = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(Pic_arr, 0, Pic_arr.Length);
            ms.Close();




            //Bitmap bmp = new Bitmap(myControl.ClientRectangle.Width, myControl.ClientRectangle.Height);
            //Graphics gBmp = Graphics.FromImage(bmp);
            //gBmp.DrawEverything(); //this is your code for drawing
            //gBmp.Dispose();
            //bmp.Save("image.png", ImageFormat.Png);



            //using (SaveFileDialog sfdlg = new SaveFileDialog())
            //{
            //    sfdlg.Title = "Save Dialog";
            //    sfdlg.Filter = "Bitmap Images (*.bmp)|*.bmp|All files(*.*)|*.*";
            //    if (sfdlg.ShowDialog(this) == DialogResult.OK)
            //    {
            //        using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
            //        {
            //            pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            //            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //            pictureBox1.Image.Save("c://cc.Jpg");
            //            bmp.Save(sfdlg.FileName);
            //            MessageBox.Show("Saved Successfully.....");

            //        }
            //    }
            //}
            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //byte[] ar = new byte[ms.Length];
            //ms.Write(ar, 0, ar.Length);
            //var jpgImage = new Byte[jpgImageSize];
            //pictureBox1.Image.Save(@"C:\Users\Bogda\Desktop\Курсова56\parallel_lab4\bin\Debug", ImageFormat.Jpeg);
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            //panell.DrawEllipse(pen, panel1.Width-250, panel1.Height - 250, 50, 100);
            Rectangle rectangle = new Rectangle(panel1.Width - 250, panel1.Height - 250, 50, 100);
            panell.DrawRectangle(pen, rectangle);
            Shapes.Add(rectangle);

            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (panel1 != null)
            //    {
            //        panel1.Save("c:\\myBitmap.bmp");
            //        button4.Text = "Saved file.";
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("There was a problem saving the file." +
            //        "Check the file permissions.");
            //}
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
           
            //panell.DrawEllipse(pen, panel1.Width - 250, panel1.Height - 250, 50, 100);
            for (int i = 0; i < Shapes.Count; i++)
            {
                e.Graphics.DrawRectangle(pen, Shapes[i]);
            }

        }
    }
}
