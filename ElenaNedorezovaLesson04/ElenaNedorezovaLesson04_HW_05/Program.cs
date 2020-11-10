using System;
using LibraryMyDoubleArray;

namespace ElenaNedorezovaLesson04_HW_05
{
    /*
    Задание:
    а) Реализовать библиотеку с классом для работы с двумерным массивом. 
    Реализовать конструктор, заполняющий массив случайными числами. 
    Создать методы, которые возвращают сумму всех элементов массива, 
    сумму всех элементов массива больше заданного, 
    свойство, возвращающее минимальный элемент массива, 
    свойство, возвращающее максимальный элемент массива, 
    метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).

    *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    *в) Обработать возможные исключительные ситуации при работе с файлами.


    Студент: Недорезова Елена
     */

    class Program
    {
        static void Main(string[] args)
        {
            MyDoubleArray doubleArray = new MyDoubleArray(3, 5, 1, 10);
            Console.WriteLine("Заполняем массив случайными числами");
            doubleArray.PrintArrayToConsole();

            Console.WriteLine("Mетод, возвращающий сумму всех элементов массива");
            Console.WriteLine(doubleArray.Sum());

            Console.WriteLine("Mетод, возвращающий сумму всех элементов массива больше заданного");
            Console.WriteLine(doubleArray.Sum(5));

            Console.WriteLine("Mетод, возвращающий минимальный элемент массива");
            Console.WriteLine(doubleArray.Min);

            Console.WriteLine("Mетод, возвращающий максимальный элемент массива");
            Console.WriteLine(doubleArray.Max);

            Console.WriteLine("Mетод, возвращающий номер максимального элемента массива");
            doubleArray.MaxNum(out int i, out int j);
            Console.WriteLine(i + " " + j);

            doubleArray = new MyDoubleArray("new 5.txt");
            Console.WriteLine("Заполняем массив из файла");
            doubleArray.PrintArrayToConsole();

            Console.WriteLine("Печатаем массив в файла");
            doubleArray.PrintArrayToFile("new 6.txt");

            Console.ReadKey();
        }
    }
}
