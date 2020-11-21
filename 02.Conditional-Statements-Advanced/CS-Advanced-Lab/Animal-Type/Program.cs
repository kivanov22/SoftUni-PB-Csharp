using System;

namespace AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            //crocodile, tortoise, snake -> reptile
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
