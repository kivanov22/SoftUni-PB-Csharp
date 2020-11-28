using System;
using System.ComponentModel.DataAnnotations;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumEven = 0;
            double sumOdd = 0;
            double maxOdd = -1000000000.0;
            double maxEven = -1000000000.0;
            double minOdd = 1000000000.0;
            double minEven = 1000000000.0;

            for (int numberPosition = 1; numberPosition <= n; numberPosition++)
            {
                double value = double.Parse(Console.ReadLine());

                if (numberPosition % 2 == 0)
                {
                    sumEven += value;


                    if (value > maxEven)
                    {
                        maxEven = value;

                    }
                    if (value < minEven)
                    {
                        minEven = value;

                    }
                }






                else
                {
                    sumOdd += value;


                    if (value > maxOdd)
                    {
                        maxOdd = value;

                    }
                    if (value < minOdd)
                    {
                        minOdd = value;

                    }
                }
            }
            //ODD
            Console.WriteLine($"OddSum={sumOdd:f2},");

            if (minOdd == 1000000000.0)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minOdd:f2},");
            }
            if (maxOdd == -1000000000.0)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={maxOdd:f2},");
            }
            //EVEN
            Console.WriteLine($"EvenSum={sumEven:f2},");

            if (minEven == 1000000000.0)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={minEven:f2},");
            }
            if (maxEven == -1000000000.0)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={maxEven:f2}");
            }
        }
    }
}



