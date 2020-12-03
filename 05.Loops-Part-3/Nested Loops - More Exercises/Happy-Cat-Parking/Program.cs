using System;

namespace Happy_Cat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sum = 0.0;
            double price = 0.0;

            for (int daysCount = 1; daysCount <= days; daysCount++)
            {
                for (int hoursCount = 1; hoursCount <= hours; hoursCount++)
                {
                    if (daysCount % 2 == 0 && hoursCount%2!=0)
                    {
                        price += 2.50;
                        sum += 2.50;
                    }
                   else if(daysCount%2 !=0 && hoursCount % 2 == 0)
                    {
                        price += 1.25;
                        sum += 1.25;
                    }
                    else// if(i%2==0 && k%2==0 || i % 2 != 0 && k % 2 != 0)
                    {
                        price += 1;
                        sum += 1;
                    }
                    
                }
                Console.WriteLine($"Day: {daysCount} - {price:f2} leva");// ne bqh izkaral outputa ot ediniq cikal
                price = 0;
            }
            
            Console.WriteLine($"Total: {sum:f2} leva");
        }
    }
}
