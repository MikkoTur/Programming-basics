using System;

namespace _3._3Taulukkoharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma määrittelee kolme kokonaislukutaulukkoa");
            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                arrT_1[i] = rnd.Next(51);
                arrT_2[i] = rnd.Next(51);

                if (arrT_1[i] > arrT_2[i])
                {
                    arrT_3[i] = arrT_1[i];
                }
                else
                {
                    arrT_3[i] = arrT_2[i];
                }
            }
            Console.Write("        ");
            for (int i = 1; i <= 10; i++)
            {
                if (i < 10)
                {
                    Console.Write($"0{i} ");
                }
                else
                {
                    Console.Write($"{i}\n");
                }
            }
            Console.Write("        ");
            for (int i = 0; i < 15; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.Write($"arrT_1: {formatNum(arrT_1[i])} ");
                }
                else
                {
                    Console.Write($"{formatNum(arrT_1[i])} ");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.Write($"arrT_2: {formatNum(arrT_2[i])} ");
                }
                else
                {
                    Console.Write($"{formatNum(arrT_2[i])} ");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.Write($"arrT_3: {formatNum(arrT_3[i])} ");
                }
                else
                {
                    Console.Write($"{formatNum(arrT_3[i])} ");
                }
            }

            Console.ReadKey();
        }
        static string formatNum(int x)
        {
            if (x < 10)
            {
                return "0" + x.ToString();
            }
            else
            {
                return x.ToString();
            }
        }
    }
}

