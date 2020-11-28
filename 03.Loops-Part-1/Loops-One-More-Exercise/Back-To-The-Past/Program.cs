using System;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double nasledstvo = double.Parse(Console.ReadLine());
            int yearLiving = int.Parse(Console.ReadLine());

            
            int age = 18;
            int oddYear = 0;
            

            for (int pastYear = 1800; pastYear <= yearLiving; pastYear++)
            {
               
                if (pastYear % 2 == 0)
                {
                    nasledstvo -= 12000;
                    
                }
                else
                {
                    
                    oddYear = 12000 + age * 50;
                    nasledstvo = nasledstvo - oddYear;
                   

                }
                age += 1; // bqh slojil godinite samo v nechetnoto i mi se gubeha 1000 ot nasledstvoto

            }
           // double moneyLeft = moneyGift - totalSum;

            if( nasledstvo>=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {nasledstvo:f2} dollars left.");
            }
            else
            {
                // double moneyNeeded = totalSum - moneyGift;
                nasledstvo = Math.Abs(nasledstvo);
                Console.WriteLine($"He will need {nasledstvo:f2} dollars to survive.");
            }

        }
    }
}
