using System;

namespace Graduation_One
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string name = Console.ReadLine();
            //double grades = double.Parse(Console.ReadLine());

            double count = 0;
            double average = 0;
            double totalSum = 0;
          

            //all grades sum and devide to number of grades 
            //12 grades

            while (count < 12)
            {
                double grades = double.Parse(Console.ReadLine());

                if (grades >= 4.00)
                {
                    totalSum += grades;
                    count++;

                }
            }
            average = totalSum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");

            }
        }
    }

