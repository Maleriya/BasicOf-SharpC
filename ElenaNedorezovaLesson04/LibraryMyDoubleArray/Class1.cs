using System;
using System.IO;
using System.Text;

namespace LibraryMyDoubleArray
{
    /*
    Задание:
    а) Реализовать библиотеку с классом для работы с двумерным массивом. 
    -Реализовать конструктор, заполняющий массив случайными числами. 
    -Создать методы, которые возвращают сумму всех элементов массива, 
    -сумму всех элементов массива больше заданного, 
    -свойство, возвращающее минимальный элемент массива, 
    -свойство, возвращающее максимальный элемент массива, 
    -метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).

    *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    *в) Обработать возможные исключительные ситуации при работе с файлами.

    Студент: Недорезова Елена
     */

    public class MyDoubleArray
    {
        private int[,] array;
        Random rnd = new Random();

        public MyDoubleArray(int r1, int r2, int min, int max)
        {
            array = new int[r1, r2];
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < r2; j++)
                {
                    array[i, j] = rnd.Next(min, max);
                }
            }
        }

        public MyDoubleArray(string path)
        {
            array = GetArrayFromFile(path);
        }

        private int[,] GetArrayFromFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"Файл нe найден {path}");
                return null;
            }

            try
            {
                int length1 = File.ReadAllLines(path).Length;
                int length2 = new StreamReader(path, Encoding.Default).ReadLine().Split(' ').Length;
                int[,] doubleArray = new int[length1, length2];

                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    string line;
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] str = line.Split(' ');
                        for (int j = 0; j < length2; j++)
                        {
                            doubleArray[i, j] = Convert.ToInt32(str[j].Trim());
                        }
                        i++;
                    }
                }

                return doubleArray;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка чтения файла: " + e.Message);
                return null;
            }
        }

        public void PrintArrayToFile(string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
                {
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        string str = "";
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            str += array[i, j] + " ";
                        }
                        sw.WriteLine(str.Trim());
                    }

                    Console.WriteLine("Файл записан!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка записи файла: " + e.Message);
            }
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }

            return sum;
        }

        public int Sum(int min)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > min)
                        sum += array[i, j];
                }
            }

            return sum;
        }

        public int Min
        {
            get
            {
                int min = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < min)
                            min = array[i, j];
                    }
                }

                return min;
            }
        }

        public int Max
        {
            get
            {
                int max = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] > max)
                            max = array[i, j];
                    }
                }

                return max;
            }
        }

        public void MaxNum(out int maxI, out int maxJ)
        {
            int max = array[0, 0];
            maxI = 0;
            maxJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < max)
                    {
                        max = array[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }
        }

        public void PrintArrayToConsole()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                string str = "";
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    str += array[i, j] + " ";
                }
                Console.WriteLine(str);
            }
        }
    }
}
