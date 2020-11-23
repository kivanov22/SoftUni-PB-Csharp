using System;


namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double Price = 0;

            if (city == "Sofia")
            {
                if (product == "coffee") 
                {
                    Price = 0.50; 
                }

               else if (product == "water") 
                {
                    Price = 0.80;
                }

               else if (product == "beer") 
                {
                    Price = 1.20;
                }
              else  if (product == "sweets") 
                {
                    Price = 1.45;
                }
              else  if (product == "peanuts") 
                {
                    Price = 1.60;
                }
                
            }
        
        
           else if(city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Price = 0.40;
                }

                else if (product == "water")
                {
                    Price = 0.70;
                }

                else if (product == "beer")
                {
                    Price = 1.15;
                }
                else if (product == "sweets")
                {
                    Price = 1.30;
                }
                else if (product == "peanuts")
                {
                    Price = 1.50;
                }
            }
         
          else  if(city == "Varna")
            {
                if (product == "coffee")
                {
                    Price = 0.45;
                }

                else if (product == "water")
                {
                    Price = 0.70;
                }

                else if (product == "beer")
                {
                    Price = 1.10;
                }
                else if (product == "sweets")
                {
                    Price = 1.35;
                }
                else if (product == "peanuts")
                {
                    Price = 1.55;
                }
            }
            double totalPrice = amount * Price;
            Console.WriteLine(totalPrice);
        }
    }
}



//     coffee       water	beer	sweets	peanuts
//     0.50	        0.80	1.20	1.45	1.60   sofia
//     0.40      	0.70	1.15	1.30	1.50   plovdiv
//     0.45	        0.70	1.10	1.35	1.55   varna