using System;

namespace _3.Taulukkoharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo yksiulotteiseen kokonaisluku taulukkoon arvot 0-20");
            int[] arrayNumber = new int[10];
            Random rnd = new Random();
            Console.WriteLine("X = Arvo");
            for (int i = 0; i < 10; i++)
            {
                arrayNumber[i] = rnd.Next(0, 20);
                if (arrayNumber[i] < 10)
                {
                    Console.WriteLine($"[{i}] = 0{arrayNumber[i]}");
                }
                else
                {
                    Console.WriteLine($"[{i}] = {arrayNumber[i]}");
                }
            }
            Console.ReadKey();
        }
    }
}
