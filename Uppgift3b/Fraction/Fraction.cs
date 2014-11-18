using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    //        En konstruktor som skapar och initialiserar ett nytt bråktal. 
    //        Metoderna getNumerator och getDenominator som returnerar täljaren 
    //      respektive nämnaren. 
    //      Metoden isNegative som ger true om det är ett negativt bråktal. 
    //      Metoderna add och multiply som utför motsvarande bråktalsoperation på två 
    //      bråk och som returnerar ett nytt bråktal. Bestäm själv ett lämpligt sätt att hantera de 
    //      fall där någon av de inblandade bråktalen har noll i nämnaren. 
    //      isEqualTo som jämför två Fraction-instanser och ser om de representerar samma 
    //      bråktal. 
    //      toString som returnerar en strängrepresentation av bråktalet på form T/


    //2.5 timmar 17:30
    class Fraction
    {
        private decimal _numerator;
        private decimal _denominator;
        public decimal getNumerator
        {
            get { return _numerator; }
            set { 
                
                _numerator = value; }
        }
        public decimal getDenominator
        {
            get { return _denominator; }
            set { 
                if (value == 0)
                { throw new ArgumentException("Nämnaren kan inte vara noll..."); }
                _denominator = value; 
            }
        }
        public Fraction(decimal numerator, decimal denominator)
        {
            getNumerator = numerator;
            getDenominator = denominator;
        }
        public Fraction add(Fraction a)
        {
            decimal newNum = (this.getNumerator * a.getDenominator) + (a.getNumerator * this.getDenominator);
            decimal newDenom = (this.getDenominator * a.getDenominator);
            Fraction addResult = new Fraction(newNum, newDenom);
            return addResult;
        }

        public Fraction multiply(Fraction a)
        {
            decimal newnum = a.getNumerator * this.getNumerator;
            decimal newdenom = a.getDenominator * this.getDenominator;
            Fraction multResult = new Fraction(newnum, newdenom);
            return multResult;
        }

        public bool isNegative()
        {
            //om negativ returnera true

            //annars false
            return false;
        }

        public bool isEqualTo(Fraction a)
        {
            if (a.getNumerator/a.getDenominator == this.getNumerator/this.getDenominator)
            {
                return true;
            }
            else 
            return false;
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}", getNumerator, getDenominator);
        }
    }
}
