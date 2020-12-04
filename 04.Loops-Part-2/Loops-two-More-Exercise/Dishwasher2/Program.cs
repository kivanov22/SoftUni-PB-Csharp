using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());

            int platehMl = 5;
            int potMl = 15;
            int totalPreparat = 0;
            int countDishwasher = 1;//колко пъти се пуска миялната
            int countChinii = 0; // броя чиний
            int countTendjeri = 0;// броя тенджери
            int liquidNeeded = 0;// нужен препарат
            int izrashodvamPreparat = 0;

            totalPreparat = bottles * 750; // общо препарат
            string dishes = Console.ReadLine(); //стринга в началото за да го използвам в цикъла

            while (dishes !="End") // докато препарата е повече от 0 
            {

                
                //взимане на брой чиний от конзолата
                int dishesNumber = int.Parse(dishes);
                // преобразуваме стринг в число



                if (countDishwasher % 3 == 0)// всеки трети път тенджери
                {
                    countTendjeri += dishesNumber;//броя на тенжери
                    liquidNeeded = potMl * dishesNumber;//препарата след измитите тенджери
                    totalPreparat -= liquidNeeded;//изваждаме всичкия препарат от препарата използван за тенджери
                    izrashodvamPreparat = liquidNeeded;
                }
                else //ако не е 3ти път са чиний
                {
                    countChinii += dishesNumber;
                    liquidNeeded = platehMl * dishesNumber;
                    totalPreparat -= liquidNeeded;
                    //ако са чиний
                    izrashodvamPreparat = liquidNeeded;
                }
                
                 if (totalPreparat < 0)//второто условие за изчерпване на препарата
                {
                   
                    break;
                }
                dishes = Console.ReadLine();//още съдове от конзолата бях изпуснал
                countDishwasher++; // броя на миения накрая


            }
            //проверка дали е достатъчно препарата или не достига извеждане на конзолата
            if (totalPreparat >= 0)// стария вариант с liquidNeeded сравнение , а то е >=0
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{countChinii} dishes and {countTendjeri} pots were washed.");
                Console.WriteLine($"Leftover detergent {totalPreparat} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(totalPreparat)} ml. more necessary!");//получава се отрицателно число затова мат абс
            }
        }
    }
}
