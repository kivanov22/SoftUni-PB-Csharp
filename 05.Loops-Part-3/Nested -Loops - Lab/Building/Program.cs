using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFloors = int.Parse(Console.ReadLine());
            int numberRooms = int.Parse(Console.ReadLine());

            for (int i = numberFloors; i>=1; i--) // цикъл за етажи намаляват
            {
               for (int j = 0; j < numberRooms; j++) // за стай се увеличават
                {

                    if(numberFloors == i) // ако етажите са равни на на последния етаж се пише Л
                    {
                        Console.Write($"L{i}{j} ");
                        
                    }
                    else if (i % 2 == 0)// ако се дели на 2 за четно значи е офис
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else // иначе е апартамент
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine(""); 
               
            }


        }
    }
}
