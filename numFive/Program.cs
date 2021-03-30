using System;

namespace numFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sample1 = {234, 544, 768, 286, 1234, 654, 432, 443, 213, 458, 887, 587};
            // Console.WriteLine("Hello World!");
            PrintDistribution(sample1);
        }

        static string ToPicto(int num)
        {
            string str = "";
            for (int i = 0; i < num; i++)
            {
                str += "*";
            }
            return str;
        }

        static void PrintDistribution(int[] arr)
        {
            int[] counts = new int[11];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>= 1000)
                {
                    ++counts[10];
                }
                else if(arr[i]< 200){}
                else{
                    ++counts[ arr[i] / 100 ];
                }
            }

            for (int i = 2; i < counts.Length-1; i++)
            {
                Console.WriteLine($"{i*100} - {i*100 + 99} :\t{ToPicto(counts[i])}");
            }
            Console.WriteLine($"{1000} & above :\t{ToPicto(counts[10])}");

        }
    }
}
