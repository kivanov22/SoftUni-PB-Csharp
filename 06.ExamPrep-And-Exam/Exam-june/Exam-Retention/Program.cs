using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            int seasons = int.Parse(Console.ReadLine());
            double firstExam = 0;
            double secondExam = 0;
            double continued = 0;
            double reSigned = 0;
            


            for (int i = 1; i <= seasons; i++)
            {
                firstExam = (students *90) / 100;
                Math.Ceiling(firstExam);
                secondExam = (firstExam * 90) / 100;
                Math.Ceiling(secondExam);
                continued = (secondExam* 80)/ 100;
                Math.Ceiling(continued);

                if (i % 3 == 0)
                {
                    reSigned = (continued *15)/100;
                    Math.Ceiling(reSigned);
                }
                else
                {
                    reSigned =(continued*5)/100;
                    Math.Ceiling(reSigned);
                }

                double newss = continued + reSigned;
                students -= newss;


            }
            double total = firstExam + secondExam + continued + reSigned;

            Console.WriteLine($"Students: {total}");
        }


    }
}