using System;

namespace task3
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

                // Check isNumber
                if (isNumber == true)
                {
                    

                    // program logic
                    if (evaluatedNumber % 2 == 0)
                    {
                        if (evaluatedNumber < 0)
                        {
                            Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen ja parillinen");
                        }
                        else if (evaluatedNumber > 0)
                        {
                            Console.WriteLine($"Numero {evaluatedNumber} on positiivinen ja parillinen");
                        }
                        else
                        {
                            Console.WriteLine($"Numero {evaluatedNumber} on nolla ja parillinen");                         
                        }
                    }
                    else
                    {
                        if (evaluatedNumber < 0)
                        {
                            Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen ja pariton");
                        }
                        else if (evaluatedNumber > 0)
                        {
                            Console.WriteLine($"Numero {evaluatedNumber} on positiivinen ja pariton");
                        }
                        else
                        {
                            Console.WriteLine($"Numero {evaluatedNumber} on nolla ja pariton");
                        }
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
