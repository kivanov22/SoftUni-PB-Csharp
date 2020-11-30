using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int k = 1; // broqch

            while (k<=n) // da se izpulnqva dokato k e po malko ot vuvedenoto ot konzolata chislo
            {
                Console.WriteLine(k);
                k = k * 2 + 1; 
            }
        }
    }
}
