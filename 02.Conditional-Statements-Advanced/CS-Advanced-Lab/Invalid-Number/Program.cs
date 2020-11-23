using System;


namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.input number int
            //2.check if its invalid 
            //3.[100…200] или е 0. 
            //4. range >=100 , <=200 !=0

            int num = int.Parse(Console.ReadLine());

            if((num >= 100 && num <=200) || num == 0)
            {
                
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
