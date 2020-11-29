using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsAttendExam = int.Parse(Console.ReadLine());

            double topStudents = 0.0;
            double goodStudents = 0.0;
            double normalStudents =0.0;  // na double da slagam 0.0 a ne samo 0
            double failStudents = 0.0;
           
            double averageGradeTop = 0.0;
            double averageGradegood = 0.0;
            double averageGradenormal = 0.0;
            double averageGradefails = 0.0;


            for (int students = 1; students <= studentsAttendExam; students++)
            {
                double examGrade = double.Parse(Console.ReadLine());


                if (examGrade >= 5)
                {
                    //top student
                    topStudents++;
                    averageGradeTop += examGrade;
                }
                else if (examGrade >= 4 && examGrade <= 4.99)
                {
                    //good student
                    goodStudents++;
                    averageGradegood += examGrade;
                }
                else if (examGrade >= 3 && examGrade <= 3.99)
                {
                    //normal student
                    normalStudents++;
                    averageGradenormal += examGrade;
                }
                else if (examGrade < 3)
                {
                    //fail
                    failStudents++;
                    averageGradefails += examGrade;
                }

            }


            //total sum average grade
            double totalSum = averageGradeTop + averageGradenormal + averageGradegood + averageGradefails;  // tova e suma
            double averageTotal = totalSum/ (studentsAttendExam*1.0); // tova e average

            // percent of students

            double percentTop = (topStudents / studentsAttendExam) * 100;  //izchisleniq na procenti da se vnimavam
            double percentGood = (goodStudents / studentsAttendExam) * 100;
            double percentNormal = (normalStudents / studentsAttendExam) * 100;
            double percentFails = (failStudents / studentsAttendExam) * 100;

            //output
            Console.WriteLine($"Top students: {percentTop:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentGood:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentNormal:f2}%");
            Console.WriteLine($"Fail: {percentFails:f2}%");
            Console.WriteLine($"Average: {averageTotal:f2}");

        }
        }
    }

