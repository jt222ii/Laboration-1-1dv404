using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1a
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString = Console.ReadLine();
            int countA = 0;
            int counta = 0;
            foreach (char a in userString)
            {
                if (a == 'A')
                { countA++; }
                if (a == 'a')
                { counta++; }
            }
            Console.WriteLine("antalet stora A var: {0}\nantalet små a var: {1}", countA, counta);
        }
    }
}
