using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,r;
            Console.Write("Введите первое число - ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число - ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите арифметическую функцию - ");
            string znak = Console.ReadLine();
            if (znak == "+")
            {
                r = a + b;
                Console.WriteLine("Сумма равна = "+ r);
            }
            else if (znak == "-")
            {
                r = a - b;
                Console.WriteLine("Разность равна = "+ r);
            }
            else if (znak == "*")
            {
                r = a * b;
                Console.WriteLine("Произведение равно = "+ r);
            }
            else if (znak == "/")
            {
                r = a / b;
                Console.WriteLine("Частное равно = " + r);
            }
            else
                Console.WriteLine("Error");


        }
    }
}
