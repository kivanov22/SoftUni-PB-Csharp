using System;
using System.Threading;

namespace Baking_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            int totalGoods = 0;
            double totalMoney = 0;

            for (int i = 1; i <= numberOfPeople; i++)
            {

                string name = Console.ReadLine();
                
                

                int countCookies = 0;
                int countWaffles = 0;
                int countCakes = 0;
                string input = Console.ReadLine();

                while (input!="Stop baking!")
                {

                    int numberOfCakes = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case "cookies":
                            countCookies += numberOfCakes;
                            break;
                        case "waffles":
                            countWaffles+=numberOfCakes;
                            break;
                        case "cakes":
                            countCakes += numberOfCakes;
                            break;
                    }

                    input = Console.ReadLine();
                }
                totalGoods += countCakes + countCookies + countWaffles;
                totalMoney += countCakes * 7.80 + countCookies * 1.50 + countWaffles * 2.30;


                Console.WriteLine($"{name} baked {countCookies} cookies, {countCakes} cakes and {countWaffles} waffles.");
                
            }
            Console.WriteLine($"All bakery sold: {totalGoods}");
            Console.WriteLine($"Total sum for charity: {totalMoney:f2} lv.");
        }
    }
}
