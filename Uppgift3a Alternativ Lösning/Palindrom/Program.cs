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
            string userInput = Console.ReadLine().Replace(" ", "").ToLower();
            if (userInput.Reverse().SequenceEqual(userInput))  //http://msdn.microsoft.com/en-us/library/bb348567.aspx
            { Console.WriteLine("det är ett palindrom!"); }
            else
            { Console.WriteLine("Inte ett palindrom!"); }
        }
    }
}
