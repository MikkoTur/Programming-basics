using System;

namespace Merkkijono2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma muuttaa e kirjaimet @ merkiksi");
            string e = Console.ReadLine();
            e = e.Replace('e', '@');
            Console.WriteLine($"Lopullinen virkkeesi: '{e}'");
            Console.ReadKey();
        }
    }
}
