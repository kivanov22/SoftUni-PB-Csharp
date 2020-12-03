using System;

namespace Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (int a = number1; a <= number2; a++)
            {
                for (int b = number1; b <=number2; b++)
                {
                    for (int c = number1; c <= number2; c++)
                    {
                        for (int d = number1; d <= number2; d++)
                        {
                            if(a %2==0 && d % 2 != 0 || d%2==0 && a%2!=0)
                            {
                                if (a > d)
                                {
                                    if ((b + c) % 2 == 0)
                                    {
                                        Console.Write($"{a}{b}{c}{d} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
