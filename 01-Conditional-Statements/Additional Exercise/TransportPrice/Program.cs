using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            
            //1. проверка за км
            //2. проверка за ден
            //3. проверка за нощ

            //4.проверка такси
            //5.проверка автобус
            //6.проверка влак

            //7.проверка за най-ниска цена

            //Такси.Начална такса: 0.70 лв.Дневна тарифа: 0.79 лв. / км.Нощна тарифа: 0.90 лв. / км.
            //Автобус.Дневна / нощна тарифа: 0.09 лв. / км.Може да се използва за разстояния минимум 20 км.
            //Влак.Дневна / нощна тарифа: 0.06 лв. / км.Може да се използва за разстояния минимум 100 км.

            

               if (km < 20 && time == "day")
                {
                    double taxiPriceDay = 0.70 + km * 0.79;
                    Console.WriteLine($"{taxiPriceDay:f2}");
                }
              else if (km < 20 && time == "night")
                {
                    double taxiPriceNight = 0.70 + km * 0.90;
                    Console.WriteLine($"{taxiPriceNight:f2}");
                }
            
            else if (km >= 100 && time == "day" ||km >= 100 && time == "night")
            {
                double train = km * 0.06;
                Console.WriteLine($"{train:f2}");
            }

            else if (km >= 20 && km < 100 && time == "day" || km >= 20 && time == "night")
            {
                double bus = km * 0.09;
                Console.WriteLine($"{bus:f2}");
            }
            
        
              


        }
    }
}
