using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UpToTwoNumbersTest()
        {
            StringCalculator.Calculator calculator = new StringCalculator.Calculator();
            var rtnVal = calculator.Add("");
            Assert.AreEqual(0, rtnVal);

            rtnVal = calculator.Add("1");
            Assert.AreEqual(1, rtnVal);

            rtnVal = calculator.Add("1,2");
            Assert.AreEqual(3, rtnVal);
        }


        [TestMethod]
        public void UnknownAmountOfIntsTest(){
            StringCalculator.Calculator calculator = new StringCalculator.Calculator();
            var rtnVal = calculator.Add("1,1,1,1");
            Assert.AreEqual(4, rtnVal);

        }
        [TestMethod]
        public void HandleNewLineCharTest()
        {
            StringCalculator.Calculator calculator = new StringCalculator.Calculator();
            var rtnVal = calculator.Add("1\n2,3");
            Assert.AreEqual(6, rtnVal);

        }

        [TestMethod]
        public void SuportDiffDelimitersTest()
        {
            StringCalculator.Calculator calculator = new StringCalculator.Calculator();
            var rtnVal = calculator.Add("//;\n1;2");
            Assert.AreEqual(3, rtnVal);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UsingNegitivesTest()
        {
            StringCalculator.Calculator calculator = new StringCalculator.Calculator();
            var rtnVal = calculator.Add("//;\n-1;2");
            Assert.Fail();

        }


    }
}
