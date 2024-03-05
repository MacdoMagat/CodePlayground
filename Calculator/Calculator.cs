using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {
        public static double Calculate(int num1, int num2, string operation)
        {
            string myOperation = operation ?? throw new ArgumentNullException(nameof(operation));
            if (myOperation == "/")
            {
                try
                {
                    return Divide(num1, num2);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Error in dividing");
                    throw new CalculationException(ex);
                }
            }
            else
            {
                throw new CalculationOperationNotSupportedException(operation);
            }
        }

        public static double Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
