using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Total sum of the toys.
            // 2.How many toys.
            // 2.check if more than 50 toys and discount 
            // 3.Total money - 10% rent for shop
            // 4.Calculate if she has enough money for vacation

            //•	Пъзел - 2.60 лв.
            //•	Говореща кукла -3 лв.
            //•	Плюшено мече -4.10 лв.
            //•	Миньон - 8.20 лв.
            //•	Камионче - 2 лв.

            double priceVacation = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double pricePuzzles = puzzles * 2.60;
            double priceDolls = dolls * 3;
            double priceBears = bears * 4.10;
            double priceMinions = minions * 8.20;
            double priceTrucks = trucks * 2;

            // total price of all toys
            double totalProfit = pricePuzzles + priceDolls + priceBears + priceMinions + priceTrucks;

            // How many toys
            int numberToys = puzzles + dolls + bears + minions + trucks;

            //Discount 
            if (numberToys >= 50)
            {
                totalProfit = totalProfit - 0.25 * totalProfit;

            }
            //rent 
            totalProfit = totalProfit * 0.9;

            //check if enought money for vacation

            if (totalProfit >= priceVacation)
            {
                Console.WriteLine($"Yes! {(totalProfit - priceVacation):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(priceVacation - totalProfit):f2} lv needed.");
            }


        }
    }
}
