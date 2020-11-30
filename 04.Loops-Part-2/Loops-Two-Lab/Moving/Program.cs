using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.read input
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            //calculate free space
            int freeSpace = width * length * height;


            //2.Create while loop - for the moving of the boxes
            string input = Console.ReadLine();

            while (input != "Done")
            {


                //remove the taken space from the free space
                freeSpace -= int.Parse(input);

                //3.check if there is no more free space left or free space less than 0
                if (freeSpace < 0)
                {

                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }



        }
    }
}
