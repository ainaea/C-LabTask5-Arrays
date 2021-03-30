using System;

namespace numTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            double[] sample1 = {2,3,4,5};
            double[] sample2 = {4,5};
            double[] sample3 = {3,4,5};
            double[] sample4 = {5};

            Console.WriteLine($"The Sum of sample1 is {Sum(sample1)}");
            Console.WriteLine($"The Sum of sample2 is {Sum(sample2)}");
            Console.WriteLine($"The Sum of sample3 is {Sum(sample3)}");
            Console.WriteLine($"The Sum of sample4 is {Sum(sample4)}");
        }

        static double Sum(double[] arr)
        {
            double result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }
    }
}
