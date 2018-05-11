using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Add;
            Console.WriteLine(myDelegate(5, 6));

            myDelegate = Multiply;
            Console.WriteLine(myDelegate(7, 9));
        }

        // This delegate can take any function that
        // returns an int and has two int inputs
        public delegate int MyDelegate(int a, int b);

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
