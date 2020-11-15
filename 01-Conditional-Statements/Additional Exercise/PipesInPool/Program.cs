using System;
using System.Xml.Schema;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int areaV = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double totalP1 = p1 * hours;      
            double totalP2 = p2 * hours;
            double totalLitters = totalP1 + totalP2;   //общо литри

            double percent = totalLitters / areaV * 100;             //проценти
            double pipePercent1 = totalP1 / totalLitters * 100;
            double pipePercent2 = totalP2 / totalLitters * 100;

            if(totalLitters <= areaV)
            {
                Console.WriteLine($"The pool is {percent:f2}% full. Pipe 1: {pipePercent1:f2}%. Pipe 2: {pipePercent2:f2}%.");
            }
            else if (totalLitters >= areaV)
            {
                double overCap = totalLitters - areaV;
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {overCap} liters.");
            }
        }
    }
}
