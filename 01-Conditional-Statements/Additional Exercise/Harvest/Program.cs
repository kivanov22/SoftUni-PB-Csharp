using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyard = int.Parse(Console.ReadLine());
            double grapes = double.Parse(Console.ReadLine());
            int littersWine = int.Parse(Console.ReadLine());
            int numberWorkers = int.Parse(Console.ReadLine());

            // общо грозде 
            double totalGrape = vineyard * grapes;

            //Wine
            double wine = totalGrape * 0.40 / 2.5;

            if (wine >= littersWine)
            {
                double litterLeft = wine - littersWine;
                double littersPerson = litterLeft / numberWorkers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(litterLeft)} liters left -> {Math.Ceiling(littersPerson)} liters per person.");
            }
            else if (wine < littersWine)
            {
                double wineNeeded = littersWine - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeeded)} liters wine needed.");
            }

        }
    }
}
