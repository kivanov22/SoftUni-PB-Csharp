using System;

namespace Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberEasterBread = int.Parse(Console.ReadLine());
             string topChef = "";
            int maxScore = 0;

            for (int i = 1; i <= numberEasterBread; i++)
            {
                string nameBaker = Console.ReadLine();
                 string score = Console.ReadLine();
                int sum = 0;

                while (score!="Stop")
                {
                    sum += int.Parse(score);
                    score = Console.ReadLine();
                }
                Console.WriteLine($"{nameBaker} has {sum} points.");

                if (sum > maxScore)
                {
                    maxScore = sum;
                    topChef = nameBaker;
                    Console.WriteLine($"{nameBaker} is the new number 1!");
                }
            }
            Console.WriteLine($"{topChef} won competition with {maxScore} points!");


        }
    }
}
