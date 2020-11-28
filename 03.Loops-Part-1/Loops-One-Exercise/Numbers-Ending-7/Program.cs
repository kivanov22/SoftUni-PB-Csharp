using System;

namespace Numbers_Ending_7
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 7; i <= 997; i++)//startirame ot 7 do 997
            {
                if (i % 10 == 7)//modulno delenie na 10 i ravno na 7
                {
                    Console.WriteLine(i);//otpechatvame
                }
            }
        }
    }
}
