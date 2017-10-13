using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee. Anna luku, mistä summa lasketaan:");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number);
            int i = 0;
            int num = 0;
            while (i < number)
            {
                i = i + 1;
                num = num + i;
                
            } 

            Console.WriteLine($"lukujen summa: {num}"); 
            Console.ReadKey();
        }
    }
}
