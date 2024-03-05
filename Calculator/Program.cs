using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int firstInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int secondInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation");
            string operation = Console.ReadLine();

            try
            {
                string result = Calculator.Calculate(firstInput, secondInput, operation).ToString();
                Console.WriteLine("Answer is " + result);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Operation is not supported. " + ex);
            }
            catch (ArgumentNullException ex) when (ex.ParamName == "operation")
            {
                Console.WriteLine("Operation was not provided. " + ex);
            }
            catch (CalculationOperationNotSupportedException ex)
            {
                Console.WriteLine(nameof(CalculationOperationNotSupportedException) + " caught. Operation: " + ex.Operation);
            }
            catch (CalculationException ex)
            {
                Console.WriteLine(nameof(CalculationException) + " caught.");
            }
            catch (ArgumentException ex)
            {
                string exceptionOperation = "";
                if (ex.Data.Contains("Operation"))
                {
                    exceptionOperation = ex.Data["OPERATION"].ToString();
                }
                Console.WriteLine(nameof(ArgumentException) + " caught.");
                Console.WriteLine("Operation: " + exceptionOperation);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, something went wrong." + ex);
            }

            Console.ReadLine();
        }
    }
}
