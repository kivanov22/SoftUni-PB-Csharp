using System;
using System.Runtime.InteropServices.ComTypes;

namespace Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double grade = 0;
            string name = "";

            while (studentName != "Midnight")
            {
                double sum = 0;
                double change = 0;
                double final = 0;
                
                for (int i = 1; i <= 6; i++)
                {
                    
                    double points = double.Parse(Console.ReadLine());
                    sum += points;
                    if (points < 0)
                    {
                        Console.WriteLine($"{studentName} was cheating!");
                        break;
                    }
                  
                }

               
                sum = (sum / 600);
                change = Math.Floor(sum * 100);

                final = change * 0.06;

                if (final < 5)
                {
                    Console.WriteLine($"{studentName} - {final:f2}");
                }
               else if (final >= 5)
                {
                    Console.WriteLine("===================");
                    Console.WriteLine("|   CERTIFICATE   |");
                    Console.WriteLine($"|    {final:f2}/6.00    |");
                    Console.WriteLine("===================");
                    Console.WriteLine($"Issued to {studentName}");
                }
                studentName = Console.ReadLine();
            }
        }
    }
}
