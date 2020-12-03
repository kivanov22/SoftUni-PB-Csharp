using System;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
            while(destination != "End") // първо условие за енд от конзолата
            {
                double budget = double.Parse(Console.ReadLine()); // бюджета

                double savedMoney = double.Parse(Console.ReadLine()); //спестените пари
                double totalMoneySaved = savedMoney; //нова променлива присвояваща спестените пари

                while (totalMoneySaved < budget) // второ условие бюджета да е по голям от спестените пари
                {
                     savedMoney = double.Parse(Console.ReadLine());
                     totalMoneySaved += savedMoney;   
                }
                Console.WriteLine($"Going to {destination}!");


                destination = Console.ReadLine(); 


            }
        }
    }
}
