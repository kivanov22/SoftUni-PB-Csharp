using System;

namespace Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;

            for (int number = 1; number <= n; number++)
            {

                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {

                    group1 += 1;

                }

                if (num % 3 == 0)
                {


                    group2 += 1;

                }

                if (num % 4 == 0)
                {

                    group3 += 1;

                }
            }

                //group1
                double percent1 = group1 * 1.0 / n * 100;
                //grop2
                double percent2 = group2 * 1.0 / n * 100;
                //group3
                double percent3 = group3 * 1.0 / n * 100;

                Console.WriteLine($"{percent1:F2}%");
                Console.WriteLine($"{percent2:F2}%");
                Console.WriteLine($"{percent3:F2}%");


            }
        }
    }




