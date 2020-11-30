using System;

namespace Graduation_Two
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();

            double totalSum = 0;
            double average = 0;
            int countClases = 1;
            int countGrades = 0;
            int fails = 0;


            while (countClases <= 12) //cikul ot purvi do 12 klas
            {
                double marks = double.Parse(Console.ReadLine());

                if (marks >= 4.00) //dobri ocenki
                {
                    countClases++;  //broqch klasove
                    totalSum += marks; //suma ocenki
                    countGrades++; //broqch na ocenki kolko sa

                }
                else //proverka za skusvaniq 
                {
                    fails++;
                    if (fails == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {countClases} grade");
                        break;
                    }
                }



            }
            if (countClases >= 12)
            {
                average = totalSum / countGrades;
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}



