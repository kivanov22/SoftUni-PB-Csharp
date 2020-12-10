using System;

namespace Cruise_Ship
{
    class Program
    {
        static void Main(string[] args)
        {


            string cruise = Console.ReadLine();
            string place = Console.ReadLine();
            int numberNights = int.Parse(Console.ReadLine());

            double pricePerNight = 0;



            switch (place)
            {
                case "standard cabin":
                    switch (cruise)
                    {
                        case "Mediterranean":
                            pricePerNight = 27.50;
                            break;
                        case "Adriatic":
                            pricePerNight = 22.99;
                            break;
                        case "Aegean":
                            pricePerNight = 23;
                            break;
                    }
                    break;
                case "cabin with balcony":
                    switch (cruise)
                    {
                        case "Mediterranean":
                            pricePerNight = 30.20;
                            break;
                        case "Adriatic":
                            pricePerNight = 25;
                            break;
                        case "Aegean":
                            pricePerNight = 26.60;
                            break;
                    }
                    break;
                case "apartment":
                    switch (cruise)
                    {
                        case "Mediterranean":
                            pricePerNight = 40.50;
                            break;
                        case "Adriatic":
                            pricePerNight = 34.99;
                            break;
                        case "Aegean":
                            pricePerNight = 39.80;
                            break;
                    }
                    break;
            }
            double totalPrice = pricePerNight * numberNights * 4;

            if (numberNights > 7)
            {
                totalPrice -= totalPrice * 0.25;
            }
            Console.WriteLine($"Annie's holiday in the {cruise} sea costs {totalPrice:f2} lv.");
        }
    }
}
