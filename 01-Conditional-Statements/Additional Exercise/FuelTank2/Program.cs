using System;
using System.Security.Cryptography.X509Certificates;

namespace FuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Бензин – 2.22 лева за един литър,
            //•	Дизел – 2.33 лева за един литър
            //•	Газ – 0.93 лева за литър
            
            // fix calculation

            //discounts
            // литър гориво: 18 ст.за литър бензин, 12 ст.за литър дизел и 8 ст.за литър газ

            //20 и 25 литра включително, той получава 8 процента отстъпка от крайната цена, при повече от 25 литра гориво, той получава 10 процента отстъпка от крайната цена.

            string fuelType = Console.ReadLine();
            double fuelAmount = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double gas = 0.93;
            double diesel = 2.33;
            double gasoline = 2.22;

            

            double card1 = 0.08;
            double card2 = 0.10;

            if(fuelType == "Gas" && clubCard == "Yes" && fuelAmount==20 && fuelAmount ==25)  // 3 - variants for gas => smenq ==
            {
                double priceFill = gas - card1;          
                double totalFuel = priceFill * fuelAmount;
                double hasCard = totalFuel - 0.10 * totalFuel;
                Console.WriteLine($"{hasCard:f2} lv.");
            }
           else if(fuelType == "Gas" && clubCard == "No")                     
            {

                double totalFuel = gas * fuelAmount;
                double hasCard = totalFuel - 0.10 * totalFuel;
                Console.WriteLine($"{totalFuel:f2} lv.");
            }
           else if(fuelType == "Gas" && fuelAmount > 25 && clubCard=="Yes")
            {
                double priceFill = gas - card2;
                double totalFuel = priceFill * fuelAmount;
                double hasCard = totalFuel - 0.10 * totalFuel;

                Console.WriteLine($"{hasCard:f2} lv.");
                //Gas Case
            }
            if (fuelType == "Gasoline" && clubCard == "Yes" && fuelAmount == 20 && fuelAmount == 25) 
            {
                double priceFill = gasoline - card1;
                double totalFuel = priceFill * fuelAmount;
                double hasCard = totalFuel - 0.10 * totalFuel;
                Console.WriteLine($"{hasCard:f2} lv.");
            }
            else if (fuelType == "Gasoline" && clubCard == "No")
            {

                double totalFuel = gasoline * fuelAmount;
                double hasCard = totalFuel - 0.10 * totalFuel;
                Console.WriteLine($"{totalFuel:f2} lv.");
            }
            else if (fuelType == "Gasoline" && fuelAmount > 25 && clubCard == "Yes")
            {
                double priceFill = gasoline - card2;
                double totalFuel = priceFill * fuelAmount;
                double hasCard = totalFuel - 0.10 * totalFuel;

                Console.WriteLine($"{hasCard:f2} lv.");
                //Gasoline Case
            }
            if (fuelType == "Diesel" && clubCard == "Yes" && fuelAmount == 20 && fuelAmount == 25)  
            {
                double priceFill = diesel - card1;
                double totalFuel = priceFill * fuelAmount;
                double hasCard = totalFuel - 0.10 * totalFuel;
                Console.WriteLine($"{hasCard:f2} lv.");
            }
            else if (fuelType == "Diesel" && clubCard == "No")
            {

                double totalFuel = diesel * fuelAmount;
                double hasCard = totalFuel - 0.10 * totalFuel;
                Console.WriteLine($"{totalFuel:f2} lv.");
            }
            else if (fuelType == "Diesel" && fuelAmount > 25 && clubCard == "Yes")
            {
                double priceFill = diesel - card2;
                double totalFuel = priceFill * fuelAmount;
                double hasCard = totalFuel - 0.10 * totalFuel;

                Console.WriteLine($"{hasCard:f2} lv.");
                //Diesel Case
            }

        }
    }
}
