using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter inputConverter = new InputConverter();

        [TestMethod]
        public void Can_Convert_Inputed_String_To_Number()
        {
            string _string = "5";
            double convertedNumber = inputConverter.ConvertInputToNumber(_string);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Throw_Exception_If_Input_Fails_To_Convert_To_Number()
        {
            string _string = "*";
            inputConverter.ConvertInputToNumber(_string); 
        }
    }
}
