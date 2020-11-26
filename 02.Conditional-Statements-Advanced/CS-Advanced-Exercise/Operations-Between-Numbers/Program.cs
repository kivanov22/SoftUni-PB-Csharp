using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            //1.input
            //Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%). 
            //събиране, изваждане и умножение на конзолата трябва да се отпечатат резултата и дали той е четен или нечетен.
            //обикновеното деление – резултата. При модулното деление – остатъка. 
            //делителят може да е равен на 0(нула), а на нула не се дели. В този случай трябва да се отпечата специално съобщениe.
            
            switch (operation)
            {
                case '+':
                    int sum = num1 + num2;
                    if(sum % 2 == 0)
                    {
                        Console.WriteLine($"{num1} {operation} {num2} = {sum} - even");

                    }
                    else
                    {
                        Console.WriteLine($"{num1} {operation} {num2} = {sum} - odd");
                    }
                    
                    break;
                case '-':
                    int diff = num1 - num2;
                    if(diff % 2 == 0)
                    {
                        Console.WriteLine($"{num1} {operation} {num2} = {diff} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} {operation} {num2} = {diff} - odd");
                    }
                    
                    break;
                case '*':
                    int multi = num1 * num2;
                    if(multi % 2 == 0)
                    {
                        Console.WriteLine($"{num1} {operation} {num2} = {multi} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} {operation} {num2} = {multi} - odd");
                    }
                            
                    break;
                case '/':
                    if(num2 == 0) //proverka vtoroto chislo dali se deli na 0
                    {
                        // ne se deli na 0
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        double devision = num1 * 1.0 / num2;
                        Console.WriteLine($"{num1} / {num2} = {devision:f2}");
                    }
                    break;
                case '%':
                    if(num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        double percent = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {percent}");
                    }
                    break;
                
            }
        }
    }
}
