using System;

namespace Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char sector = char.Parse(Console.ReadLine());
            int numberRows = int.Parse(Console.ReadLine());
            int oddNumberSeats = int.Parse(Console.ReadLine());

            int rowsCount = 0;
            int sum = 0;
            int numberEvenSeats = 0;

            for (char i = 'A'; i <=sector; i++)
            {
                for (int rows = 1; rows <=numberRows; rows++)
                {
                    rowsCount++;
                    for (char oddSeats = 'a'; oddSeats <='b'; oddSeats++)
                    {
                       
                        for (char evenSeats = 'c'; evenSeats <='d'; evenSeats++)
                        {
                            
                            if (oddNumberSeats % 2 != 0)
                            {
                                Console.WriteLine($"{i}{rowsCount}{oddSeats} ");
                            }
                            else
                            {
                                numberEvenSeats = oddNumberSeats + 2;
                                Console.WriteLine($"{i}{rowsCount}{evenSeats} ");
                                
                            }
                            
                            sum = oddNumberSeats + numberEvenSeats;
                        }
                    }
                   
                }
            }
            Console.WriteLine($"{sum}");
        }
    }
}
