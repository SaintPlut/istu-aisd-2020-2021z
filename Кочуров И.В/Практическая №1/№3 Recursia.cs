using System;

namespace Recursia
{
    class Program
    {
        static int Sum(int[] arr, int i = 0)
        {
            if (i >= arr.Length)
                return 0;

            return arr[i] + Sum(arr, i + 1);
        }
        static void Main(string[] args)
        {
            int k = 0;
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
                Console.Write(arr[i]);

            }
            int result = Sum(arr);
            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}

