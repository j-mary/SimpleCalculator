using System.Data;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string operation, double firstNumber, double secondNumber)
        {
            double result;

            switch (operation.ToLower())
            {
                case "add":
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "subtraction":
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "multiplication":
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "division":
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new InvalidExpressionException("Provided operation is not a known type.");
            }

            return result;
        }
    }
}