using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double group4 = 0;
            double group5 = 0;


            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    group1++;

                }

                if (num >= 200 && num <= 399)
                {
                    group2++;
                }
                if (num >= 400 && num <= 599)
                {
                    group3++;
                }
                if (num >= 600 && num <= 799)
                {
                    group4++;

                }
                if (num >= 800)
                {
                    group5++;
                }
            }

                double percent1 = group1 * 1.0 / n * 100;
                double percent2 = group2 * 1.0 / n * 100;
                double percent3 = group3 * 1.0 / n * 100;
                double percent4 = group4 * 1.0 / n * 100;
                double percent5 = group5 * 1.0 / n * 100;

                Console.WriteLine($"{percent1:F2}%");
                Console.WriteLine($"{percent2:F2}%");
                Console.WriteLine($"{percent3:F2}%");
                Console.WriteLine($"{percent4:F2}%");
                Console.WriteLine($"{percent5:F2}%");


            }
        }
    }

