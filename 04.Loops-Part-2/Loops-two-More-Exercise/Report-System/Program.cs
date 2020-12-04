using System;

namespace Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //плащания брой или кредитна карта
            //над 100 лв не може в кеш
            //под 10 лв не може с кредитна

            // програмата приключва когато се даде команда Енд или до събиране на средствата

            int expectedAmount = int.Parse(Console.ReadLine());
            //очаквана сума 
            int count = 0;
            
            int peopleCash = 0;
            int peopleCard = 0;
            double cashSum = 0;
            double cardSum = 0;
            double totalAmount = 0;
            

            string price = Console.ReadLine();//задавам си стринга извън цикъла единия вариант, другия е с expectedAmount

            while (price !="End")//expectedAmount>=totalAmount
            {
                //string price = Console.ReadLine();
                
                int priceNumber = int.Parse(price);// преобразувам на число
                count++;   //брояч за да редува пари и карти

                if (count % 2 != 0)//кеш
                {
                    if (priceNumber > 100)// няма равно само по малко е
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        cashSum += priceNumber;
                        peopleCash++;
                    }
                }
                else if(count%2==0)//карта
                {
                    if (priceNumber < 10)// няма равно само по малко е
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        cardSum += priceNumber;
                        peopleCard++;
                    }
                }
                totalAmount = cardSum + cashSum;  // сумираме от кеша и картата
                price = Console.ReadLine();// пак стринга за да може по надолу да се зададе за енд какво да изписва



                if (expectedAmount<=totalAmount) //средните стойности
                {
                    Console.WriteLine($"Average CS: {(cashSum / peopleCash):f2}");
                    Console.WriteLine($"Average CC: {(cardSum / peopleCard):f2}");
                    break;
                }
               

                


            }
            if (price == "End") 
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
