using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 domashni lubimeca
            // 1.total food for all
            // 2.every animal eats some amount of food
            // 3. if the food will be enough

            int days = int.Parse(Console.ReadLine());
            int kgFood = int.Parse(Console.ReadLine());                  //left food before going
            double dayKgDogFood = double.Parse(Console.ReadLine());
            double dayKgCatFood = double.Parse(Console.ReadLine());
            double dayKgTurtleFood = double.Parse(Console.ReadLine());


            double neededDog = days * dayKgDogFood;          //food dog for day
            double neededCat = days * dayKgCatFood;          //food cat for day
            double neededTurtle = days * dayKgTurtleFood / 1000;    //food turtle for day preobrazuvane ot grami v kg

            double totalAll = neededDog + neededCat + neededTurtle;



            // mathfloor otdelno

            if (totalAll <= kgFood)
            {
                double foodLeft = kgFood - totalAll;
                foodLeft = Math.Floor(foodLeft);

                Console.WriteLine($"{foodLeft} kilos of food left.");
            }
            else if (totalAll > kgFood)
            {
                // Math.Ceiling tuk vmesto kum console
                double notEnought = totalAll - kgFood;
                notEnought = Math.Ceiling(notEnought);

                Console.WriteLine($"{notEnought} more kilos of food are needed.");
            }



        }
    }
}
