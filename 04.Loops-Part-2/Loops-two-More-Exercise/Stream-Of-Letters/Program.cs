using System;

namespace Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            
            int countC = 0;
            int countO = 0;
            int countN = 0;
            string secretWord = "";
            string word = "";

            while (command != "End") //цикъла се върти до енд команда
            {
                char letter = char.Parse(command);//преобразувам в чар за символи

                if(letter >='a' && letter <= 'z'|| letter >= 'A' && letter<= 'Z')//задавам от коя до коя, и да има главни букви
                {
                    if(command == "c" && countC == 0)
                    {
                        countC++;
                        
                    }
                    else if(command == "o"&& countO == 0)//трите скрити букви
                    {
                        countO++;
                        
                    }
                    else if(command =="n"&& countN == 0)//брояч и за трите букви
                    {
                        countN++;
                        
                    }
                    else
                    {
                        word += letter; //стринг за запазване на въведените букви
                    }
                    if (countC+countN+countO == 3) // когато се изпишат и трите скрити букви 
                    {
                        //май ги нулираме 
                       secretWord +=word; //празния стринг да взима думата от всички букви
                        secretWord += ' '; 
                        word = "";
                        countO = 0;
                        countN = 0;
                        countC = 0;
                        

                    }
                    
                }
                command = Console.ReadLine(); //да продължат да се добавят от конзолата букви
            }
            
                Console.WriteLine(secretWord); //изписване
            


        }
    }
}
