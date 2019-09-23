using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTasks
{
    public partial class Task1 : Form
    {
        string fileContent = string.Empty;
        string filePath = string.Empty;
        string ourText;
        public Task1()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (manuallyCheckBox.Checked)
            {
                mainTextBox.ReadOnly = false;
                FromFileCheckBox.Enabled = false;
                OpenButton.Visible = false;
                mainTextBox.Clear();
            }

            else
            {
                mainTextBox.ReadOnly = false;
                OpenButton.Visible = false;
                FromFileCheckBox.Enabled = true;
                manuallyCheckBox.Enabled = true;
                mainTextBox.Clear();

            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (FromFileCheckBox.Checked)
            {

                mainTextBox.ReadOnly = true;
                OpenButton.Visible = true;
                mainTextBox.Clear();
            }
            else
            {
                mainTextBox.ReadOnly = false;
                OpenButton.Visible = false;
                FromFileCheckBox.Enabled = true;
                manuallyCheckBox.Enabled = true;
                mainTextBox.Clear();
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            ReadingClass.ReadingFromFile(filePath, fileContent, ourText, mainTextBox);
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            string word = mainTextBox.Text;
            string OnlyText;
            int CountOfOnlyText = 0;
            //word[word.Length + 1] = ' ';
            int countWords = word.Split().Length;
            Words.Text = Convert.ToString(countWords - 1);
            Words.Font = new Font(Convert.ToString(countWords - 1), 50);
            Letters.Text = Convert.ToString(mainTextBox.TextLength);
            OnlyText = mainTextBox.Text;
            CountOfOnlyText = UnKnownSymbols(OnlyText, CountOfOnlyText);
            ChangeFont(Letters, mainTextBox.TextLength);
            ChangeFont(Words, countWords);
            ChangeFont(LettersOnly, mainTextBox.TextLength - CountOfOnlyText);
            LettersOnly.Text = Convert.ToString(mainTextBox.TextLength - CountOfOnlyText);

        }
        private static int UnKnownSymbols(string str, int counter)
        {
            counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    counter = counter + 1;
                }
                else if (str[i] == '.')
                {
                    counter = counter + 1;
                }
                else if (str[i] == ',')
                {
                    counter = counter + 1;
                }
                else if (str[i] == '?')
                {
                    counter = counter + 1;
                }
                else if (str[i] == '!')
                {
                    counter = counter + 1;
                }
                else if (str[i] == '/')
                {
                    counter = counter + 1;
                }
                else if (str[i] == '|')
                {
                    counter = counter + 1;
                }
                else if (str[i] == ')')
                {
                    counter = counter + 1;
                }
                else if (str[i] == '(')
                {
                    counter = counter + 1;
                }
                else if (str[i] == '`')
                {
                    counter = counter + 1;
                }
                else if (str[i] == '>')
                {
                    counter = counter + 1;
                }
                else if (str[i] == '<')
                {
                    counter = counter + 1;
                }
               
            }
            return counter;
        }
        private static void ChangeFont(Label a, int param)
        {
            if (param < 99)
            {
                a.Font = new Font(Convert.ToString(param), 30);

            }
            else if (param > 99 & param < 999)
            {
                a.Font = new Font(Convert.ToString(param), 20);
            }
            else if (param > 999)
            {
                a.Font = new Font(Convert.ToString(param), 15);
            }
        }
   
    
    }
}
