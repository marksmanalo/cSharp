using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenNumber = 6;
            int oddNumber = 7;

            Console.WriteLine(evenNumber.IsEven());
            Console.WriteLine(oddNumber.IsEven());
        }
    }

    public static class MyExtensionMethods
    {
        public static bool IsEven(this int input)
        {
            return input % 2 == 0;
        }
    }
}
