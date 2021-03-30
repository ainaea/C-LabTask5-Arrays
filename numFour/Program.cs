using System;

namespace numFour
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int[,] sample1 = {{1,2,3},{4,5,6}};
            int[,] sample2 = {{1,8,2},{7,0,6}};

            PrintArr(sample1);
            PrintArr(sample2);
            PrintArr(MultiplyArray(sample1,sample2));
        }

        static int[,] MultiplyArray(int[,] arr1, int[,] arr2 )
        {
            //This executes literal (not mathematical) multiplication of array
            if (arr1.GetLength(0) == arr2.GetLength(0) && arr1.GetLength(1) == arr2.GetLength(1))
            {
                int[,] result = new int[arr1.GetLength(0), arr1.GetLength(1)];
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        result[i,j] = arr1[i,j] * arr2[i,j];
                    }                
                }
                return result;
            }
            // int[,] StockItems = new int[3,3];
            return new int[1,1];
        }

        static void PrintArr(int[,] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j],4} ");
                }
                Console.WriteLine();
            }
        }
    }

}
