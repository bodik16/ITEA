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

namespace HomeTaskLesson2
{
    public partial class Reading : Form
    {
        //String[] args = new String[];
        string fileContent = string.Empty;
        string filePath = string.Empty;
        string ourText;
        public Reading()
        {
            InitializeComponent();
        }

        private void ManuallyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (manuallyCheckBox.Checked)
            {
                mainTextBox.ReadOnly = false;
                FromFileCheckBox.Enabled = false;
                OpenButton.Visible = false;
            }

            else
            {
                mainTextBox.ReadOnly = false;
                OpenButton.Visible = false;
                FromFileCheckBox.Enabled = true;
                manuallyCheckBox.Enabled = true;

            }
        }

        private void FromFileCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (FromFileCheckBox.Checked)
            {

                mainTextBox.ReadOnly = true;
                manuallyCheckBox.Enabled = false;
                OpenButton.Visible = true;
            }
            else
            {
                mainTextBox.ReadOnly = false;
                OpenButton.Visible = false;
                FromFileCheckBox.Enabled = true;
                manuallyCheckBox.Enabled = true;

            }
        }

        private void Reading_Load(object sender, EventArgs e)
        {

        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CountTextBox2.Text) != true)
            {
                label2.Text = $"Number of words which have {CountTextBox2.Text} letters:";
            }
            else
            {
                label2.Text = "Input some value";
            }

            string WordsFromMAin = mainTextBox.Text;
            String[] ArrWords = WordsFromMAin.Split(' ');
            List<int> Countt = new List<int>();
            for (int i = 0; i < ArrWords.Length; i++)
            {

                Countt.Add(ArrWords[i].Length);
            }

            int k = 0;
            var y = Convert.ToInt32(CountTextBox2.Text);
            
            for (int i = 0; i < Countt.Count; i++)
            {
                if (Countt[i] == y)
                {
                    k++;
                }
            }
            ResultTextBox.Text = Convert.ToString(k);

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                    //mainTextBox.Text = fileContent = reader.ReadToEnd();
                    ourText = File.ReadAllText(filePath);

                }
                mainTextBox.Text = ourText;
            }

        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            string word = mainTextBox.Text;
            int countWords = word.Split().Length;
            Words.Text = Convert.ToString(countWords - 1);
            Words.Font = new Font(Convert.ToString(countWords - 1), 50);
            Ex.Text = Convert.ToString(mainTextBox.TextLength);
            if (mainTextBox.TextLength < 99)
            {
                Ex.Font = new Font(Convert.ToString(mainTextBox.TextLength), 50);
            }
            else if (mainTextBox.TextLength > 99 & mainTextBox.TextLength < 999)
            {
                Ex.Font = new Font(Convert.ToString(mainTextBox.TextLength), 37);
            }
            else if (mainTextBox.TextLength > 999)
            {
                Ex.Font = new Font(Convert.ToString(mainTextBox.TextLength), 27);
            }



        }

        private void CountTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ex_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
