﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfZeroes = 0;
            int numberOfEven = 0;
            int numberOfOdd = 0;

            string userinput = Console.ReadLine();

            foreach (char digit in userinput)
            {
                if(int.Parse(digit.ToString()) == 0)
                { numberOfZeroes++; }
                else if (int.Parse(digit.ToString()) % 2 == 0)
                { numberOfEven++; }
                else if (int.Parse(digit.ToString()) % 2 != 0)
                { numberOfOdd++; }
            }
            Console.WriteLine("Nollor: {0}  Jämna: {1}  Udda: {2}",numberOfZeroes,numberOfEven,numberOfOdd);
        }
    }
}
