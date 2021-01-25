using System;

namespace Picture_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            text = Console.ReadLine();
            int n = Int32.Parse(text);
            int[] arr= new int[n];
            for(int i=0; i<arr.Length; i++)
            {
                if (i<n/2)
                {
                   int t = arr[i];
                    arr[i] = arr[n - i - 1];
                    arr[n - i - 1] = t;
                }
                i++;
                Console.Write(i+" ");
            }
        }
    }
}
