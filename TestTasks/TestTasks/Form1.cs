using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Task1 task1 = new Task1();
            task1.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2();
            task2.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Task3 task3 = new Task3();
            task3.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Task4 task4 = new Task4();
            task4.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Task5 task5 = new Task5();
            task5.ShowDialog();
        }
    }
}
