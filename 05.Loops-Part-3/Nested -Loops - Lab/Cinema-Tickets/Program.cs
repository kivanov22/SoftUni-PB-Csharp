using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine(); //името на филма 

            int studentTicketCount = 0; //студентски билети брояч
            int standardTicketCount = 0; 
            int kidTicketCount = 0;
            int totalTicketsCount = 0;

            while (movieName !="Finish")//едното условие финиш
            {
                int seatsAvailable = int.Parse(Console.ReadLine()); // заети места в залата

                string ticket = Console.ReadLine(); // какъв е билета трите вида
                 int ticketCount = 0;  // брояч на билети

                while (ticket !="End")// второто условие за прекъсване на цикъла
                {
                    switch (ticket) // суитч за по лесно проверяване във всяка категория колко
                    {
                        case "kid":
                            kidTicketCount++;
                            break;
                        case "student":
                            studentTicketCount++;
                            break;
                        case "standard":
                            standardTicketCount++;
                            break;
                    }
                    ticketCount++;// брояч на билети 

                    if(ticketCount == seatsAvailable)// ако свършат местата да прекъсне програмата
                    {
                        break;
                    }

                    ticket = Console.ReadLine(); // билети взимане пак

                }
                totalTicketsCount += ticketCount; // обща сума билети

                double seatsTaken = ticketCount * 1.0 / seatsAvailable * 100; // средно билети

                Console.WriteLine($"{movieName} - {seatsTaken:f2}% full.");

                movieName = Console.ReadLine(); // пак питаме за филм

            }

            //проценти за всеки тип билет
            double percentStandard = standardTicketCount * 1.0 / totalTicketsCount * 100;
            double percentStudent = studentTicketCount * 1.0 / totalTicketsCount * 100;
            double percentKid = kidTicketCount * 1.0 / totalTicketsCount * 100;
            //изхода 
            Console.WriteLine($"Total tickets: {totalTicketsCount}");
            Console.WriteLine($"{percentStudent:f2}% student tickets.");
            Console.WriteLine($"{percentStandard:f2}% standard tickets.");
            Console.WriteLine($"{percentKid:f2}% kids tickets.");

        }
    }
}
