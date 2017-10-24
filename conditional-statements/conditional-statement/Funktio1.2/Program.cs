using System;

namespace Funktio1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int x;
            int y;

            Console.WriteLine("Syötä ensimmäinen luku: ");
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Syötä toinen luku: ");
            int.TryParse(Console.ReadLine(), out y);

            Console.WriteLine($"Pienempi luku on: {minimi(x, y)}");
            Console.ReadKey();
        }
        static int minimi(int x, int y)
        {
            int min;
            if (x > y)
            {
                min = y;
            }
            else
            {
                min = x;
            }
            return min;
        }
    }
}
