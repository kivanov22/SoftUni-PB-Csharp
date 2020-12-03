using System;

namespace Sum_Of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int counter = 0;
            bool noCom = false;

            for (int i = start; i <= end; i++)
            {
                for (int k =start; k <= end; k++)
                {
                    counter++;
                 

                    if (i+k==magic)
                    {
                        
                        Console.WriteLine($"Combination N:{counter} ({i} + {k} = {magic})");
                        noCom = true;//bool true
                        return; // retrun instead of break
                    }
                    
                }
            }
            if (!noCom)// !
            {
                // no bool=false here
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
                
            }
        }
    }
}
