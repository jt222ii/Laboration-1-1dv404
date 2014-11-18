using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fraction
    {
        private int _numerator;
        private int _denominator;
        public int getNumerator
        {
            get { return _numerator; }
            set { 
                
                _numerator = value; }
        }
        public int getDenominator
        {
            get { return _denominator; }
            set { 
                if (value == 0)
                { throw new ArgumentException("Nämnaren kan inte vara noll..."); }
                _denominator = value; 
            }
        }
        public Fraction(int numerator, int denominator)
        {
            getNumerator = numerator;
            getDenominator = denominator;
        }
        public Fraction add(Fraction a)
        {
            int newNum = (this.getNumerator * a.getDenominator) + (a.getNumerator * this.getDenominator);
            int newDenom = (this.getDenominator * a.getDenominator);
            Fraction addResult = new Fraction(newNum, newDenom);
            return addResult;
        }

        public Fraction multiply(Fraction a)
        {
            int newnum = a.getNumerator * this.getNumerator;
            int newdenom = a.getDenominator * this.getDenominator;
            Fraction multResult = new Fraction(newnum, newdenom);
            return multResult;
        }

        public bool isEqualTo(Fraction a)
        {
            if ((decimal)a.getNumerator / (decimal)a.getDenominator == (decimal)this.getNumerator / (decimal)this.getDenominator)
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
