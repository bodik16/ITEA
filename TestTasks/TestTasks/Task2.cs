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
    public partial class Task2 : Form
    {
        public string InputedString;
        public Task2()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            InputedString = MainTextMox2.Text;
            ShowLetter(InputedString, LastLetterTextBox);

        }
        private static void ShowLetter(string text, TextBox textbox)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    textbox.Text = "_ _";
                }
                else
                {
                    textbox.Text = Convert.ToString(text[text.Length - 1]);
                }
            }

        }
    }
}
