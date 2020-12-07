using System;

namespace Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int muffins = int.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int kgCookies = int.Parse(Console.ReadLine());

            // Козунак  – 3.20 лв.
            //•	Яйца –  4.35 лв.за кора с 12 яйца
            //•	Курабии – 5.40 лв.за килограм
            //•	Боя за яйца - 0.15 лв.за яйце

            double priceMuffins =1.0*  muffins*3.20;
            double priceEggs = 1.0 * eggs * 4.35;
            double priceCookies = 1.0 * kgCookies * 5.40;
            double paintEggs = 1.0 * eggs * 12 * 0.15;
            double totalPrice = priceMuffins + priceEggs + priceCookies + paintEggs;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
