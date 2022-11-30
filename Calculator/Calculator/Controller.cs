using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Controller
    {
        public string Input(string input)
        {
            char[] operations = { '+', '-', '*' };
            int t=0;
            string test = " ";
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < operations.Length; j++)
                {
                    if (input[i] == operations[j])
                    {
                        t +=1;
                        test = t.ToString() + " operations found";

                    }
                }                
            }
            return test;
        }
    }
}
