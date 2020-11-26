using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.input 
            //2.how is much is budget , and what season
            //3.where he will go , depends on budget and how much he will spend
            //4.budget sets the destination
            //5.season sets how much he will spend and where he will go
            //6. if he go Europe he will stay in hotel
            //7.every destination has different price for hotel,camping
            //8.summer and winter
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double moneySpend = 0;
            string destination = "";
            string place = "";


            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer":
                        destination = "Bulgaria";
                        place = "Camp";
                        //procenti 30%
                        //priceBoat = priceBoat *0.95;
                        moneySpend = budget * 0.30;

                        break;
                    case "winter":
                        //procenti  70%
                        destination = "Bulgaria";
                        place = "Hotel";
                        moneySpend = budget * 0.70;
                        break;
                }
            }
           else if (budget <= 1000)
            {
                switch (season)
                {
                    case "summer":
                        destination = "Balkans";
                        place = "Camp";
                        moneySpend = budget * 0.40;
                        //procenti 40%
                        break;
                    case "winter":
                        destination = "Balkans";
                        place = "Hotel";
                        //procenti 80%
                        moneySpend = budget * 0.80;
                        break;
                }
            }
           else if (budget > 1000)
            {
                switch (season)
                {
                    case "summer":
                        destination = "Europe";
                        place = "Hotel";
                        //procenti 90 %
                        moneySpend = budget * 0.90;
                        break;
                    case "winter":
                        destination = "Europe";
                        place = "Hotel";
                        moneySpend = budget * 0.90;
                        //procenti 90%
                        break;
                }
            }
                        string finalDestination = destination;
                        string finalPlace = place;
                        double totalSum = moneySpend;

                        //Europe only hotels
                        //If summer - camping ,if winter hotel
                        Console.WriteLine($"Somewhere in {finalDestination}");
                        Console.WriteLine($"{finalPlace} - {totalSum:f2}");
                    }
                }
            }
        
    

       
    

