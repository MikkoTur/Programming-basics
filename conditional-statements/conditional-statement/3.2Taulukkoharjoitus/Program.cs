using System;

namespace _3._2Taulukkoharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma arpoo kaksiulotteiseen kokonaisluku taulukkoon arvot 0-100");
            int[,] arrayNumber = new int[10, 20];
            Random rnd = new Random();
            Console.WriteLine("X, Y = Arvo");
            for (int i = 0; i < 10; i++)
            {
                for (int y = 0; y < 20; y++)
                {
                    arrayNumber[i, y] = rnd.Next(0, 20);
                    if (arrayNumber[i, y] < 10)
                    {
                        Console.WriteLine($"[{i},{y}] = 0{arrayNumber[i, y]}");
                    }
                    else
                    {
                        Console.WriteLine($"[{i},{y}] = {arrayNumber[i, y]}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
