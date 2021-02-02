using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrStack
{
    class Program
    {
        static void Push(Stack<int> stack, int numbers, int Count)
        {
            stack.Push(numbers);
        }
        static void Pop(Stack<int> stack)
        {
            if (stack.Count == 0)
                throw new NullReferenceException("Пустой стек");
        }
        static Stack<int> CloneStack(Stack<int> stack)
        {
            Stack<int> cloneNumbers = new Stack<int>(stack);
            return cloneNumbers;
        }
        static void MemCleaner()
        {
            Console.WriteLine(GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(true));
        }

        static void PrintStack(Stack<int> stack)
        {
            foreach (int bit in stack)
            {
                Console.Write($"{bit}  ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            Console.WriteLine("Заполняем стек");
            numbers.Push(1);
            numbers.Push(4);
            numbers.Push(3);
            numbers.Push(2);
            numbers.Push(5);
            Console.WriteLine("Результат");
            PrintStack(numbers);
            Console.WriteLine("Удаляем верхний элемент");
            numbers.Pop();
            PrintStack(numbers);
            Console.WriteLine();
            Console.WriteLine("Копируем содержимое в массив");
            int[] Array = numbers.ToArray();
            foreach (int i in Array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Результат очищения памяти");
            MemCleaner();
        }
    }
}