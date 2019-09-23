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
    public partial class Task3 : Form
    {
        string fileContent = string.Empty;
        string filePath = string.Empty;
        string ourText;
        int[] Numbers;
        public Task3()
        {
            InitializeComponent();
        }

        private void InputArrTextBox_TextChanged(object sender, EventArgs e)
       {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
        private static int[] ConvertToIntArr( TextBox textBox, Label label)
        {

            string text = textBox.Text;

            string[] INP = text.Split(',');

            int[] NumbersArray = new int[INP.Length];
            for (int i = 0; i < INP.Length; i++)
            {
                try
                {
                    NumbersArray[i] = Convert.ToInt32(INP[i]);
                }
                catch
                {
                    label.Text = "Something went wrong";
                }
            }
            return NumbersArray;
        }
        private static int GetMinValueFromArray(int [] arr, Label a )
        {
            
            int MinValue = arr[0];
            if(arr.Length == 0)
            {
                a.Text = "Arr is Empty";
            }
            else if (arr.Length == 1)
            {
                MinValue = arr[0];
            }
            else if (arr.Length >1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (MinValue > arr[i])
                    {
                        MinValue = arr[i];
                    }
                }
            }
            return MinValue;
        }

        private void OpenButton3_Click(object sender, EventArgs e)
        {
            ReadingClass.ReadingFromFile(filePath, fileContent, ourText, InputArrTextBox);
        }

        private void ReadFromFileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ReadFromFileCheckBox.Checked == true)
            {
                InputArrTextBox.Clear();
                InputArrTextBox.ReadOnly = true;
                OpenButton3.Visible = true;
            }
            else
            {
                InputArrTextBox.ReadOnly = false;
                OpenButton3.Visible = false;
            }
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            if(InputArrTextBox.Text == string.Empty)
            {
                InfLabel.Text = "Arr is empty\nInput some values to find the smallest value from Arr";
                MinValueLabel.Text = "empty";
            }
            else
            {
                ConvertToIntArr(InputArrTextBox, InfLabel);
                int Count = ConvertToIntArr(InputArrTextBox, InfLabel).Length;
                Numbers = new int[Count];
                Numbers = ConvertToIntArr(InputArrTextBox, InfLabel);
                int Minimum = GetMinValueFromArray(Numbers, InfLabel);
                MinValueLabel.Text = Convert.ToString(Minimum);
            }
           
        }
    }
}
