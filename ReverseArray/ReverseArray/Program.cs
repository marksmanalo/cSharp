using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var array = new int[] { 5, 4,3, 2, 1};
            Console.WriteLine("Original: ");
            foreach (var number in array){
                Console.WriteLine(number);
            }
            var reversedArray = ReverseArray(array);
            Console.WriteLine("Reversed: ");
            foreach (var number in reversedArray)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }

        private static int[] ReverseArray(int[] array)
        {
            var lastIndex = array.Length - 1;
            var firstIndex = 0;
            for (var i = 0; i < array.Length / 2; i++)
            {
                var holder = array[lastIndex];
                array[lastIndex] = array[firstIndex];
                array[firstIndex] = holder;
                lastIndex -= 1;
                firstIndex += 1;
            }

            return array;
        }
    }
}
