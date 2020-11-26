using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Premiere – премиерна прожекция, на цена 12.00 лева.
            //•	Normal – стандартна прожекция, на цена 7.50 лева.
            //•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.

            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double income = 0.0;

            switch (type)
            {
                case "Premiere":
                    income = rows * columns * 12;
                    break;
                case "Normal":
                    income = rows * columns * 7.50;
                    break;
                case "Discount":
                    income = rows * columns * 5;
                    break;
            }
            Console.WriteLine($"{income:f2} leva");

        }
    }
}
