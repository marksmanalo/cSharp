using System;

// n! = n*(n-1)*(n-2)*...(1)
namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Factorial(5));
            Console.ReadLine();
        }

        private static int Factorial(int n)
        {
            var result = 1;
            if (n == 0) return result;
            else
            {
                for (var i = 2; i <= n; i++) 
                {
                    result = result * i;   
                }    
            }

            return result;
        }
    }
}
