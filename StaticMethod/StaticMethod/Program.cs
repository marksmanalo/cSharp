using System;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var result1 = calculator.Add(1, 5);
            var result2 = Calculator.Multiply(7, 4);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
