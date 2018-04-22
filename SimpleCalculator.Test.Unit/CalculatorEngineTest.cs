using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void Can_Add_Two_Numbers_For_Non_Symbol_Operation()
        {
            int number1 = 5;
            int number2 = 10;
            double result = calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Can_Add_Two_Numbers_For_Symbol_Operation()
        {
            int number1 = 5;
            int number2 = 10;
            double result = calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Can_Subtract_Two_Numbers_For_Non_Symbol_Operation()
        {
            int number1 = 10;
            int number2 = 5;
            double result = calculatorEngine.Calculate("subtract", number1, number2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Can_Subtract_Two_Numbers_For_Symbol_Operation()
        {
            int number1 = 10;
            int number2 = 5;
            double result = calculatorEngine.Calculate("-", number1, number2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Can_Multiply_Two_Numbers_For_Non_Symbol_Operation()
        {
            int number1 = 5;
            int number2 = 10;
            double result = calculatorEngine.Calculate("multiply", number1, number2);
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Can_Multiply_Two_Numbers_For_Symbol_Operation()
        {
            int number1 = 5;
            int number2 = 10;
            double result = calculatorEngine.Calculate("*", number1, number2);
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Can_divide_Two_Numbers_For_Non_Symbol_Operation()
        {
            int number1 = 10;
            int number2 = 5;
            double result = calculatorEngine.Calculate("divide", number1, number2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Can_divide_Two_Numbers_For_Symbol_Operation()
        {
            int number1 = 10;
            int number2 = 5;
            double result = calculatorEngine.Calculate("/", number1, number2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Throw_Exception_If_Operation_Is_Not_A_Known_Type()
        {
            int number1 = 10;
            int number2 = 5;
            calculatorEngine.Calculate("$", number1, number2);
        }
    }
}
