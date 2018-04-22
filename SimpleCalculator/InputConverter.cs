using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumber(string input)
        {
            double convertedInput;
            if (!double.TryParse(input, out convertedInput)) throw  new ArgumentException("Expected input should be a number.");
            return convertedInput;
        }
    }
}