using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Создал массив и инициализировал
            Console.Write("Введите размер массива - ");
            string text = Console.ReadLine();
            int size = Int32.Parse(text);
            double[] mass = new double[size];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = i + 0.5;
                Console.Write("|" + mass[i]);
            }
            // поиск среднего знаения и суммы
            Console.WriteLine();
            double sum = 0;
            double midl = 0;
            for (int k = 0; k < mass.Length; k++)
            {
                sum = sum + mass[k];
                midl = sum / size;
            }
            // поиск значения < midl 
            for (int k = 0; k < mass.Length; k++)
            {
                if (mass[k] < midl)
                {
                    mass[k] = 0;

                }

                Console.Write("|" + mass[k]);
            }
            Console.WriteLine();
            Console.WriteLine("Сумма элементов = " + sum);
            Console.WriteLine("Среднее значение = " + midl);
        }
    }
}