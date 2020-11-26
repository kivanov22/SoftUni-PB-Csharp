using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());


            //1.check season
            //2.check number
            //3.Calculate budget
            double priceBoat = 0;
            

            if(season == "Spring")
            {
                priceBoat = 3000;

            }
            else if(season == "Summer" || season == "Autumn")
            {
                priceBoat = 4200;
            }
            else if(season == "Winter")
            {
                priceBoat = 2600;
            }
            

            if(fisherman <= 6)
            {
                priceBoat = priceBoat* 0.90;
                
                
            }
            else if(fisherman >=7 && fisherman <= 11)
            {
                priceBoat = priceBoat* 0.85;
            }
            else if(fisherman >= 12)  //=
            {
                priceBoat = priceBoat* 0.75;
            }

            

            if (fisherman % 2 == 0 && season != "Autumn")//== "Spring" && season == "Winter" && season == "Summer
            {

                priceBoat = priceBoat *0.95;

                
            }
            double totalSum = priceBoat; //tova beshe predi gornata proverka i ne vzimashe stoinosta

            //   totalSum = totalSum - (totalSum * 0.15);
            if (budget >= totalSum)
            {
                double moneyLeft = budget - totalSum;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left."); 
            }
            else if(budget < totalSum)
            {
                double moneyNeeded = totalSum - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
            
        }
    }
}
