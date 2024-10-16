using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixUCarApp
{
    public class Calculator
    {
        public int addNumbers(int a,int b)
        {
            return a + b;
        }

        public bool IsOddNumber(int a)
        {
            return (a % 2 == 0);
        }
    }
}
