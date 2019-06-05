using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigenèreCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            KeyLabel.Visible = true;
            KeyTextBox.Visible = true;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            EncryptButton.Visible = true;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            DecryptButton.Visible = true;
            EncryptedLabel.Visible = true;
            EncryptedTextBox.Visible = true;
            string inputedText = EncryptTextBox.Text.ToLower();
            string inputedKey = KeyTextBox.Text.ToLower();
            string A = Cipher.VigenereCipherEnglish(inputedText, inputedKey);
            EncryptedTextBox.Text = A;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            //DecryptButton.Visible = true;
            EncryptedLabel.Visible = true;
            EncryptedTextBox.Visible = true;
            string inputedText = EncryptTextBox.Text.ToLower();
            string inputedKey = KeyTextBox.Text.ToLower();
            string B = Cipher.VigenereCipherEnglishDecrypt(inputedText, inputedKey);
            EncryptedTextBox.Text = B;

        }
    }
}
