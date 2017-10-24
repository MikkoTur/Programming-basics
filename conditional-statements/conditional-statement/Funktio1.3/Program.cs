using System;

namespace Funktio1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int retNumber = numberFromRange(1, 100);

            Console.WriteLine($"Syöttämäsi luku {retNumber} on sallittu");
            Console.ReadKey();
        }
        static int numberFromRange(int lowerbound, int upperbound)
        {
            bool isNumber;
            int input = 0;
            int ret = 0;

            do
            {
                Console.WriteLine("Syötä numero väliltä 1-100: ");
                isNumber = int.TryParse(Console.ReadLine(), out input);

                // Tarkistetaan onko luku sallitulta väliltä
                if (input >= lowerbound && input <= upperbound)
                {
                    ret = input;
                    break;
                }
                else
                {
                    // Luku ei ole sallittu tai ei ole numero, looppi alkaa alusta
                    isNumber = false;
                }
            }
            while (isNumber == false);
            return ret;
        }
    }
}
