using System;

namespace Task1
{
    public class BaseCalculator : ICalculator
    {
        public double ReadNumber()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}
