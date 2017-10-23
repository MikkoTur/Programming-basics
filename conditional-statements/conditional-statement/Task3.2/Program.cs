using System;

namespace Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9");
            int number = 1;
            int sum;
            int multip = 1;

            for (number = 1; number <= 9; number++)
            {
                for (multip = 1; multip <= 9; multip++)
                {
                    sum = number * multip;
                    Console.WriteLine($"{number} x {multip} = {sum}");
                }
            }
            Console.ReadKey();

            /*
             while(number <= 9)
             {
             do shit
             while(multip <=9)
             {
                do shit 2
                multip++;
             }
             number++;
             multip = 1;
             }
             */
        }
    }
}