using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int countTotalBooks = int.Parse(Console.ReadLine());

            int checkedBooks = 0;

            while (countTotalBooks >0)
            {
                string title = Console.ReadLine();
                
                if(searchedBook == title)
                {
                    // if we find the book
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    break;
                }
                else
                {
                    //if we don't find the book
                    checkedBooks++;
                }

                countTotalBooks--;
            }
            if(countTotalBooks <= 0)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
                
            }

        }
    }
}
