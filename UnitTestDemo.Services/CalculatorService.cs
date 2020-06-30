using System;

namespace UnitTestDemo.Services
{

    public enum CalculatorOperation
    {
        Add,
        Subtract,
        Divide,
        Multiply,
        Modulus
    }
    public interface ICalculatorService
    {
        int Add(int num1, int num2);
        int Operation(int num1, int num2, CalculatorOperation calculatorOperation);
    }

    public class CalculatorService : ICalculatorService
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Operation(int num1, int num2, CalculatorOperation calculatorOperation)
        {
            throw new NotImplementedException();
        }
    }
}
