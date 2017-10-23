using System;

namespace Task3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa  20 satunnaista kokonaislukua valilta 0-50");
            Random rnd = new Random();

            for (int number = 0; number < 4; number++)
            {
                Console.Write($"Rivi:");
                for (int number2 = 0; number2 < 5; number2++)
                {
                    if (number2 < 4)
                    {
                        Console.Write($"{rnd.Next(50)}, ");
                    }
                    else
                    {
                        Console.WriteLine(rnd.Next(50));
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
