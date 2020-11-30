using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int k = 0;

            while (k !=numbers)
            {
              int n = int.Parse(Console.ReadLine());

                if (k == numbers)//prekusvame cikula ako broq na chisla k e po golqm ot purvonachalniq zadaden broi ot konzolata
                {
                    
                    break; // spirane na cikula
                }


                if (n > maxNumber) // namirame nai golqmoto chislo
                {
                    maxNumber = n;
                   
                }
               

                k++; //broqch na chisla
            }
            Console.WriteLine(maxNumber);

        }
    }
}
