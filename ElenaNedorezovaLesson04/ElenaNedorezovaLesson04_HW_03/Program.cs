using System;
using System.Collections.Generic;

namespace ElenaNedorezovaLesson04_HW_03
{
    /*
    Задание:
    а) Дописать класс для работы с одномерным массивом. 
    -Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
    -Создать свойство Sum, которое возвращает сумму элементов массива, 
    -метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  
    -метод Multi, умножающий каждый элемент массива на определённое число, 
    -свойство MaxCount, возвращающее количество максимальных элементов. 

    б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
    е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)


    Студент: Недорезова Елена
     */
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray(10, 1, 2);
            Console.WriteLine("Заполняем массив числами от начального значения с заданным шагом");
            Console.WriteLine(string.Join(" ", myArray));
            myArray = new MyArray(10);
            Console.WriteLine("Чтобы лучше проверить функции создадим рандомный массив");
            Console.WriteLine(string.Join(" ", myArray));
            Console.WriteLine("Свойство Sum, возвращает сумму элементов массива");
            Console.WriteLine(myArray.Sum);
            Console.WriteLine("Метод Inverse, возвращает новый массив с измененными знаками у всех элементов массива \n" +
                "(старый массив, остается без изменений)");
            Console.WriteLine("Новый массив");
            Console.WriteLine(string.Join(" ", myArray.Inverse()));
            Console.WriteLine("Старый массив");
            Console.WriteLine(string.Join(" ", myArray));
            Console.WriteLine("Метод Multi, умножает каждый элемент массива на определённое число");
            myArray.Multi(3);
            Console.WriteLine(string.Join(" ", myArray));
            Console.WriteLine("Свойство MaxCount, возвращает количество максимальных элементов");
            Console.WriteLine(myArray.MaxCount);
            Console.WriteLine("Подсчитаем частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)");
            Dictionary<int, int> keyValues = myArray.GetDictionary();
            Console.WriteLine(string.Join("", keyValues));
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Теперь обратимся к библиотеке");

            LibraryMyArray.MyArray myLibArray = new LibraryMyArray.MyArray(10, 1, 2);
            Console.WriteLine("Заполняем массив числами от начального значения с заданным шагом");
            Console.WriteLine(string.Join(" ", myLibArray));
            myLibArray = new LibraryMyArray.MyArray(10);
            Console.WriteLine("Чтобы лучше проверить функции создадим рандомный массив");
            Console.WriteLine(string.Join(" ", myLibArray));
            Console.WriteLine("Свойство Sum, возвращает сумму элементов массива");
            Console.WriteLine(myLibArray.Sum);
            Console.WriteLine("Метод Inverse, возвращает новый массив с измененными знаками у всех элементов массива \n" +
                "(старый массив, остается без изменений)");
            Console.WriteLine("Новый массив");
            Console.WriteLine(string.Join(" ", myLibArray.Inverse()));
            Console.WriteLine("Старый массив");
            Console.WriteLine(string.Join(" ", myLibArray));
            Console.WriteLine("Метод Multi, умножает каждый элемент массива на определённое число");
            myLibArray.Multi(3);
            Console.WriteLine(string.Join(" ", myLibArray));
            Console.WriteLine("Свойство MaxCount, возвращает количество максимальных элементов");
            Console.WriteLine(myLibArray.MaxCount);
            Console.WriteLine("Подсчитаем частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)");
            Dictionary<int, int> keyValuesLib = myLibArray.GetDictionary();
            Console.WriteLine(string.Join("", keyValuesLib));
            Console.ReadLine();
        }
    }

    class MyArray
    {
        int[] array;
        Random rnd = new Random();

        public MyArray(int n)
        {
            array = new int[n];
            for (int i = 0; i < n; i++)
                array[i] = rnd.Next(1, 10);
        }

        public MyArray(int length, int start, int step)
        {
            array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = start;
                start += step;
            }
        }

        public int Max
        {
            get
            {
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (array[i] > max) max = array[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (array[i] < min) min = array[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                    if (array[i] > 0) count++;
                return count;
            }
        }

        public int[] Inverse()
        {
            int[] arrayInverse = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayInverse[i] = array[i] * (-1);
            }
            return arrayInverse;
        }

        public void Multi(int mul)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= mul; 
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                    sum += array[i];

                return sum;
            }
        }

        public int MaxCount
        {
            get
            {
                int count = 0;
                int max = Max;
                foreach (var item in array)
                {
                    if (item == max)
                        count++;
                }
                return count;
            }
        }

        public Dictionary<int, int> GetDictionary()
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (var item in array)
            {
                if (keyValuePairs.ContainsKey(item))
                    keyValuePairs[item]++;
                else
                {
                    keyValuePairs.Add(item, 1);
                }
            }
            return keyValuePairs;
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in array)
                s = s + v + " ";
            return s;
        }
    }

}
