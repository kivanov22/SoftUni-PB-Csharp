using System;

namespace Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double beachTow = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());


            double umbrellaPrice = 2.0/3*beachTow;
            double flipFlopPrice = 0.75*umbrellaPrice ;
            double beachBag = 1.0 / 3 * (beachTow + flipFlopPrice);
            double totalSum = beachTow + umbrellaPrice + flipFlopPrice + beachBag;

            totalSum -=discount / 100*totalSum;

            if (budget >= totalSum)
            {
                Console.WriteLine($"Annie's sum is {totalSum:f2} lv. She has {budget-totalSum:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {totalSum:f2} lv. She needs {totalSum-budget:f2} lv. more.");
            }
        }
    }
}
