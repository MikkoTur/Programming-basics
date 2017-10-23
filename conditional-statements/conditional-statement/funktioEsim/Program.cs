using System;

namespace funktioEsim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool isNumber;
            int N;
            int sum = 0;

            Console.WriteLine("Lasketaan N ensimmäistä lukua yhteen");
            Console.WriteLine("Syötä N: ");

            if (isNumber = int.TryParse(Console.ReadLine(), out N))
            {
                if (N > 0)
                {
                    for (int i = 1; i <= N; i++)
                    {
                        sum = sum + i;
                    }

                    Console.WriteLine($"Lukujen summa on: {sum}");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Syötit muuta kuin numeron");
                Console.ReadKey();
            }
        }
    }
}