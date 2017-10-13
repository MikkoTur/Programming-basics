using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee ensimmäisen parillisen ja parittoman lukujen summan:");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number);
            int i = 0;
            int parillinen = 0;
            int pariton = 0;
            while (i <= number)
            {
                if(i % 2 == 0)
                {
                    parillinen = parillinen + i;
                }
                else
                {
                    pariton = pariton + i;
                }
                i = i + 1;
                
            }

            Console.WriteLine($"lukujen summa: {parillinen} ja {pariton}");
            Console.ReadKey();
        }
    }
}
