using System;
using System.Collections.Generic;
namespace List
{
    class Program
    {
        List<int> number = new List<int>();
        //добавление 
        void AddElem(int num)
        {
            number.Add(num);
        } 
        //вставка элемента на позицию перед указанным индексом
        void AddUpElem(int index, int num)
        {
            index--;
            number.Insert(index, num);
        }
        //удаление 
        void DeletElem(int num)
        {
            int indexNum = number.IndexOf(num);
            if (indexNum < 0) Console.WriteLine("Ошибка");
            else number.RemoveAt(indexNum);
        }
        //Список всех элементов
        void AllElem()
        {
            foreach (int elem in number)
            {
                Console.Write($"{elem}, ");
            }
            Console.WriteLine("");
        }
        //поиск значения элемента по индексу
        int SearchId(int index)
        {
            Console.WriteLine(number[index]);
            return number[index];
        }
        void Comands(string comands)
        {
            switch (comands)
            {
                case "Add":
                    Console.Write("Введите число которое нужно добавить: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    AddElem(num);
                    break;
                case "Delete":
                    Console.Write("Введите число которое нужно удалить: ");
                    int elem = Convert.ToInt32(Console.ReadLine());
                    DeletElem(elem);
                    break;
                case "InsertBefore":
                    Console.Write("Введите индекс перед которым нужно вставить число: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    AddUpElem(index, number);
                    break;
                case "Print":
                    AllElem();
                    break;
                case "Search":
                    Console.Write("Введите индекс получаемого элемента: ");
                    int indexElem = Convert.ToInt32(Console.ReadLine());
                    SearchId(indexElem);
                    break;
                case "ClearMemory":
                    Console.WriteLine(GC.GetTotalMemory(false));
                    GC.Collect(2, GCCollectionMode.Forced);
                    Console.WriteLine(GC.GetTotalMemory(true));
                    break;
                default:
                    Console.Write("Ошибка!");
                    Help();
                    break;
            }
        }
        void Help()
        {
            Console.WriteLine("Введите команду");
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            a.Help();
            string str;
            do
            {
                str = Console.ReadLine();
                a.Comands(str);
            } while (str != null);
        }
    }
}
