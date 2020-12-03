using System;

namespace Letters_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            char letterA =char.Parse (Console.ReadLine());
            char letterB = char.Parse(Console.ReadLine());
            char letterC = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char a = letterA; a <= letterB; a++)
            {
                for (char b = letterA; b <=letterB; b++)
                {
                    for (char c = letterA; c <= letterB; c++)
                    {
                        
                        if (c !=letterC && a !=letterC && b!=letterC)
                        {
                            Console.Write($"{a}{b}{c} ");
                            counter++;
                        }
                        
                    }
                }
                
            }
            Console.Write(counter);
        }
    }
}
