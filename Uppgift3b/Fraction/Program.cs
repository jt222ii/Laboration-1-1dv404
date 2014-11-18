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
            decimal a;
            decimal b;
            decimal c;
            decimal d;
            int choice = menu();
            if(choice == 0)
            { return; }
            a = userInput("Ange första bråkets täljare:");
            b = userInput("Ange första bråkets nämnare:");
            c = userInput("Ange andra bråkets täljare:");
            d = userInput("Ange andra bråkets nämnare:");
            Fraction fraction1 = new Fraction(a, b);
            Fraction fraction2 = new Fraction(c, d);

            switch(choice)
            {
                case 1:
                    Fraction addResult = fraction1.add(fraction2);
                    Console.WriteLine(addResult);
                    break;
                case 2:
                    Fraction multResult = fraction1.multiply(fraction2);
                    Console.WriteLine(multResult);
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
        static decimal userInput(string prompt)
        {
            Console.WriteLine(prompt);
            return decimal.Parse(Console.ReadLine());
        }

        static int menu()
        {
            Console.WriteLine("0. Avsluta 1. Addera Bråktal 2. Multiplicera Bråktal 3. Jämför Bråktal");
            return int.Parse(Console.ReadLine());
        }
    }
}
