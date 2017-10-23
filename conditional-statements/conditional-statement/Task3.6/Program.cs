using System;

namespace Task3._6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ohjelma simuloi nopanheittoa 1000 kertaa.\n");
            Console.Write("Lisäksi ohjelma kertoo numeron 6 esiintymiskertojen lukumäärän.\n");

            Random rnd = new Random();
            int six = 0;

            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine($"{i}. {rnd.Next(6)}");
                if (rnd.Next(6) == 1)
                {
                    six += 1;
                }
            }
            Console.WriteLine($"\nKuutonen arvottiin {six} kertaa.");
            Console.ReadKey();
        }
    }
}
