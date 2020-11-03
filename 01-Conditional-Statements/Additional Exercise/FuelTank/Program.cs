using System;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();                // lowercase sled readline na stringa , vkarvash s glavni izliza s malki
            double number = double.Parse(Console.ReadLine());
            
            if(text == "gasoline" && number >= 25|| number >=25 && text =="diesel" ||number>=25 && text == "gas")  // <--- trqbva da sa s malki stringovete
            {
                
                Console.WriteLine($"You have enough {text}.");
            }
            else if (number < 25 && text == "gasoline"||number <25 && text == "diesel"||number <25 && text == "gas")
            {
                
                Console.WriteLine($"Fill your tank with {text}!");
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
