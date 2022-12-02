using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Formula
    {

        public double Calc(char currentOperation,string o, string t)
        {
            switch (currentOperation)
            {
                case '+':
                    return Convert.ToDouble(o) + Convert.ToDouble(t);
                case '-':
                    return Convert.ToDouble(o) - Convert.ToDouble(t);
                case '*':
                    return Convert.ToDouble(o) * Convert.ToDouble(t);
                case '/':
                    return Convert.ToDouble(o) / Convert.ToDouble(t);
                default:
                    return 0;
            }
        }



    }
}
