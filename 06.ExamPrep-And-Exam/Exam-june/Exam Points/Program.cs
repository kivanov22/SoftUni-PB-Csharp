using System;

namespace Exam_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int exercise = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            string course = Console.ReadLine();

            double currentPoints = 0;
            double percent = 0;

            switch (exercise)
            {
                case 1:
                    switch (course)
                    {
                        case "Basics":
                            // //20% по-малко точки.
                            currentPoints = 8;
                            
                            break;
                        case "Fundamentals":
                            currentPoints = 11;
                            break;
                        case "Advanced":
                            //студентът изкарва 20% повече точки.
                            currentPoints = 14;
                            
                            break;
                    }

                    break;
                case 2:
                    switch (course)
                    {
                        case "Basics":
                           
                            currentPoints = 9;
                            break;
                        case "Fundamentals":
                            currentPoints = 11;
                            break;
                        case "Advanced":
                            //студентът изкарва 20% повече точки.
                            currentPoints = 14;

                            break;
                    }
                    break;
                case 3:
                    switch (course)
                    {
                        case "Basics":
                            currentPoints = 9;
                            break;
                        case "Fundamentals":
                            currentPoints = 12;
                            break;
                        case "Advanced":
                            //студентът изкарва 20% повече точки.
                            currentPoints = 15;
                            break;
                    }
                    break;
                case 4:
                    switch (course)
                    {
                        case "Basics":
                            currentPoints = 10;
                            break;
                        case "Fundamentals":
                            currentPoints = 13;
                            break;
                        case "Advanced":
                            //студентът изкарва 20% повече точки.
                            currentPoints = 16;
                            break;
                    }
                    break;
            }

            double totalAmountPoints = (points * currentPoints)/ 100;

            if (course == "Advanced")
            {
                totalAmountPoints =totalAmountPoints+0.20*totalAmountPoints;

            }
            if(exercise==1 && course == "Basics")
            {
                totalAmountPoints =totalAmountPoints- 0.20*totalAmountPoints;
            }
            Console.WriteLine($"Total points: {totalAmountPoints:f2}");
        }
    }
}
