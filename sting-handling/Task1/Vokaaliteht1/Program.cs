using System;
using System.Collections.Generic;
using System.Linq;

namespace Vokaaliteht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee virkkeesi vokaalien lukumäärän");
            string userInput = Console.ReadLine().ToLower();
            int MP = userInput.Length;

            int count = 0;

            foreach(char ch in userInput)
            {
                if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'y' || ch == 'ä' || ch == 'ö')
                {
                    count++;
                }
            }

            Console.WriteLine($"Sanassa {userInput} on {count} vokaalia");
            Console.ReadKey();
        }
    }
}
