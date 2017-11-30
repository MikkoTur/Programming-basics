using System;

namespace Merkkijono4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tarkastaa onko sana palintromi");
            string UserInput = Console.ReadLine().ToUpper();
            string reverseUserInput = "";

            for (int i = UserInput.Length - 1; i >= 0; i--)
            {
                reverseUserInput += UserInput[i];
            }
            if (UserInput.Replace (" ", "") == reverseUserInput.Replace (" ", ""))
            {
                Console.WriteLine($" Syöttämäsi teksti, {UserInput.ToLower()} on palintromi");
            }
            else
            {
                Console.WriteLine($" Syöttämäsi teksti, {UserInput.ToLower()} ei ole palintromi");
            }
            Console.ReadKey();
        }
    }
}
