using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(0, Calculator.Add(0, 0));
            Assert.AreEqual(4, Calculator.Add(2, 2));
            Assert.AreEqual(8, Calculator.Add(2, 6));
        }
        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(6, Calculator.Subtract(10, 4));
        }
        [TestMethod]
        public void Sum()
        {
            //Arrange
            int[] numbers = new int[2]; //{ };
            Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(18, Calculator.Sum(numbers));

        }
        [TestMethod]
        public void Multiply()
        {
            int[] numbers = { 3, 4 };
            Assert.AreEqual(12, Calculator.Multiply(numbers));

            Array.Resize(ref numbers, 4);
            numbers[0] = -5;
            numbers[1] = 4;
            numbers[2] = 10;
            numbers[3] = 3;
           
            Assert.AreEqual(-600, Calculator.Multiply(numbers));
            //It multiplies two numbers
            //It multiplies several numbers
            //throw new NotImplementedException();
        }
        [TestMethod]
        public void Power()
        {
            Assert.AreEqual(128, Calculator.Power(2, 7));
            Assert.AreEqual(1, Calculator.Power(2, 0));
            Assert.AreEqual(32, Calculator.Power(2, 5));
            Assert.AreEqual(100, Calculator.Power(10, 2));
            Assert.AreEqual(10000, Calculator.Power(10, 4));
        }

        [TestMethod]
        public void Factorial()

        {
            Assert.AreEqual(6, Calculator.Factorial(3));
            Assert.AreEqual(479001600, Calculator.Factorial(12));
            Assert.AreEqual(362880, Calculator.Factorial(9));
            Assert.AreEqual(3628800, Calculator.Factorial(10));
            //# http://en.wikipedia.org/wiki/Factorial
            //  it "computes the factorial of 0"
            //  it "computes the factorial of 1"
            //  it "computes the factorial of 2"
            //  it "computes the factorial of 5"
            //  it "computes the factorial of 10"
            //throw new NotImplementedException();
        }
    }
}
