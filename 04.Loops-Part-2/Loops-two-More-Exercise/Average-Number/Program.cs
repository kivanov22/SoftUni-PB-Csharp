using System;

namespace Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = int.Parse(Console.ReadLine());
            double average = 0;
            double sum = 0;
            for (int i = 1; i <=n; i++)
            {

                double number = int.Parse(Console.ReadLine());
                sum += number;
                average = sum / n;
                

            }
            Console.WriteLine($"{average:f2}");

        }
    }
}
