using System;
using System.Drawing;

namespace Cruise_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int gamesPlayed = int.Parse(Console.ReadLine());


            double countVolleyBallGames = 0;
            double volleyballPoints = 0;

            double countTennisGames = 0;
            double tennisPoints = 0;

            double countBadmintonGames = 0;
            double badmintonPoints = 0;


            for (int games = 1; games <= gamesPlayed; games++)
            {
                string gameName = Console.ReadLine();
                double points = int.Parse(Console.ReadLine());

                


                switch (gameName)
                {
                    case "volleyball":
                        volleyballPoints+=points+ points*0.07;
                        countVolleyBallGames++;
                        break;
                    case "tennis":
                        tennisPoints += points + points * 0.05;
                        countTennisGames++;
                        break;
                    case "badminton":
                        badmintonPoints += points + points * 0.02;
                        countBadmintonGames++;
                        break;
                }

                
            }
            double averageVolleyball = volleyballPoints / countVolleyBallGames;
            double averageTennis = tennisPoints / countTennisGames;
            double averageBadminton = badmintonPoints / countBadmintonGames;

            double totalSum = Math.Floor(volleyballPoints + tennisPoints + badmintonPoints);

            if (averageVolleyball >= 75 && averageTennis >= 75 && averageBadminton >= 75)
            {
                Console.WriteLine($"Congratulations, {name}! You won the cruise games with {totalSum} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {name}, you lost. Your points are only {totalSum}.");
            }


        }
    }
}
