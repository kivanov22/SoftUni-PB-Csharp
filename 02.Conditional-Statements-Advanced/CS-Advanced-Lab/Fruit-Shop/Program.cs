using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. work days price 
            // плод   banana  apple  orange   grapefruit  kiwi    pineapple grapes
            //цена    2.50    1.20    0.85    1.45        2.70    5.50      3.85

            // 2. weekend price
            //плод banana  apple orange  grapefruit kiwi    pineapple grapes
            //цена    2.70    1.25    0.90    1.60    3.00    5.60    4.20

            // 3.take input fruit/day/quantity
            // 4.output format f2
            // 5.if invalid food name or day give error 

            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;


            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {


                switch (fruit)
                {
                    case "banana":
                        price = 2.50;
                        break;
                    case "apple":
                        price = 1.20;
                        break;
                    case "orange":
                        price = 0.85;
                        break;
                    case "grapefruit":
                        price = 1.45;
                        break;
                    case "kiwi":
                        price = 2.70;
                        break;
                    case "pineapple":
                        price = 5.50;
                        break;
                    case "grapes":
                        price = 3.85;
                        break;
                    
                }
                }

            if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.70;
                        break;
                    case "apple":
                        price = 1.25;
                        break;
                    case "orange":
                        price = 0.90;
                        break;
                    case "grapefruit":
                        price = 1.60;
                        break;
                    case "kiwi":
                        price = 3.00;
                        break;
                    case "pineapple":
                        price = 5.60;
                        break;
                    case "grapes":
                        price = 4.20;
                        break;
                    



                }
            }
            //da dobavim if koeto proverqva price i izkarva error 
                

                    double totalPrice = quantity * price;
                    Console.WriteLine($"{totalPrice:f2}");
                }
            }
        }
    

