using System;

namespace Funktio1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Suurin luku oli " + numerot());
            Console.ReadKey();
        }
        static int numerot()
        {
            int num = 0;
            int max = 0;
            bool isNumber;
            Console.WriteLine("Syötä 10 positiivista lukua");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. ");

                if (isNumber = int.TryParse(Console.ReadLine(), out num) && num > 0)
                {
                    if (max < num)
                    {
                        max = num;
                    }
                }
                else
                {
                    Console.WriteLine("Väärä syöte, syötä positiivinen luku");
                    i--;
                }
            }
            return max;
        }
    }
}
