using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en något så kollar jag om det är ett palindrom!");
            string userInput = Console.ReadLine();
            userInput = userInput.Replace(" ", "");
            userInput = userInput.ToLower(); 
            bool palindrome = isPalindrome(userInput);
            if (palindrome == true)
            {
                Console.WriteLine("det är ett palindrom!");
            }
            else
            {
                Console.WriteLine("det är inte ett palindrom! :(");
            }
        }
        static bool isPalindrome(string input)
        {
            int max = input.Length - 1;
            int min = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[max] != input[min])
                {
                    return false;
                }
                if (input[max] == input[min])
                {
                    max--;
                    min++;
                }
            }
            return true;
        }
    }
}
