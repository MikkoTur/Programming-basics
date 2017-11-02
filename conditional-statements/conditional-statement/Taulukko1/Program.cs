using System;

namespace Taulukko1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo 100 lukua väliltä 0-50 ja muodostaa niistä taulukon.");
            int[] arrayNumber = new int[100];
            Random rnd = new Random();
            double sum = 0;
            for (int i = 0; i < 100; i++)
            {
                arrayNumber[i] = rnd.Next(0, 51);
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i}. {arrayNumber[i]}");
                sum += arrayNumber[i]; 
            }
            Console.WriteLine($"Lukujen summa on {sum}");
            Console.WriteLine($"Lukujen keskiarvo on {sum / 100}");
            Console.ReadKey();
        }
    }
}
