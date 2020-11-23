using System;
using System.Xml.Schema;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.input

            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double price = 0;       //price promenliva
            double discount = 0;    //discount promenlinva

            switch (roomType)
            {
                case "room for one person":
                    price = 18;
                    break;
                case "apartment":
                    price = 25;
                    if (days < 10)
                    {
                        discount = 0.30;                            //switch case moje mejdu casove if da se slaga
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.35;
                    }
                    else if (days > 15)
                    {
                        discount = 0.50;
                    }
                    break;
                case "president apartment":
                    price = 35;
                    if (days < 10)
                    {
                        discount = 0.10;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.15;
                    }
                    else if (days > 15)
                    {
                        discount = 0.20;
                    }
                    break;
            }
            //2.total price 
            double totalPrice = price * (days - 1);                 //dobavqne na discount

            totalPrice -= totalPrice * discount;                    //premahvane na procent ot sumata
            //3.Discount add to price

            if (feedback == "positive")
            {
                totalPrice += totalPrice * 0.25;                //proverka za feedback
            }
            else
            {
                totalPrice -= totalPrice * 0.10;
            }

            //4.print output

            Console.WriteLine($"{totalPrice:f2}");















        }

    }
}

