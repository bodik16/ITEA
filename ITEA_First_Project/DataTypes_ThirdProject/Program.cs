using System;

namespace DataTypes_ThirdProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "123456789";
            string userId = "Bogdan";

            

        

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Input your ID: ");

                string InpID;
                InpID = Convert.ToString(Console.ReadLine());
                Console.ReadKey();
                Console.Write("Input your password: ");
                string InpPassword;
                InpPassword = Convert.ToString(Console.ReadLine());
                Console.ReadKey();
                if (InpPassword != password || InpID!=userId)
                {

                    Console.WriteLine("Wrong ID or password, try again");
                }
            }
            Console.WriteLine("BAN!");
            Console.ReadKey();

        }
    }
}
