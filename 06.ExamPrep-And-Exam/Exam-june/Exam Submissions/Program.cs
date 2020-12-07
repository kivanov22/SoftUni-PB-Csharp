using System;
using System.Threading;

namespace Exam_Submissions
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberStudents = int.Parse(Console.ReadLine());
            double numberExercises = int.Parse(Console.ReadLine());
            double sumExercise = numberStudents * Math.Ceiling(numberExercises * 2.8);
            double third = 0;
            third = numberStudents * Math.Floor(numberExercises / 3);
            double totalThree = sumExercise + third;
            double storage = Math.Ceiling(totalThree / 10);
            double totalAmount = 5 * storage;
            Console.WriteLine($"{totalAmount} KB needed");
            Console.WriteLine($"{totalThree} submissions");
        }
    }
}