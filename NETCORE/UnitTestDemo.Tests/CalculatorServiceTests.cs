using Moq;
using NUnit.Framework;
using UnitTestDemo.Services;

namespace UnitTestDemo.Tests
{
    public class CalculatorServiceTests
    {
        ICalculatorService _calc;

        [SetUp]
        public void Setup()
        {
            _calc = new CalculatorService();
        }

        [Test]
        public void Add_1_Add_1_Is_2() //Nightmare
        {
            var result = _calc.Add(1, 1);
            Assert.AreEqual(result, 2);
        }



















        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(1, 2, 3)]
        [TestCase(10, 10, 20)]
        public void Add(int num1, int num2, int expectedResult)
        {
            var result = _calc.Add(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }






















        [Test]
        [TestCase(1, 1, CalculatorOperation.Add, 2)]
        [TestCase(1, 1, CalculatorOperation.Subtract, 0)]
        public void Operation(int num1, int num2, CalculatorOperation operation, int expectedResult)
        {
            var result = _calc.Operation(num1, num2, operation);
            Assert.AreEqual(expectedResult, result);
        }

    }
}