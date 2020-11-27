using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int n1 = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += n1;
                }
                else
                {
                    oddSum += n1;
                }
            }

            
            int totalSum = evenSum + oddSum;
            if (evenSum == oddSum)
            {

                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                int diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}

