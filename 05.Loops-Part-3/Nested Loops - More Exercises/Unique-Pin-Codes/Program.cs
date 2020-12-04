using System;

namespace Unique_Pin_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());


            //first and third equal
            //second has to be simple number
            for (int start1 = 2; start1 <= num1; start1+=2) // четни числа
            {
                for (int start2 = 2; start2 <= num2; start2++)
                {
                    for (int start3 = 2; start3 <= num3; start3 += 2)// четни числа
                    {
                        if (start2 == 2 || start2 ==3 ||start2 == 5 || start2==7)// прости числа проверка
                        {
                            Console.WriteLine($"{start1} {start2} {start3}");
                        }
                    }
                }
            }



        }
    }
}
