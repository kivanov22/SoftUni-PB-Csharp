using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int coins1 = int.Parse(Console.ReadLine());
            int coins2 = int.Parse(Console.ReadLine());
            int cash = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int a = 0; a <= coins1; a++)
            {
                for (int b = 0; b <= coins2; b++)
                {
                    for (int c = 0; c <= cash; c++)
                    {

                        if (a*1+b*2+c*5 == sum) // да ги умножа по 1,2,5 - вместо по coins1,coins2,cash
                        {
                        Console.WriteLine($"{a} * 1 lv. + {b} * 2 lv. + {c} * 5 lv. = {sum} lv.");
                            break;   
                        }
                    }
                }
            }

        }
    }
}
