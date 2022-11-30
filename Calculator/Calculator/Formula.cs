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
            double result = 0;
            switch (currentOperation)
            {
                case '+':
                    result = Convert.ToDouble(o) + Convert.ToDouble(t);
                    break;
                case '-':
                    result = Convert.ToDouble(o) - Convert.ToDouble(t);
                    break;
                case '*':
                    result = Convert.ToDouble(o) * Convert.ToDouble(t);
                    break;
                case '/':
                    result = Convert.ToDouble(o) / Convert.ToDouble(t);
                    break;
                default:
                    break;
            }
            return result;
        }



    }
}
