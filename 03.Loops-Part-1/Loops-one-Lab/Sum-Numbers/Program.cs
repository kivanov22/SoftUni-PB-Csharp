using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int Sum = 0;

            for (int i = 0; i < num; i++)
            {
                int num2 = int.Parse(Console.ReadLine());
                Sum = Sum + num2;
            }
            Console.WriteLine(Sum);
        }
    }
}
