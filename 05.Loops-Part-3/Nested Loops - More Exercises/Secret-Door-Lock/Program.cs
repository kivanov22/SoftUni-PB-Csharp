using System;

namespace Secret_Door_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundreds = int.Parse(Console.ReadLine());
            int tens = int.Parse(Console.ReadLine());
            int units = int.Parse(Console.ReadLine());

            for (int a = 2; a <= hundreds; a++)
            {
                for (int b = 2; b <= tens; b++)
                {
                    for (int c = 2; c <=units; c++)
                    {

                        if (a % 2 == 0)
                        {
                            if (b == 2 || b ==3 ||b==5 || b==7)
                            {
                                if (c % 2 == 0)
                                {
                                    Console.WriteLine($"{a} {b} {c}");
                                }
                            }
                        }


                    }
                }
            }
        }
    }
}
