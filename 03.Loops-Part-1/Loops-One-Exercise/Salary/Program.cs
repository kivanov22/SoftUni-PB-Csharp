using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= tabs; i++)
            {
                string website = Console.ReadLine();

                switch (website)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 100;
                        break;
                }
            

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
                break;
            }
        }
                if(salary >0)
                {
                    Console.WriteLine(salary);
                }

            }
        }
    }

