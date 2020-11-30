using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;
            int k = 0;

            while (k != numbers)
            {
                int n = int.Parse(Console.ReadLine());

                if (k == numbers)//prekusvame cikula ako broq na chisla k e po golqm ot purvonachalniq zadaden broi ot konzolata
                {

                    break; // spirane na cikula
                }


                if (n < minNumber) // namirame nai golqmoto chislo
                {
                    minNumber = n;

                }


                k++; //broqch na chisla
            }
            Console.WriteLine(minNumber);

        }
    }
}
