using System;

namespace Task4._4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ohjelma heittää kolikkoa.\nKerro kuinka monta kertaa haluat kolikkoa heitettävän: ");

            string luku = Console.ReadLine();
            int num = int.Parse(luku);
            int kruuna = 0;
            int klaava = 0;
            Random rnd = new Random();

            for (int i = 1; i <= num; i++)
            {
                if (rnd.Next(2) == 1)
                {
                    klaava += 1;
                }
                else
                {
                    kruuna += 1;
                }
            }
            Console.Write($"Kolikkoa on heitetty {num} kertaa. \n");
            Console.WriteLine($"Kruunia tuli {kruuna} ja klaavoja {klaava}.");
            Console.ReadKey();

        }
    }
}
