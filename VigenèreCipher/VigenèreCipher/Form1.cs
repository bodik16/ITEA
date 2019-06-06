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
            //DecryptButton.Visible = true;
            if (String.IsNullOrEmpty(EncryptTextBox.Text)|| String.IsNullOrEmpty(KeyTextBox.Text))
            {
                MessageBox.Show("Can`t do it, type some Text or Key");
            }
            else
            {
                DecryptButton.Visible = true;
                EncryptedLabel.Visible = true;
                EncryptedTextBox.Visible = true;
                string inputedText = EncryptTextBox.Text.ToLower();
                string inputedKey = KeyTextBox.Text.ToLower();
                Cipher.CheckForCorrectText(inputedText);
                Cipher.CheckForCorrectText(inputedKey);
                string A = Cipher.VigenereCipherEnglish(inputedText, inputedKey);
                EncryptedTextBox.Text = A;


            }
           

        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            EncryptedLabel.Visible = true;
            EncryptedTextBox.Visible = true;
            string inputedText = EncryptTextBox.Text.ToLower();
            string inputedKey = KeyTextBox.Text.ToLower();
            Cipher.CheckForCorrectText(inputedText);
            Cipher.CheckForCorrectText(inputedKey);
            string B = Cipher.VigenereCipherEnglishDecrypt(inputedText, inputedKey);
            EncryptedTextBox.Text = B;

        }

        private void EncryptedTextBox_TextChanged(object sender, EventArgs e)
        {
            DecryptButton.Visible = true;
            KeyLabel.Visible = true;
            KeyTextBox.Visible = true;
        }

        private void EncryptButton_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void EncryptButton_MouseMove(object sender, MouseEventArgs e)
        {
            EncryptButton.Size = new Size(105, 33);
        }

        private void EncryptButton_MouseLeave(object sender, EventArgs e)
        {
            EncryptButton.Size = new Size(DecryptButton.Size.Width, DecryptButton.Size.Height);
        }

        private void DecryptButton_MouseMove(object sender, MouseEventArgs e)
        {
            DecryptButton.Size = new Size(105, 33);
        }

        private void DecryptButton_MouseLeave(object sender, EventArgs e)
        {
            DecryptButton.Size = new Size(EncryptButton.Size.Width, EncryptButton.Size.Height);

        }

    }
}
