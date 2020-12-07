using System;

namespace Easter_trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string reservationDates = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            int price = 0;
            switch (destination)
            {
                case "France":
                    switch (reservationDates)
                    {
                        case "21-23":
                            price = 30;
                            break;
                        case "24-27":
                            price = 35;
                            break;
                        case "28-31":
                            price = 40;
                            break;
                    }
                    break;
                case "Italy":
                    switch (reservationDates)
                    {
                        case "21-23":
                            price = 28;
                            break;
                        case "24-27":
                            price = 32;
                            break;
                        case "28-31":
                            price = 39;
                            break;
                    }

                    break;
                case "Germany":
                    switch (reservationDates)
                    {
                        case "21-23":
                            price = 32;
                            break;
                        case "24-27":
                            price = 37;
                            break;
                        case "28-31":
                            price = 43;
                            break;
                    }
                    break;
            }
            int totalSum = numberOfNights * price;

            Console.WriteLine($"Easter trip to {destination} : {totalSum:F2} leva.");

        }
    }
}
