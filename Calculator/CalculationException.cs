using System;
using System.Runtime.Serialization;

namespace Calculator
{
    [Serializable]
    public class CalculationException : Exception
    {
        private const string DefaultMessage = "An error occured during calculation. Ensure that the operator is supported and that the values are within range for the requested operation.";
        public CalculationException() : base(DefaultMessage)
        {
        }

        public CalculationException(string message) : base(message)
        {
        }

        public CalculationException(Exception innerException) : base(DefaultMessage, innerException)
        {
        }

        public CalculationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}