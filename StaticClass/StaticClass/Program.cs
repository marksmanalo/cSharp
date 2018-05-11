using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = Calculator.Add(1, 5);
            var result2 = Calculator.Multiply(4, 7);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }

    static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
