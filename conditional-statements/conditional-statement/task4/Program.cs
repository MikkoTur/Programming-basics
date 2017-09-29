using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Define instructions
            Console.WriteLine("Ohjelma lajittelee luvut nousevaan järjestykseen. Syötä kolme lukua");

            Console.Write("Syötä Numero 1:");
            // Define variables
            string numero1 = Console.ReadLine();
            int numx = int.Parse(numero1);

            Console.Write("Syötä Numero 2:");
            string numero2 = Console.ReadLine();
            int numy = int.Parse(numero2);

            Console.Write("Syötä Numero 3:");
            string numero3 = Console.ReadLine();
            int numz = int.Parse(numero3);

            if (numx > numy)

            {

                if (numx > numz)

                {

                    if (numy > numz)

                    {

                        Console.WriteLine($"Luvut pienimmästä isoimpaan: {numz} {numy} {numx}");

                        Console.ReadKey();

                    }

                    else

                    {

                        Console.WriteLine($"Luvut pienimmästä isoimpaan: {numy} {numz} {numx}");

                        Console.ReadKey();

                    }

                }

                else

                {

                    Console.WriteLine($"Luvut pienimmästä isoimpaan: {numy} {numx} {numz}");

                    Console.ReadKey();

                }

            }

            else

            {

                if (numy > numz)

                {

                    if (numx > numz)

                    {

                        Console.WriteLine($"Luvut pienimmästä isoimpaan: {numz} {numx} {numy}");

                        Console.ReadKey();

                    }

                    else

                    {

                        Console.WriteLine($"Luvut pienimmästä isoimpaan: {numx} {numz} {numy}");

                        Console.ReadKey();

                    }

                }

                else

                {

                    Console.WriteLine($"Luvut pienimmästä isoimpaan: {numx} {numy} {numz}");

                    Console.ReadKey();

                }

            }

        }

    }

}




