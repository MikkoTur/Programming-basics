using System;

namespace ItseArv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä sana tai lause");
            string userInput = Console.ReadLine();
            string input = userInput.Replace(" ", "");

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {userInput}");
            }
            Console.ReadKey();
        }
    }
}
