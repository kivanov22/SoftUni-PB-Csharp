using System;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();

            // check if()
            // switch()
            //1.input from user
            //2.check category of the fruid
            


            	//Плодовете "fruit" имат следните възможни стойности:  banana, apple, kiwi, cherry, lemon и grapes
	            //Зеленчуците "vegetable" имат следните възможни стойности:  tomato, cucumber, pepper и carrot
	            //Всички останали са "unknown"


            switch (item)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;

            }
        }
    }
}
