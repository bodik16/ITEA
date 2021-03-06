﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigenèreCipher
{
    static class Cipher
    {
        public static List<int> IndexesOfWordForDecrypt = new List<int>();
        public static string VigenereCipherEnglish(string Text, string Key)
        {
            List<int> IndexesFromWords = new List<int>();
            List<int> IndexesFromKeys = new List<int>();

            List<int> IndexesOfEncryptedText = new List<int>();

            IndexesOfWordForDecrypt = FindIndexesFromText(Text).ToList(); // for decrypt

            IndexesFromWords = FindIndexesFromText(Text);
            IndexesFromKeys = FindIndexesFromText(Key);
            IndexesOfEncryptedText = ListOfIndexesOfEncryptedText(IndexesFromWords, IndexesFromKeys).ToList();

            int count = Text.Length;
            char[] EncryptedLetters = new char[count];

            for (int i = 0; i < IndexesOfEncryptedText.Count; i++)
            {
                //if()
                for (int j = 0; j < Alphabet.EnglishAlphabet.Length; j++)
                {
                    int A;
                    A = IndexesOfEncryptedText[i];
                    EncryptedLetters[i] = Alphabet.EnglishAlphabet[A];
                    break;
                }
            }
            string OurEncryptedWords = new string(EncryptedLetters);
            return OurEncryptedWords;

        }
        public static List<int> FindIndexesFromText(string A)
        {
            char[] E = A.ToCharArray();
            List<int> ListOfIndexsOfWord = new List<int>();
            for (int j = 0; j < E.Length; j++)
            {
                for (int i = 0; i < Alphabet.EnglishAlphabet.Length; i++)
            {
                    if (Alphabet.EnglishAlphabet[i]== E[j])
                    {
                        ListOfIndexsOfWord.Add(i);
                        break;
                    }
                }
            }
            return ListOfIndexsOfWord;
        }
        public static List<int> ListOfIndexesOfEncryptedText(List<int> Text, List<int> Key)
        {
            List<int> Lack = new List<int>();
            //Якщо в ключі менше букв ніж в слові, то в кінець ключа добавляються індекси букв з початку, поки не буде однаковими і ключ і слово.
            if (Key.Count < Text.Count) 
            {
                int q = Text.Count - Key.Count;
                for (int i = 0; i < q; i++)
                {
                    Lack.Add(Key[i]);
                    Key.AddRange(Lack);
                    Lack.Clear();
                }
            }
            List<int> Sum = new List<int>();
                    for (int i = 0; i < Text.Count; i++)
                     {
                            int a = Text[i] + Key[i];
                         if (a>26)
                         {
                            int e = (Text[i] + Key[i]) - 26;
                            Sum.Add(e);
                         }
                         else if(a <= 26)
                         {
                            int w = Text[i] + Key[i];
                            Sum.Add(w);
                         }
                    }
                return Sum;
        }
        public static string VigenereCipherEnglishDecrypt(string Text, string Key)
        {
            List<int> IndexesFromWords = new List<int>();
            List<int> IndexesFromKeys = new List<int>();

            List<int> IndexesOfDecryptedText = new List<int>();

            IndexesFromWords = FindIndexesFromText(Text);
            IndexesFromKeys = FindIndexesFromText(Key);
            IndexesOfDecryptedText = ListOfIndexesOfDecryptedText(IndexesFromWords, IndexesFromKeys).ToList();

            int count = Text.Length;
            char[] EncryptedLetters = new char[count];

            for (int i = 0; i < IndexesOfDecryptedText.Count; i++)
            {
                //if()
                for (int j = 0; j < Alphabet.EnglishAlphabet.Length; j++)
                {
                    int A;
                    A = IndexesOfDecryptedText[i];
                    EncryptedLetters[i] = Alphabet.EnglishAlphabet[A];
                    break;
                }
            }
            string OurEncryptedWords = new string(EncryptedLetters);
            return OurEncryptedWords;

        }
        public static List<int> ListOfIndexesOfDecryptedText(List<int> Text, List<int> Key)
        {
            List<int> Lack = new List<int>();
            
            if (Key.Count < Text.Count)
            {
                int q = Text.Count - Key.Count;
                for (int i = 0; i < q; i++)
                {
                    Lack.Add(Key[i]);
                }
                Key.AddRange(Lack);
            }

            List<int> Sum = new List<int>();
            for (int i = 0; i < Text.Count; i++)
            {
                int w = 0;
                int a = Text[i] - Key[i];
              if(a<0)
                {
                    a = a % 26+26;
                }
              else if(a>=0)
                {
                    a = a % 26;
                }
                Sum.Add(a);
            }
            return Sum;
        }
        public static void CheckForCorrectText(string A)
        {
            char[] arr = A.ToCharArray();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < Alphabet.EnglishAlphabet.Length; j++)
                {
                    if(arr[i] == Alphabet.EnglishAlphabet[j])
                    {
                        count++;
                    }
                }
            }
            int a = arr.Length;
            if (count != a)
            {
                MessageBox.Show("Please, input correct Text without Numbers or unknown symbols. Known symbols were Encrypted/Decrypted");
            }
        }

    }
}
