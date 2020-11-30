using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int cakeSize = 0;
            int totalSlices = 0;
            int currentPieces = 0;

            cakeSize = width * length;
            string slicesTaken = Console.ReadLine();

            while (slicesTaken !="STOP")// cikula da vurti dokato poluchava razlichno ot stop
            {

                

               int slicesNumbers = int.Parse(slicesTaken);//preobrazuvane string kum int.

                totalSlices += slicesNumbers;// total parcheta vuvedeni ot konzolata

                if (totalSlices>cakeSize)//proverka za vtoroto uslovie kogato tortata svurshi i nqma pove4e parcheta
                {
                    Console.WriteLine($"No more cake left! You need {totalSlices - cakeSize} pieces more.");
                    break;
                }
                slicesTaken = Console.ReadLine();//da vzima parcheta ot konzolata na vseki red 


            }
            if(slicesTaken == "STOP")// i proverka ako e zadaden stop v konzolata
            {
                Console.WriteLine($"{cakeSize - totalSlices} pieces are left.");
            }
        }
    }
}
//  Console.WriteLine($"No more cake left! You need {totalSlices - cakeSize} pieces more.");




// Console.WriteLine($"{cakeSize - totalSlices} pieces are left.");
