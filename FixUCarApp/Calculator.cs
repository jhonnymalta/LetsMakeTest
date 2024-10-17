using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixUCarApp
{
    public class Calculator
    {

        public List<int> NumberRange = new List<int>();
        public int addNumbers(int a,int b)
        {
            return a + b;
        }

        public double addNumbersDouble(double a, double b) { 
            return a + b;
        }

        public bool IsOddNumber(int a)
        {
            return (a % 2 == 0);
        }

        public List<int> GetOddRange(int min,int max)
        {
            NumberRange.Clear();
            for (int i = min; i < max; i++)
            {
                if(i%2 != 0)
                {
                    NumberRange.Add(i);
                }
            }
            return NumberRange;
        }
    }
}
