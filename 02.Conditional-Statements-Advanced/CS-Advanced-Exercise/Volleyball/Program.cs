using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());

            //1.input
            //2.ne igrae през работните дни и играе волейбол само през уикендите и в празничните дни. 
            //3.Влади играе в София всяка събота, когато не е на работа и не си пътува до родния град, както и в 2/3 от празничните дни. 
            //4.Той пътува до родния си град h пъти в годината, където играе волейбол със старите си приятели в неделя.
            //5.Влади не е на работа 3/4 от уикендите, в които е в София. 
            //6.Отделно, през високосните години Влади играе с 15% повече волейбол от нормалното.
            //7.че годината има точно 48 уикенда, подходящи за волейбол.
            //8.колко пъти Влади е играл волейбол през годината

            //if visokosna ili ne
            //if sofia ili roden grad
            //if weekend free or work
            //if visokosna +15% pove4e 
            //if subota sofia , if nedelq roden grad

            double weekHometown = 48 - weekends;
            double weekSofia = weekHometown * 3.0 / 4;


            double totalHolidays = holidays * 2 / 3.0;

            double totalGames = weekSofia + weekends + totalHolidays;

            if(year == "leap")
            {
             double totalAdditionalGames = totalGames * 0.15;
                double gamesForYear = totalGames + totalAdditionalGames;
                

                Console.WriteLine(Math.Floor(gamesForYear));
            }
            else 
            {
             
                double normal = totalGames;
                Console.WriteLine(Math.Floor(normal));
            }
           

        }
    }
}
