using System;

namespace Number_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int big = int.MinValue;
            int small = int.MaxValue;



            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < small)
                {
                    small = num;

                }
                if (num > big)
                {
                    big = num;

                }
            }
            Console.WriteLine($"Max number: {big}");
            Console.WriteLine($"Min number: {small}");
           
            
        }
    }
}
