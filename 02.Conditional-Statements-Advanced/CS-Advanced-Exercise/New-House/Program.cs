using System;
using System.Diagnostics.Tracing;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.input
            //2.calculate how much
            //3.check discounts 
            //4.see if they meet the budget
            //цвете                Роза    Далия   Лале    Нарцис  Гладиола
            //Цена на брой в лева   5      3.80    2.80    3       2.50

            //1.input
            string typeFlower = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            
            double price = 0;
            
            
            double totalSum = 0;

            switch (typeFlower)
            {
                case "Roses":
                    price = 5;
                    
                    break;
                case "Dahlias":
                    price = 3.80;
                    
                    break;
                case "Tulips":
                    price = 2.80;
                   
                    break;
                case "Narcissus":
                    price = 3;
                    
                    break;
                case "Gladiolus":
                    price = 2.50;
                    
                    break; 
            }
            totalSum = numberFlowers * price;
                
            if(typeFlower == "Roses" && numberFlowers > 80)
            {
                totalSum = totalSum - (totalSum * 0.1);

            }   
            else if (typeFlower =="Dahlias"&& numberFlowers > 90)
            {
                totalSum = totalSum - (totalSum * 0.15);
            }
            else if(typeFlower == "Tulips" && numberFlowers > 80)
            {
                totalSum = totalSum - (totalSum * 0.15);
            }
            else if(typeFlower== "Narcissus"&&numberFlowers < 120)
            {
                totalSum = totalSum + (totalSum * 0.15);
            }
            else if(typeFlower == "Gladiolus"&& numberFlowers < 80)
            {
                totalSum = totalSum + (totalSum * 0.2);
            }
            
            if (totalSum <= budget)    //<= bez ravno 50/100 judge
            {
                double sumNeeded = budget - totalSum;
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {typeFlower} and {sumNeeded:f2} leva left.");
            }
            else if (totalSum > budget)
            {
                double sumLeft = totalSum - budget;

                Console.WriteLine($"Not enough money, you need {sumLeft:f2} leva more.");
            }
            
            
            



        }
    }
}
