using System;

namespace On_Time_For_The_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ако е пристигнал по-рано повече от 30 минути, той е подранил. 
            //Ако е дошъл след часа на изпита, той е закъснял. 
            //и с колко часа или минути е подранил или закъснял.

            
            int examHours= int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());

            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMin = int.Parse(Console.ReadLine());


            int examMinutes = examHours * 60 + examMin;  // chasa na izpita v minuti
            int arrivalMinutes = arriveHour * 60 + arriveMin;// chasa na pristigane v minuti

            if(arrivalMinutes > examMinutes)
            {
                Console.WriteLine("Late");
                int late = arrivalMinutes - examMinutes; // zakusnenie
                if(late < 60)
                {
                    Console.WriteLine($"{late} minutes after the start");
                }
                else
                {
                    int lateHour = late / 60;
                    int lateMinute = late % 60;
                    Console.WriteLine($"{lateHour}:{lateMinute:D2} hours after the start");
                }
            }
            else if(arrivalMinutes == examMinutes || examMinutes - arrivalMinutes <= 30)
            {
                Console.WriteLine("On time");

                if(examMin- arrivalMinutes<=30 && examMinutes != arrivalMinutes)
                {
                    Console.WriteLine($"{examMinutes - arrivalMinutes} minutes before the start");
                }
            }
            else if(examMinutes - arrivalMinutes > 30)
            {
                Console.WriteLine("Early");
                int early = examMinutes - arrivalMinutes;

                if (early < 60)
                {
                    Console.WriteLine($"{early} minutes before the start");
                }
                else
                {
                    int earlyHour = early / 60;
                    int earlyMinute = early % 60;
                    Console.WriteLine($"{earlyHour}:{earlyMinute:D2} hours before the start");
                }
            }
            
            }
        }
    }

