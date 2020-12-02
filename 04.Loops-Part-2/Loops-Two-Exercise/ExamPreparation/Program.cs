using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradeFailed = int.Parse(Console.ReadLine());

            double gradesSum = 0;
            string lastProblem = "";
            int solvedProblemsCount = 0;
            int failedTimes = 0;
            bool isFailed = true;

            while (failedTimes < gradeFailed)
            {
                string problemName = Console.ReadLine();
               
                if(problemName == "Enough")
                {
                    isFailed = false;
                    break;

                }
                int grade = int.Parse(Console.ReadLine());
                if(grade <= 4)
                {
                    failedTimes++;
                }

                gradesSum += grade;
                solvedProblemsCount++;
                lastProblem = problemName;


            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {gradeFailed} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum/solvedProblemsCount:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
