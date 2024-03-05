using System;
using System.Runtime.Serialization;
using System.Web;

namespace Calculator
{
    [Serializable]
    public class CalculationOperationNotSupportedException : Exception
    {
        private const string DefaultMessage = "Specified operation was out of the range of valid values.";
        public string Operation { get; }

        public CalculationOperationNotSupportedException() : base(DefaultMessage)
        {
        }

        public CalculationOperationNotSupportedException(Exception innerException) : base(DefaultMessage, innerException)
        {
        }

        public CalculationOperationNotSupportedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public CalculationOperationNotSupportedException(string operation) : base(DefaultMessage)
        {
            Operation = operation;
        }

        public CalculationOperationNotSupportedException(string operation, string message) : base(message)
        {
            Operation = operation;
        }

        public override string ToString()
        {
            if (Operation == null)
            {
                return base.ToString();
            }
            return base.ToString() + Environment.NewLine + "Unsupported Operation: " + Operation;
        }
    }
}