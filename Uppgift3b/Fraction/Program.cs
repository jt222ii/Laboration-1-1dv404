using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {


        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;

            int choice = menu();
            if (choice == 0)
            { return; }

            a = userInput("Ange första bråkets täljare:");
            b = userInput("Ange första bråkets nämnare:");
            Fraction fraction1 = new Fraction(a, b);
            c = userInput("Ange andra bråkets täljare:");
            d = userInput("Ange andra bråkets nämnare:");
            Fraction fraction2 = new Fraction(c, d);

            switch(choice)
            {
                case 1:
                    Fraction addResult = fraction1.add(fraction2);
                    viewResult(string.Format("Resultatet för {0} + {1} blir:", fraction1, fraction2), addResult);
                    break;
                case 2:
                    Fraction multResult = fraction1.multiply(fraction2);
                    viewResult(string.Format("Resultatet för {0} * {1} blir:", fraction1, fraction2), multResult);
                    break;
                case 3:
                    bool result = fraction1.isEqualTo(fraction2);
                    if(result)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("{0} & {1} är lika!", fraction1, fraction2);
                        Console.ResetColor();
                        break;
                    }
                    else
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} & {1} är INTE lika!", fraction1, fraction2);
                    Console.ResetColor();
                    break;
            }

        }
        static int userInput(string prompt)
        {
            Console.WriteLine(prompt);
            return int.Parse(Console.ReadLine());

        }

        static int menu()
        {
            Console.WriteLine("0. Avsluta 1. Addera Bråktal 2. Multiplicera Bråktal 3. Jämför Bråktal");
            int userChoice = int.Parse(Console.ReadLine());
            if  (userChoice < 0 || userChoice > 3)
            { 
                Console.WriteLine("Du valde inte ett giltigt alternativ... stänger av programmet");
                return 0;  
            }
            else
            return userChoice;
        }

        static void viewResult(string prompt, Fraction a)
        {
            Console.WriteLine("{0} {1}", prompt, a.ToString());
        }
    }
}
