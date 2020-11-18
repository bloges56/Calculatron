using System;

namespace Calculatron
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Divide(int num1, int num2)
        {
            return (double) num1 / num2;
        }

        public int Square(int num)
        {
            return num * num;
        }

        public double Sqrt(int num)
        {
            return Math.Sqrt(num);
        }
    }
}