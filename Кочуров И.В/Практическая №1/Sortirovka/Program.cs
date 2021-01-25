using System;


namespace Sortirovka
{
	class Programs
	{

		public static void Main()
		{


            int[] mas = new int[] { 2,4,7,8,4,0,5,2,1,3,6,5,9 };
            for (int i = 0; i <= 9; i++)
            {
                int count = 0;
                for (int j = 0; j < mas.Length; j++)
                {
                    if (i == mas[j]) count++;
                }
                Console.WriteLine($"{i} - {count} повторения");
            }


            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        int buf = mas[i];
                        mas[i] = mas[j];
                        mas[j] = buf;
                    }
                }
                Console.Write($"{mas[i]} ");
            }
        }
    }
}