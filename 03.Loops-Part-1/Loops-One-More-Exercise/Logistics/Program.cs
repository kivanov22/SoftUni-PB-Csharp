using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            //different weight diff transport
            //price of ton is diff for transport
            //calculate price of ton for transport and % of the cargo in the transport

            int cargoNumber = int.Parse(Console.ReadLine());
            double microbus = 0.0;
            double truck = 0.0;
            double train = 0.0;

            double microbusTons = 0.0;    //samo edna nula bqh slojil
            double truckTons = 0.0;
            double trainTons = 0.0;


            for (int i = 1; i <= cargoNumber; i++)
            {
                int tonsOfCargo = int.Parse(Console.ReadLine());


                if (tonsOfCargo <= 3)
                {
                    //микробус (200 лева на тон)
                    microbus = microbus +tonsOfCargo * 200;
                    microbusTons += tonsOfCargo;

                }
               else if (tonsOfCargo >= 4 && tonsOfCargo <= 11)
                {
                    //камион (175 лева на тон)
                    truck = truck+tonsOfCargo * 175;
                    truckTons += tonsOfCargo;
                }
                else if (tonsOfCargo >= 12)
                {
                    //влак(120 лева на тон)
                    train = train+ tonsOfCargo * 120;
                    trainTons += tonsOfCargo;
                }
            }
            double totalCargo = microbusTons + truckTons + trainTons;
            double srednoTon = (microbus + truck + train) / totalCargo;
            //calculate
            //totalSum
            //middle ton

            double percentMicrobus = (microbusTons / totalCargo) * 100;
            double percentTruck =( truckTons / totalCargo) * 100;
            double percentTrain = (trainTons / totalCargo) * 100;


            Console.WriteLine($"{srednoTon:f2}");
            Console.WriteLine($"{percentMicrobus:f2}%");
            Console.WriteLine($"{percentTruck:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");
        }
    }
}