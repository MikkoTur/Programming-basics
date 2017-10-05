using System;

namespace Task_2._1
{
    class Program

    {

        static void Main(string[] args)

        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            bool isNumber;
            int age;
            string extra;

            // repeat until user gives positive number for age
            do
            {
                Console.WriteLine("Maatalousnäyttelyn lipunmyynti.");
                Console.Write("Ikä: ");

                if (isNumber = int.TryParse(Console.ReadLine(), out age))
                {
                    if (age > 0)
                    {
                        if (age < 7)
                        {
                            Console.WriteLine("Alle 7 vuotiaat ilmaiseksi!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Oletko (V)arusmies, (O)piskelija, sekä (M)TK:n jäsen? EI / V / O / M / OM");
                            extra = Console.ReadLine();
                            if (extra.ToLower() == "om")
                            {
                                Console.WriteLine("Lipun hinta on 6.40 euroa.");
                                Console.ReadKey();
                            }
                            else if (age >= 65 || age <= 15 || extra.ToLower() == "v")
                            {
                                Console.WriteLine("Lipun hinta on 8 euroa.");
                                Console.ReadKey();
                            }
                            else if (extra.ToLower() == "o")
                            {
                                Console.WriteLine("Lipun hinta on 8.80 euroa.");
                                Console.ReadKey();
                            }
                            else if (extra.ToLower() == "m")
                            {
                                Console.WriteLine("Lipun hinta on 13.60 euroa.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Lipun hinta on 16 euroa.");
                                Console.ReadKey();
                            }
                        }
                    }
                }
            }
            while (!isNumber || age < 0);
        }
    }
}