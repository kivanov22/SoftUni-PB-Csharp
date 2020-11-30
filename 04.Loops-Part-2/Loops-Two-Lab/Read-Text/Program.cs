using System;

namespace Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int words = 0;
            while (true)
            {
                string input = Console.ReadLine();
               
                if (input == "Stop")
                {
                    break;
                }
                words++;
                
            }
            Console.WriteLine(words);

        }
    }
}