using System;

namespace Safe_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPassword = int.Parse(Console.ReadLine());

            int counter = 0;//брояч
            int i = 35;
            int j = 64;

            while (i<=55)//първите две букви
            {
                while (j<=96)
                {
                    for (int k = 1; k <= a; k++)//вторите 2
                    {
                        for (int h = 1; h <= b; h++)
                        {

                            char one = ((char)i);//превръщаме инт в чар
                            char two = ((char)j); // 

                            Console.Write($"{one}{two}{k}{h}{two}{one}|");// принтираме една комбинация
                            counter += 1; // брояча го дигаме с 1
                            i++;
                            j++;

                            if(counter>=maxPassword || k==a&& h == b)// проверка ако брояча е по голям или равен на макс пароли,
                            {
                                return;
                            }
                            if (i > 55)// задаваме нови стойности на променивите
                            {
                                i = 35;
                            }
                            if (j > 96)
                            {
                                j = 64;
                            }
                        }
                    }
                }
            }
        }
    }
}
