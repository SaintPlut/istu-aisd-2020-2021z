using System;

namespace Сортировка_слиянием
{
    class Program
    { 
        //метод для слияния массивов
        static void Merge(int[] mas, int low, int mid, int high)
        {
            var l = low;
            var r = mid + 1;
            var tempMas = new int[high - low + 1];
            var index = 0;
            while ((l <= mid) && (r <= high))
            {
                if (mas[l] < mas[r])
                {
                    tempMas[index] = mas[l];
                    l++;
                }
                else
                {
                    tempMas[index] = mas[r];
                    r++;
                }
                index++;
            }
            for (var i = l; i <= mid; i++)
            {
                tempMas[index] = mas[i];
                index++;
            }
            for (var i = r; i <= high; i++)
            {
                tempMas[index] = mas[i];
                index++;
            }
            for (var i = 0; i < tempMas.Length; i++)
            {
                mas[low + i] = tempMas[i];
            }
        }
        //сортировка слиянием
        static int[] MergeSort(int[] mas, int low, int high)
        {
            if (low < high)
            {
                var mid = (low + high) / 2;
                MergeSort(mas, low, mid);
                MergeSort(mas, mid + 1, high);
                Merge(mas, low, mid, high);
            }
            return mas;
        }
        static int[] MergeSort(int[] mas)
        {
            return MergeSort(mas, 0, mas.Length - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка слиянием");
            Console.Write("Элементы массива: ");
            var s = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var mas = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                mas[i] = Convert.ToInt32(s[i]);
            }
            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", MergeSort(mas)));
            Console.ReadLine();
        }
    }
}
        




