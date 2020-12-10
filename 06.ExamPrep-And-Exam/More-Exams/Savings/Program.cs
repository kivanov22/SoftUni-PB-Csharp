using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double moneyNeeded = double.Parse(Console.ReadLine());

            double situationUnespected = income * 0.30;
            double sumMonthlySave = income - (moneyNeeded + situationUnespected);
            double threeMonths = months * sumMonthlySave;
            double percent =sumMonthlySave/income*100;

            Console.WriteLine($"She can save {percent:f2}%");
            Console.WriteLine($"{threeMonths:f2}");



        }
    }
}
