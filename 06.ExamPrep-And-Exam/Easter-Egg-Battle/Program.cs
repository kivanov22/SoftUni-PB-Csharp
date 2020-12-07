using System;

namespace Easter_Egg_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            bool win = false;
            while (true)
            {
                string winner = Console.ReadLine();

                if(winner=="End of battle")
                {
                    break;
                }
                if (winner == "one")
                {
                    secondPlayer -= 1;
                }
                else if (winner == "two")
                {
                    firstPlayer -= 1;
                }
                if (firstPlayer == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayer} eggs left.");
                    win = true;
                    break;

                }
                else if(secondPlayer == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayer} eggs left.");
                    win = true;
                    break;
                }
            }
            if (!win)
            {
                Console.WriteLine($"Player one has {firstPlayer} eggs left.");
                Console.WriteLine($"Player two has {secondPlayer} eggs left.");
            }
           

        }
    }
}
