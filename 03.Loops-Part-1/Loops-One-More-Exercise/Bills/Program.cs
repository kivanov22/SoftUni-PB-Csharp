using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double electricity = 0.0;
            double water = 0.0;
            double internet = 0.0;
            double others = 0.0;
            double average = 0.0;

            double waterBill = 20;
            double internetBill = 15;
            double sumAll = 0.0;
            double othersBill = 0.0;
            //пресмята средният разход за месец на семейство за даден период време
            // •	За ток – всеки месец е различен, ще се чете от конзолата
            //•	за вода – 20 лв.
            //•	за интернет – 15 лв.
            //•	за други – събират се тока, водата и интернета за месеца и към сумата се прибавят 20 %.
            //колко общо е платено за всички месеци.

            for (int i = 1; i <= months; i++)
            {
                double billElec = double.Parse(Console.ReadLine());


                //Electricity
                electricity += billElec;

                //Water

                water = months * waterBill;

                //Internet
                internet = months * internetBill;

                //Others
                sumAll = billElec + waterBill + internetBill;
                othersBill = sumAll * 0.2 + sumAll;
                others += othersBill;

                //Average monthly
                average = (electricity + water + internet+others) / months;

            }

            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }

    }
}

