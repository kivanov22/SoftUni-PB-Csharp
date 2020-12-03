using System;

namespace Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCouple = int.Parse(Console.ReadLine());
            int firstSecondCouple = int.Parse(Console.ReadLine());
            int diffFirstCouple = int.Parse(Console.ReadLine());
            int diffSecoundCouple = int.Parse(Console.ReadLine());

            int sumFirst = firstCouple + diffFirstCouple;
            int sumSecond = firstSecondCouple + diffSecoundCouple;


            for (int a = firstCouple; a <= sumFirst; a++)
            {
                for (int b = firstSecondCouple; b <= sumSecond; b++)
                {
                    if(a%2!=0 && a %3!=0 && a%5!=0 && a%7!=0 && b % 2 != 0 && b % 3 != 0 && b % 5 != 0 && b % 7 != 0)// proverka za delene na 2,3,5,7 i rezultat razlichen ot 0
                    {
                        Console.WriteLine($"{a}{b} ");
                    }
                }
            }
        }
    }
}
