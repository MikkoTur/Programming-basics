using System;

namespace Task3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma tulostaa vakioveikkaus rivin (13 kohdetta) ");
            Console.Write("1 = kotivoitto, X = tasapeli, 2 = vierasvoitto. \n");

            Random rnd = new Random();
            double rndNumber = 0.0;

            for (int i = 1; i<=13;i++)
            {
                rndNumber = rnd.NextDouble();
                if (rndNumber < 0.4)
                {
                    Console.WriteLine($"{i}. 1");
                }
                else if (rndNumber > 0.4 && rndNumber < 0.6)
                {
                    Console.WriteLine($"{i}. X");
                }
                else
                {
                    Console.WriteLine($"{i}. 2");
                }
            }
            Console.ReadKey();
        }
    }
}
