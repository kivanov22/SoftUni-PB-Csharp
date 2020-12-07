using System;

namespace Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintedEggs = int.Parse(Console.ReadLine());

            int countRedEggs = 0;
            int countOrangeEggs = 0;
            int countBlueEggs = 0;
            int countGreenEggs = 0;
            int mostEggs = 0;
            string mostEggsColour = "";

            for (int i = 1; i <= paintedEggs; i++)
            {
                string colour = Console.ReadLine();

                 if (colour == "orange")
                {
                    countOrangeEggs++;
                }
                else if (colour =="red")
                {
                    countRedEggs++;
                }
                 else if (colour =="blue")
                {
                    countBlueEggs++;
                }
                else if(colour =="green")
                {
                    countGreenEggs++;
                }
                
            }
            if (countGreenEggs > countBlueEggs && countGreenEggs > countRedEggs && countGreenEggs > countOrangeEggs)
            {
                mostEggs = countGreenEggs;
                mostEggsColour ="green";
            }
            else if (countRedEggs > countBlueEggs && countRedEggs > countGreenEggs && countRedEggs > countOrangeEggs)
            {
                mostEggs = countRedEggs;
                mostEggsColour ="red";
            }
            else if(countBlueEggs > countGreenEggs && countBlueEggs > countGreenEggs && countBlueEggs > countOrangeEggs)
            {
                mostEggs = countBlueEggs;
                mostEggsColour ="blue";
            }
            else if(countOrangeEggs > countGreenEggs && countOrangeEggs > countGreenEggs && countOrangeEggs > countBlueEggs)
            {
                mostEggs = countOrangeEggs;
                mostEggsColour ="orange";
            }

            Console.WriteLine($"Red eggs: {countRedEggs}");
            Console.WriteLine($"Orange eggs: {countOrangeEggs}");
            Console.WriteLine($"Blue eggs: {countBlueEggs}");
            Console.WriteLine($"Green eggs: {countGreenEggs}");
            Console.WriteLine($"Max eggs: {mostEggs} -> {mostEggsColour}");


        }
    }
}
