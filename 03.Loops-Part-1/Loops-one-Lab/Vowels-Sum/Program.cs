using System;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int Sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        Sum += 1;
                        break;
                    case 'e':
                        Sum += 2;
                        break;
                    case 'i':
                        Sum += 3;
                        break;
                    case 'o':
                        Sum += 4;
                        break;
                    case 'u':
                        Sum += 5;
                        break;
                }


            }
            Console.WriteLine(Sum);
        }
    }
}
