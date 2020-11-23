using System;

namespace TradeCommisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.input string - grad i chislo obem na prodajbi relano chislo
            //2.calculate commision from tables check in which of the 4 is the number
            //3.output the result f:2
            //4.Invalid town or area(negative number) give error

            //Град    0 ≤ s ≤ 500 || 500 < s ≤ 1 000 ||1 000 < s ≤ 10 000 ||  s > 10 000  <-----4 categories
            //Sofia   5 %             7 %                      8 %             12 %
            //Varna   4.5              7.5 %                  10 %              13 %
            //Plovdiv 5.5 %           8 %                      12 %             14.5 %



            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = -1.0;

            if (0 <=sales && sales <= 500)
            {
                if (town == "Sofia")
                {
                    commission = 0.05;
                }
              else   if (town == "Varna")
                {
                    commission = 0.045;
                }
               else  if (town == "Plovdiv")
                {
                    commission = 0.055;
                }
            }
            else if (500< sales && sales <= 1000)
            {
                if (town == "Sofia")
                {
                    commission = 0.07;
                }
               else if (town == "Varna")
                {
                    commission = 0.075;
                }
            else  if (town == "Plovdiv")
                {
                    commission = 0.08;
                }
            }
            else if (1000 < sales && sales <= 10000)
            {
                if (town == "Sofia")
                {
                    commission = 0.08;
                }
              else  if (town == "Varna")
                {
                    commission = 0.1;
                }
             else   if (town == "Plovdiv")
                {
                    commission = 0.12;
                }
            }
            else if (sales > 10000)
            {
                if (town == "Sofia")
                {
                    commission = 0.12;
                }
              else  if (town == "Varna")
                {
                    commission = 0.13;
                }
               else if (town == "Plovdiv")
                {
                    commission = 0.145;
                }
            }

                if (commission >= 0)
                {
                double totalCom = sales * commission;
                Console.WriteLine($"{totalCom:f2}");
               
                
                }

                else
                {
                Console.WriteLine("error");
            }

            }
        }
    }

   
        
    

