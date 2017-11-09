using System;

namespace ItseArv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä sana tai lause");
            string userInput = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}. {userInput}");
            }
            Console.ReadKey();
        }
    }
}
