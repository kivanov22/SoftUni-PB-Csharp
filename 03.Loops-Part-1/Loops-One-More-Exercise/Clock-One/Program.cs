using System;

namespace Clock_One
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = 0.0;
            double minute = 23.59;


            do
            {
                Console.WriteLine($"{hour}:{minute}");
            } while (true);
        }
    }
}
