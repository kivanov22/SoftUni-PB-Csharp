using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            // условия
            // За да се наспи добре, нормата за игра на Том е 30 000  минути в година. 
            // Времето за игра на Том зависи от почивните дни на стопанина му:
            //.Когато е на работа, стопанинът му си играе с него по 63 минути на ден.
            //Когато почива, стопанинът му си играе с него по 127 минути на ден.

            //5.  да намериме от 365 - почивни дни
            //6. да намериме работни дни
            //7. разлика от нормата 30 000
            //8. минути преобразуваме в часове и минути

            int offDays = int.Parse(Console.ReadLine()); //почивни дни

            int workDays = 365 - offDays;  //работни дни

            int minutesOffdays = offDays * 127; // време за игра през почивни дни
            int minutesWorkdays = workDays * 63; // време за игра през работни дни

            int totalTime = minutesOffdays + minutesWorkdays;  // общо време

            int differenceNorm = 30000 - totalTime;    //Норма
            double minutesHours = Math.Abs(differenceNorm / 60);  // часове math.abs за положителни числа
            double minutesMins = Math.Abs(differenceNorm % 60);   //минути
           
            
            if (totalTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{minutesHours} hours and {minutesMins} minutes more for play");
            }
            else if (totalTime < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{minutesHours} hours and {minutesMins} minutes less for play");
            }


        }
    }
}
