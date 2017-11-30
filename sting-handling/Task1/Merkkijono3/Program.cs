using System;

namespace Merkkijono3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä virke ohjelma laskee L kirjainten lukumäärän");
            string Userinput = Console.ReadLine().ToUpper();

            int i = 0;
            foreach(char x in Userinput)
            {
                if (x == 'L')
                    i++;
            }
            Console.WriteLine($"Tekstissä on {i} L-kirjainta! ");
            Console.ReadKey();
        }
    }
}
