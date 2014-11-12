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
                        Console.WriteLine("näst störst: Finns endast ett värde!");
                    }
                    else if (userInput == highest)
                    {
                        nextHighest = highest;
                        highest = userInput;
                        Console.WriteLine("finns ingen siffra mindre än den största!");
                    }
                    else
                    {
                        if (userInput > highest)
                        {
                            nextHighest = highest;
                            highest = userInput;
                        }
                        else if (userInput > nextHighest && userInput < highest || nextHighest > highest && userInput < highest || userInput == highest && userInput != nextHighest && userInput != highest)
                        {
                            nextHighest = userInput;
                        }
                        Console.WriteLine("näst störst: {0}", nextHighest);
                    }
                    i++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Skriv in en giltig siffra!");
                }
            } while (i < amountOfNumbers);
            

        }
    }
}
