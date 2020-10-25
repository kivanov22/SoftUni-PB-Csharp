using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            //разходи -> декор и обекла
            //декор = 10% от бюджета
            //обекла = бр. статисти * ед. цена за костюм
            //проверка дали има отстъпка - 10%
            //разходи = декор + обекла
            //проверка дали бюджета стига да покрие разходите

            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double pricePerStatist = double.Parse(Console.ReadLine());

            
            
            double dekor = 0.10 * budget;
            double clothes = statists * pricePerStatist;

            
            if (statists > 150)
            {
                clothes = clothes - 0.10 * clothes;
            }

            double expanses = dekor + clothes;

            if(budget >= expanses)
            {

                double moneyLeft = budget - expanses;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
              

            }
            else
            {
                double moneyNeeded = expanses - budget;
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }

        }
    }
}
