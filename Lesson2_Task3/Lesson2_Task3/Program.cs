using System;
using System.IO;

namespace Lesson2_Task3
{
    class Program
    {
        //static string Caesar(string value, int shift)
        //{
        //    char[] buffer = value.ToCharArray();
        //    for (int i = 0; i < buffer.Length; i++)
        //    {
        //        // Letter.
        //        char letter = buffer[i];
        //        // Add shift to all.
        //        letter = (char)(letter + shift);
        //        // Subtract 26 on overflow.
        //        // Add 26 on underflow.
        //        if (letter > 'z')
        //        {
        //            letter = (char)(letter - 26);
        //        }
        //        else if (letter < 'a')
        //        {
        //            letter = (char)(letter + 26);
        //        }
        //        // Store.
        //        buffer[i] = letter;
        //    }
        //    return new string(buffer);
        //}

        //static void Main()
        //{
        //    string a = "hello my dear friend";
        //    string b = Caesar(a, -3); // Ok
        //    //string c = Caesar(b, ); // Ok

        //    //string d = Caesar(a, 1); // Ok
        //    //string e = Caesar(d, -1); // Ok

        //    //string f = "exxegoexsrgi";
        //    //string g = Caesar(f, -4); // Ok

        //    //Console.WriteLine(a);
        //    //Console.WriteLine();

        //    Console.WriteLine(b);
        //    //Console.WriteLine();

        //    //Console.WriteLine(c);
        //    //Console.WriteLine();

        //    //Console.WriteLine(d);
        //    //Console.WriteLine();

        //    //Console.WriteLine(e);
        //    //Console.WriteLine();

        //    //Console.WriteLine(f);
        //    //Console.WriteLine();

        //    //Console.WriteLine(g);
        //    //Console.WriteLine();


        //}
        public static void Main(string[] args)
        {

            char[] alph = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string ourWord = "EBIIL, JV ABVO COFBKA";
            char[] Arr = ourWord.ToCharArray();
            Caesar_Cipher.Caesar(Arr,alph);
            Console.WriteLine(Arr);
            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(Arr);
            //}
            //Console.ReadKey();
            //string output = "";
            //int shift;
            //bool userright = false;
            //string cipher = File.ReadAllText("C:\\Users\\Bogda\\Documents\\ITEA\\decryptme.txt");

            //char[] decr = cipher.ToCharArray();

            //do
            //{

            //    Console.WriteLine("How many times would you like to shift? (Between 0 and 26)");
            //    shift = Convert.ToInt32(Console.ReadLine());
            //    if (shift > 26)
            //    {
            //        Console.WriteLine("Over the limit");
            //        userright = false;
            //    }
            //    if (shift < 0)
            //    {
            //        Console.WriteLine("Under the limit");
            //        userright = false;
            //    }
            //    if (shift <= 26 && shift >= 0)
            //    {
            //        userright = true;
            //    }
            //}


            //while (userright == false);


            //for (int i = 0; i < decr.Length; i++)
            //{

            //    {
            //        char character = decr[i];

            //        character = (char)(character + shift);

            //        if (character == '\'' || character == ' ')
            //            continue;

            //        if (character > 'Z')
            //            character = (char)(character - 26);

            //        else if (character < 'A')
            //            character = (char)(character + 26);


            //        output = output + character;
            //    }

            //    Console.WriteLine("\nShift {0} \n {1}", i + 1, output);
            //}

            //StreamWriter file = new StreamWriter("decryptedtext.txt");
            //file.WriteLine(output);
            //file.Close();

        }
    }
}

