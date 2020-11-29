using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            // 7 lekari po edin pacient na den
            // vseki treti den se presmqta ako broq na nepregledanite e po > ot pregledanite + 1 lekar -- proverka

            int treated = 0;
            int untreated = 0;
            int doctors = 7;

            for (int days = 1; days <= period; days++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (days % 3 == 0 && untreated > treated)
                {
                    doctors++;
                }
                if (patients <= doctors)
                {
                    treated += patients;
                }

                else
                {
                    untreated += patients - doctors;
                    treated += doctors;
                }
            }
            Console.WriteLine($"Treated patients: {treated}. ");
            Console.WriteLine($"Untreated patients: {untreated}. ");

        }
    }
}
