using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool isNumber;
            int N;
            int Even = 0;
            int Odd = 0;

            Console.WriteLine("Lasketaan N:n ensimmäisten parillisten ja parittomien lukujen summat.");
            Console.WriteLine("Syötä N: ");

            if (isNumber = int.TryParse(Console.ReadLine(), out N))
            {
                if (N > 0)
                {
                    for (int i = 0; i <= N; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Even = Even + i;
                        }
                        else if (i % 2 == 1)
                        {
                            Odd = Odd + i;
                        }
                    }
                }
                else if (N < 0)
                {
                    for (int i = 0; i >= N; i--)
                    {
                        if (i % 2 == 0)
                        {
                            Even = Even + i;
                        }
                        else
                        {
                            Odd = Odd + i;
                        }
                    }
                }
                Console.WriteLine($"Parillisten summa on {Even} ja parittomien {Odd}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Syötit muuta kuin numeron");
                Console.ReadKey();
            }
        }
    }
}