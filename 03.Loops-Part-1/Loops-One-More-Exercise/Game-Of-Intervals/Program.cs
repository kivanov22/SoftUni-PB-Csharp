using System;


namespace Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            
            double points = 0.0;
            double number1 = 0.0;
            double number2 = 0.0;
            double number3 = 0.0;
            double number4 = 0.0;
            double number5 = 0.0;
            double number6 = 0.0;

            for (int movesMade = 1; movesMade <= moves; movesMade++)
            {
                int num = int.Parse(Console.ReadLine());


                if (num >= 0 && num <= 9)
                {
                    //num *= 0.20;

                    points += num * 0.20;
                    number1++;
                }
                else if (num >= 10 && num <= 19)
                {
                    //30%

                    points += num * 0.30;
                    number2++;
                }
                else if (num >= 20 && num <= 29)
                {
                    //40%

                    points += num * 0.40;
                    number3++;
                }
                else if (num >= 30 && num <= 39)
                {
                    //50 to4ki
                    points += 50;
                    number4++;
                }
                else if (num >= 40 && num <= 50)
                {
                    //100 to4ki
                    points += 100;
                    number5++;
                }
                else 
                {

                    //invalid
                    //result /2
                    points = points / 2;
                    number6++;
                }
            }
            
        
                //calculate result
                double totalSumNumbers = number1 + number2 + number3 + number4 + number5 + number6;
                


                //procenti
                double percent1 = (number1 / moves) * 100;
                double percent2 = (number2 / moves) * 100;
                double percent3 = (number3 / moves) * 100;
                double percent4 = (number4 / moves) * 100;
                double percent5 = (number5 / moves) * 100;
                double percent6 = (number6 / moves) * 100;

                //output
                Console.WriteLine($"{points:f2}");
                Console.WriteLine($"From 0 to 9: {percent1:f2}%");
                Console.WriteLine($"From 10 to 19: {percent2:f2}%");
                Console.WriteLine($"From 20 to 29: {percent3:f2}%");
                Console.WriteLine($"From 30 to 39: {percent4:f2}%");
                Console.WriteLine($"From 40 to 50: {percent5:f2}%");
                Console.WriteLine($"Invalid numbers: {percent6:f2}%");


            }
        }
    }

