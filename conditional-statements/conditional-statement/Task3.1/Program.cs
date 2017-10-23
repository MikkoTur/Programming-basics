using System;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kokonaislukujen 1-10 neliojuuret");

            for (int f = 1; f <= 10; f++)
            {
                Console.WriteLine($"{f}\t\t{Math.Round(Math.Sqrt(f), 2)}");
            }

            Console.ReadLine();
        }
    }
}
