using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int countSpendDays = 0; // dni harchi posledovatelno
            int countTotalDays = 0; // dni koito izvurshva nqkvo deinost

            while (availableMoney <tripPrice)
            {
                string action = Console.ReadLine(); // spend or save
                double price = double.Parse(Console.ReadLine()); //suma
                countTotalDays++;


                if(action == "save") // kogato spestqva
                {
                    availableMoney += price;
                    countSpendDays = 0;
                }
                else if(action == "spend")//kogato harchi
                {
                    countSpendDays++;
                    availableMoney -= price;
                    if(availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
                if (countSpendDays == 5) //harchila pet posledovatelni dni sluchai
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(countTotalDays);
                    break;

                }
            }
            if(availableMoney >= tripPrice)//kogato parite i stigat
            {
                Console.WriteLine($"You saved the money for {countTotalDays} days.");

            }


        }
    }
}
