using System;
using System.Diagnostics.Tracing;
using System.Drawing;

namespace Darts_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());
            int count = 0;


            while (true)
            {
                string sector = Console.ReadLine();
                count++;
                
                if (sector == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {count} moves!");
                    break;

                }

                int points = int.Parse(Console.ReadLine());


                switch (sector)
                {
                    case "number section":
                        startingPoints -= points;
                        break;
                    case "double ring":
                        points *= 2;
                        startingPoints -= points;

                        break;
                    case "triple ring":
                        points *= 3;
                        startingPoints -= points;
                        break;
                    
                }
                
               
                
                if (startingPoints== 0)
                {

                    Console.WriteLine($"Congratulations! You won the game in {count} moves!");
                    break;
                }
                else if (startingPoints < 0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(startingPoints)}.");
                    break;
                }
            }
           
        }
    }
}
