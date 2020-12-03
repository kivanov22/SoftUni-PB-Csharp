using System;

namespace Challenge__the__Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int girl = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            int count = 0;
            bool tableFUll = false;

            for (int m = 1; m <=men; m++)
            {
                for (int g = 1; g <=girl; g++)
                {
                    
                   
                    if (count== tables)
                    {
                        
                        break;
                    }
                    count++;
                    tableFUll = false;
                    Console.Write($"({m} <-> {g}) ");
                }
                if (tableFUll)
                {
                    tableFUll = true;
                }
            }
            
        }
    }
}
