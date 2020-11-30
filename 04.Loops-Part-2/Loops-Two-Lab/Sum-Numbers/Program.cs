using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //create main variable
            string input = Console.ReadLine();
            double sum = 0;

            //bool inside loop
            while (input !="Stop")
            {
                sum += double.Parse(input);//preobrazuvame string v double

                input = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
