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

        private int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Operation(int num1, int num2, CalculatorOperation calculatorOperation)
        {

            //Add if for num1/2

            switch (calculatorOperation)
            {
                case CalculatorOperation.Add:
                    return Add(num1, num2);
                case CalculatorOperation.Subtract:
                    return Subtract(num1, num2);
                case CalculatorOperation.Divide:
                    return Add(num1, num2); // I know these are wrong.
                case CalculatorOperation.Multiply:
                    return Add(num1, num2);
                case CalculatorOperation.Modulus:
                    return Add(num1, num2);
                default:
                    return 0;
            }
        }
    }
}
