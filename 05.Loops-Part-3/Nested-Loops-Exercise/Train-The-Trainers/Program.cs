using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberJury = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();

            double totalSum = 0;
            int countGrades = 0;

            while (presentationName !="Finish")
            {
                double sum = 0; // променлива за оценки 

                for (int judge = 1; judge <= numberJury; judge++) // цикъл за съдий
                {
                    double grade = double.Parse(Console.ReadLine()); 

                    sum += grade;//оценките за категорията
                    totalSum += grade;// сума всички оценки от всички категорий
                    countGrades++;  //брояч на оценки

                }
                double average = sum / numberJury;// средна оценка от категория

                Console.WriteLine($"{presentationName} - {average:f2}.");

                presentationName = Console.ReadLine(); // пак питаме за име за презентация
            }
            double averageForAll = totalSum / countGrades; // средна оценка от всички категорий
            Console.WriteLine($"Student's final assessment is {averageForAll:f2}.");
        }
    }
}
