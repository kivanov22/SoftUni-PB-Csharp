using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMashine = double.Parse(Console.ReadLine());
            int moneyDolls = int.Parse(Console.ReadLine());


            int savedMoney = 0;
            int dollsNumber = 0;
            int brother = 0;
            int totalSavedMoney = 0;

            //1.input
            //2.for cycle for dolls odd
            //3.for cycle for money even
            //4.total sum 
            //5. years Lily takes money her brother takes -1
            //6.dolls sold over the years * price of dooll + totalsum

            for (int year = 1; year <= age; year++)
            {

                if (year % 2 == 0)
                {
                    savedMoney += 10;
                    totalSavedMoney += savedMoney;
                    brother += 1;

                }
                else
                {

                    dollsNumber += 1;
                }
            }


            int totalDolls = moneyDolls * dollsNumber;
            int moneyLeft = (totalSavedMoney + totalDolls) - brother;


            if (moneyLeft >= washingMashine)
            {
                double moneyAfter = moneyLeft - washingMashine;
                Console.WriteLine($"Yes! {moneyAfter:f2}");
                
            }

            else 
            
            {
                //if (washingMashine>moneyLeft)
                double neededMoney = washingMashine - moneyLeft;
                Console.WriteLine($"No! {neededMoney:f2}");
            }

        }
    }
}

