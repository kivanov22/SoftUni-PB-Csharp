using System;

namespace The_Song_Of_The_Wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());

            int counter = 0;
            bool checkFour = false;
            string password = "";

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d < 9; d++)
                        {



                            if (a < b && c > d)
                            {
                                int calculation = a * b + c * d;

                                if (calculation == m)
                                {

                                    Console.Write($"{a}{b}{c}{d} ");
                                    counter++;

                                    
                                    if (counter == 4)
                                    {

                                        password = $"{a}{b}{c}{d}";
                                        checkFour = true;
                                    }
                                   
                                }
                                
                                    

                            }
                            
                        }
                        
                    }
                }

               

                if (checkFour==true)
                {
                    Console.WriteLine($"Password: {password}");
                }
                else
                {
                    Console.WriteLine("No!");
                }





                //Console.WriteLine();
                //if(counter > 0)
                //{
                //    Console.WriteLine();
                //}

                //if (checkFour==true)//password != null
                //{
                //    Console.WriteLine($"Password: {password} ");

                //}
                //if (checkFour == true)
                //{
                //    Console.WriteLine($"Password: {password} ");



                //}
                //else
                //{
                //    Console.WriteLine("No!");
                //}

            }
            }
        }
    }

