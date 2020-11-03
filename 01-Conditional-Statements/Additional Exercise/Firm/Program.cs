using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. needed hours to work
            //2. needed days to work
            //3. 10% days workers go to practice
            //4. one work day in firm = 8h.
            //5. off work place =2 hrs


            int neededTime = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double percent = days - (0.1 * days); //10% izchislenie ot dnite
            double workHours = Math.Floor(percent * 8);

            double workersOffTime = workers * 2 * days; /// bez skobi

            double totalHours = Math.Floor(workHours + workersOffTime);

            if (totalHours >= neededTime)   /// = bqh izpusnal
            {
                double hoursLeft = totalHours - neededTime;
                Console.WriteLine($"Yes!{hoursLeft} hours left.");
            }
            else if (totalHours < neededTime)
            {
                double notEnough = neededTime - totalHours;
                Console.WriteLine($"Not enough time!{notEnough} hours needed.");
            }
        }
    }
}
