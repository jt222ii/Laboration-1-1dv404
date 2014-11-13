using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastStorsta
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfNumbers = 10; // antal nummer användaren ska skriva in


            int nextHighest = 0;
            int highest = 0;
            int userInput;
            int i = 0;



            do
            {
                try
                {
                    Console.Write("Tal {0}: ", i + 1);
                    userInput = int.Parse(Console.ReadLine());
                    if (i == 0)
                    { 
                        highest = userInput;
                        nextHighest = userInput;
                    }
                    else if (userInput == highest && nextHighest == highest)  // för att man inte ska kunna skriva in 12 rakt igenom och den säger att 12 är näst störst.
                    {                                                         //När nextHighest har fått ett annat värde än highest körs inte längre denna if sats.
                        nextHighest = highest;
                        highest = userInput;
                    }
                    else
                    {
                        if (userInput > highest)
                        {
                            nextHighest = highest;
                            highest = userInput;
                        }
                        else if (userInput > nextHighest && userInput < highest || userInput < nextHighest && nextHighest == highest)
                        {
                            nextHighest = userInput;
                        }
                    }                  
                    i++;
                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Skriv in en giltig siffra!");
                    Console.ResetColor();
                }
            } while (i < amountOfNumbers);


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            if (highest == nextHighest)
            { Console.WriteLine("finns ingen siffra mindre än den största!"); }
            else
                Console.WriteLine("näst störst: {0}", nextHighest);
            Console.ResetColor();

        }
    }
}
