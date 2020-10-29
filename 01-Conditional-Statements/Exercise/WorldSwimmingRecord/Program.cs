using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceM = double.Parse(Console.ReadLine());
            double timeSeconds = double.Parse(Console.ReadLine());

            //разстоянието в метри, което трябва да преплува и времето в секунди, за което плува разстояние от 1 м
            //съпротивлението на водата го забавя на всеки 15 м.с 12.5 секунди
            //Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието и разликата спрямо Световния рекорд
            //резултатът трябва да се закръгли надолу до най-близкото цяло число.

            double swimTime = distanceM * timeSeconds;
            double delayTime = Math.Floor(distanceM / 15) * 12.5;

            double totalTime = swimTime + delayTime;

            if(totalTime < recordSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                double neededTime = totalTime - recordSeconds;
                Console.WriteLine($"No, he failed! He was {neededTime:F2} seconds slower.");
            }
        }
    }
}
