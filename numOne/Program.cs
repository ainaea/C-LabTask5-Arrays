using System;

namespace numOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sample1 = {2,3,4,5};
            int[] sample2 = {4,5};
            int[] sample3 = {3,4,5};
            int[] sample4 = {5};

            Console.WriteLine($"The product of sample1 is {Product(sample1)}");
            Console.WriteLine($"The product of sample2 is {Product(sample2)}");
            Console.WriteLine($"The product of sample3 is {Product(sample3)}");
            Console.WriteLine($"The product of sample4 is {Product(sample4)}");

        }

        static int Product(int[] arr)
        {
            int result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                result *= arr[i];
            }
            return result;
        }
    }
}
