using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double changeInLeva = double.Parse(Console.ReadLine());
            double change = Math.Floor(changeInLeva * 100); // resto v stotinki , mathfloor za da nqma nuli
            //proverka s koq moneta shte mojem da vurnem; vrushtame moneta ;broim moneta
            //stop change ==0
            //produljavame change !=0

            int count = 0;

            while (change != 0)
            {
                if (change >= 200)//2.00
                {

                    change -= 200;  //2.00
                    count++;
                }
                else if (change >= 100)
                {
                    change -= 100;
                    count++;
                }
                else if (change >= 50)
                {
                    change -= 50;
                    count++;
                }
                else if (change >= 20)
                {
                    change -= 20;
                    count++;
                }
                else if (change >= 10)
                {
                    change -= 10;
                    count++;
                }
                else if (change >= 5)
                {
                    change -= 5;
                    count++;
                }
                else if (change >= 2)
                {
                    change -= 2;
                    count++;
                }
                else if (change >= 1)
                {
                    change -=1;
                    count++;
                }


            }
            Console.WriteLine(count);
        }
    }
}
