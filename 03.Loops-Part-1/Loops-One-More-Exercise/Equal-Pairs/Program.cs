using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());

            int maxDiff = int.MinValue;
            int sum = 0;
            int sum2 = 0;
            int diff = 0;

            for (int i = 1; i <= num1; i++)
            {
                sum += int.Parse(Console.ReadLine());
                sum += int.Parse(Console.ReadLine());

                if (i > 1)
                {
                    diff = Math.Abs(sum - sum2);
                }
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
                sum2 = sum;
                sum = 0;
            }
            if (maxDiff == 0)
            {
                Console.WriteLine($"Yes, value = {sum2}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff = {maxDiff}");
            }
        }
    }

}

