using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma ilmoittaa merkkien lukumäärän");
            string merkkijono = Console.ReadLine();
            int length = merkkijono.Length;
            Console.WriteLine($"Syötteessä on {length} merkkiä");
            Console.ReadKey();

        }
    }
}
