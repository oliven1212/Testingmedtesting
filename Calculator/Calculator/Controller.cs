using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Controller
    {
        Formula formula = new Formula();
        public string Input(string input)
        {
            char[] operations = { '+', '-', '*', '/' };
            int requiredOperations = 0;
            string Result = " ";
            double tempValue = 0;

            for (int i = 0; i < input.Length; i++) //Goes through the whole input which is the formula the user inserts
            {
                for (int j = 0; j < operations.Length; j++)//Goes through all operations
                {
                    if (input[i] == operations[j])
                    {
                        requiredOperations += 1; //calculates how many operations there is in the input (formula)
                        Result = requiredOperations.ToString() + " operations found";
                    }
                }
            }


            char currentOperation = '+';


            char[] operationsLayor1 = { '+', '-' };
            char[] operationsLayor2 = { '*', '/' };


            for (int i = 0; i < input.Length; i++) //Goes through the whole input which is the formula the user inserts
            {
                for (int j = 0; j < operationsLayor2.Length; j++)//Goes through * and / operations
                {
                    currentOperation = operationsLayor2[j];

                    //INPROGRESS HERE!
                }
            }

            for (int i = 0; i < input.Length; i++) //Goes through the whole input which is the formula the user inserts
            {
                for (int j = 0; j < operationsLayor1.Length; j++)//Goes through + and -
                { }
            }

            tempValue = formula.Calc(currentOperation, "3", "2");



            Result = tempValue.ToString();
            return Result;
        }
    }
}
