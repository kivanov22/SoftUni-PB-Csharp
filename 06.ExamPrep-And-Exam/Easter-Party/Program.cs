using System;

namespace Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberGuests = int.Parse(Console.ReadLine());
            double priceOneGuest = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double price = 0;

            if(numberGuests>=10 && numberGuests <= 15)
            {
                //15%
                priceOneGuest = priceOneGuest - 0.15 * priceOneGuest;
            }
            else if(numberGuests>15 && numberGuests <= 20)
            {
                //20%
                priceOneGuest = priceOneGuest - 0.20 * priceOneGuest;
            }
            else if (numberGuests > 20)
            {
                //25%
                priceOneGuest = priceOneGuest - 0.25 * priceOneGuest;
            }

            double cakeDiscount = budget* 0.10 ;
            double totalSumParty = numberGuests * priceOneGuest + cakeDiscount;

            if (totalSumParty > budget)
            {
                Console.WriteLine($"No party! {totalSumParty-budget:f2} leva needed.");
            }
            else
            {
                Console.WriteLine($"It is party time! {budget-totalSumParty:f2} leva left.");
            }


        }
    }
}
