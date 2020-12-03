using System;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int num1 = 1; num1 <=n; num1++)
            {
                for (int num2 = 1; num2 <= n; num2++)
                {
                    for (char symbol1 = 'a'; symbol1 < 'a'+ l; symbol1++)
                    {
                        for (char symbol2 = 'a'; symbol2 < 'a'+l; symbol2++)
                        {
                            for (int num3 = 1; num3 <=n; num3++)
                            {

                                if (num3 > num1 && num3 >num2)
                                {
                                    Console.Write($"{num1}{num2}{symbol1}{symbol2}{num3} ");
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
