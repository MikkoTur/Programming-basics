using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Define instructions
            Console.WriteLine("Ohjelma selvittää onko syötetty luku parillinen tai pariton.");
            bool isNumber;
            do
            {
                Console.Write("Syötä luku: ");
                // defain variables
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);

                if (isNumber == true)
                {
                    // program logic
                    if (evaluatedNumber % 2 == 0)
                    {
                        Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on parillinen");
                    }
                    else
                    {
                        Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on pariton");
                    }
                }
                else
                {
                    Console.WriteLine("Syötit muuta kuin numeroita!");
                }

            } while (isNumber == false);
            Console.ReadKey();
        }

    }
}