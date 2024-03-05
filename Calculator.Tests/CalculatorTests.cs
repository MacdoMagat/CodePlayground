using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CatchCalculationException()
        {
            // Arrange
            int num1 = 10;
            int num2 = 0;
            string operation = "/";

            // Act
            // Assert
            Assert.ThrowsException<CalculationException>(() => Calculator.Calculate(num1, num2, operation));
        }

        [TestMethod]
        public void CatchCalculationOperationNotSupportedException()
        {
            // Arrange
            int num1 = 10;
            int num2 = 0;
            string operation = "+";

            // Act
            // Assert
            Assert.ThrowsException<CalculationOperationNotSupportedException>(() => Calculator.Calculate(num1, num2, operation));
        }

        [TestMethod]
        public void Divide()
        {
            // Arrange
            int num1 = 10;
            int num2 = 2;
            string operation = "/";

            // Act
            double result = Calculator.Calculate(num1, num2, operation);
            
            // Assert
            Assert.AreEqual(5, result);
        }
    }
}
