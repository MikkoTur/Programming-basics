using System;

namespace funktio_teht1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Funktions task 1.\n");

            int n;
            while (true) 
            {
                Console.Write("Tähtien lukumäärä: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Luku {0} ei ole sallittu luku!", n);
                }
                else
                {
                    break;
                }
            }

            string asterisks = getNAsterisks(n);
            Console.WriteLine(asterisks);
            Console.ReadKey();
        }
        static string getNAsterisks(int n)
        {
            string res = string.Empty;
            for (int i = 0; i < n; i++)
            {
                res += '*';
            }
            return res;
        }
    }

}

