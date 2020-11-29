using System;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double stadium = double.Parse(Console.ReadLine());
            double fans = double.Parse(Console.ReadLine());


            double sectorAfans = 0.0;
            double sectorBfans = 0.0;
            double sectorVfans = 0.0;
            double sectorGfans = 0.0;


            for (int i = 1; i <= fans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    sectorAfans++;

                }
                else if (sector == "B")
                {
                    sectorBfans++;
                }
                else if (sector == "V")
                {
                    sectorVfans++;
                }
                else if (sector == "G")
                {
                    sectorGfans++;
                }

            }

            //percent for each sector
            double sectorApercent = sectorAfans / fans * 100;
            double sectorBpercent = sectorBfans / fans * 100;
            double sectorVpercent = sectorVfans / fans * 100;
            double sectorGpercent = sectorGfans / fans * 100;


            //calculate capacity of fans for stadium
            
            double sumStadium = fans / stadium * 100;

            //output
            Console.WriteLine($"{sectorApercent:f2}%");
            Console.WriteLine($"{sectorBpercent:f2}%");
            Console.WriteLine($"{sectorVpercent:f2}%");
            Console.WriteLine($"{sectorGpercent:f2}%");
            Console.WriteLine($"{sumStadium:f2}%");
        }
    }
}
