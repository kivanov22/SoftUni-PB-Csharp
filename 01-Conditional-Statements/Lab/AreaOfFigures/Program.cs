using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
           

           

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double areaSquare = side * side;
                Console.WriteLine($"{areaSquare:F3}");
            }
            else if(figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());


                double areaRectangle = sideA * sideB;
                Console.WriteLine($"{areaRectangle:F3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double areaCircle = radius * radius * Math.PI;
                Console.WriteLine($"{areaCircle:F3}");
            }
            else if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                double area = sideA * sideB / 2;
                Console.WriteLine($"{area:F3}");
            }
        }
    }
}
