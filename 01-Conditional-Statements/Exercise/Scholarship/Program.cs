using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            // dva vida stipendiq socialna i otlichen
            //социална стипендия - доход на член от семейството по-малък от минималната работна заплата и успех над 4.5
            //отличен успех - успехът на ученика, умножен по коефициент 25.

            //Напишете програма, която при въведени доход, успех и минимална работна заплата, 
            //дава информация дали ученик има право да получава стипендия, и стойността на стипендията, която е по-висока за него.

            double incomeLeva = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minimalPayment = double.Parse(Console.ReadLine());
            double social = 0;
            double excellent = 0;
            social = Math.Floor(minimalPayment * 0.35);
            excellent = Math.Floor(grade * 25);


            if (grade < 4.50 && incomeLeva > minimalPayment)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }


            if (incomeLeva <= minimalPayment && grade >= 5.5 && excellent >= social) Console.WriteLine($"You get a scholarship for excellent results {excellent} BGN");
            else if (incomeLeva <= minimalPayment && grade >= 5.5 && social < excellent) Console.WriteLine($"You get a Social scholarship {social} BGN");
        
            else if (incomeLeva <= minimalPayment && grade > 4.5) Console.WriteLine($"You get a Social scholarship {social} BGN");
            
            else if (incomeLeva > minimalPayment && grade >= 5.5) Console.WriteLine($"You get a scholarship for excellent results {excellent} BGN"); 
            
            
            else if (incomeLeva > minimalPayment && grade >= 5.5) Console.WriteLine($"You get a scholarship for excellent results {excellent} BGN");
                 
            else Console.WriteLine("You cannot get a scholarship!");

        }
    }
}

