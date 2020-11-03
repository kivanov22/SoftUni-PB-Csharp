using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. calculate sum of order
            //2. check if order covers money for present
            //3.  5% from total sum
            //4.

            int magnoliqNumber = int.Parse(Console.ReadLine());
            int zumbulNumber = int.Parse(Console.ReadLine());
            int roziNumber = int.Parse(Console.ReadLine());
            int kaktusNumber = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double priceMagnoliq = magnoliqNumber * 3.25;
            double priceZumbul = zumbulNumber * 4;
            double priceRozi = roziNumber * 3.50;
            double priceKaktus = kaktusNumber * 8;


            double totalPrice = priceMagnoliq + priceZumbul + priceRozi + priceKaktus;  // 44 total
            double percentTotal = totalPrice * 0.05;             // 5%  ot 44 = 5/100 * 44 
            double profit = totalPrice - percentTotal;             //profit
                        
            // check if enough money for present  
            
            if(profit >= presentPrice)
            {
                double enoughMoney = profit -presentPrice;            

                Console.WriteLine($"She is left with {Math.Floor(enoughMoney)} leva.");
            }
            else if( presentPrice > profit)
            {
                double neededMoney = presentPrice - profit;

                Console.WriteLine($"She will have to borrow {Math.Ceiling(neededMoney)} leva.");
            }
        }
    }
}
