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
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {

            string TExt = InputTextBox1.Text;
            string Letters = InputLetterstextBox1.Text;
            bool result;
            result =  HasNoneLetters(Text, Letters);
            InfLabel.Text = Convert.ToString(result);

        }


        private static bool HasNoneLetters(string blacklist, string phrase)
        {
            string Black = blacklist.ToLower();
            string phraseWord = phrase.ToLower();
            bool IsSomeLetter = true;

            char[] BlackListArr = new char[blacklist.Length];
            char[] PhraseArr = new char[phrase.Length];

            BlackListArr = Black.ToCharArray();
            PhraseArr = phraseWord.ToCharArray();

            for (int i = 0; i < PhraseArr.Length; i++)
            {
                for (int j = 0; j < BlackListArr.Length; j++)
                {
                    if (PhraseArr[i] != BlackListArr[j])
                    {
                        IsSomeLetter = true;
                        //break;
                    }
                    else if (PhraseArr[i] == BlackListArr[j])
                    {
                        IsSomeLetter = false;
                        break;
                    }
                }
                break;
            }
            return IsSomeLetter;
        }
    }
}
