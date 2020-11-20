using System;
using System.IO;
using System.Text;

namespace ElenaNedorezovaLesson04_HW_02
{
    /*
    Задание:
    Реализуйте задачу 1 в виде статического класса StaticClass;
    а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
    в)**Добавьте обработку ситуации отсутствия файла на диске.

    Студент: Недорезова Елена
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = StaticClass.GetArrayRandom();
            int couple = StaticClass.CountCoupleDiv3(array);

            Console.WriteLine($"В рандомном массиве {couple} {StaticClass.GetRightWordCouple(couple)} элементов, " +
                $"в которых только одно число делится на 3");

            Console.WriteLine();
            int[] arrayFromFile = StaticClass.GetArrayFromFile("new 3.txt");
            if (arrayFromFile != null)
            {
                couple = StaticClass.CountCoupleDiv3(arrayFromFile);

                Console.WriteLine($"В массиве из файла {couple} {StaticClass.GetRightWordCouple(couple)} элементов, " +
                    $"в которых только одно число делится на 3");
            }
            Console.ReadKey();
        }

        
    }

    static class StaticClass
    {
        public static int[] GetArrayRandom()
        {
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10000);
            }
            return array;
        }

        public static string GetRightWordCouple(int count)
        {
            if (count > 0 && count < 5)
                return "пары";

            return "пар";
        }

        public static int[] GetArrayFromFile(string path)
        {
            if(!File.Exists(path))
            {
                Console.WriteLine($"Файл нe найден {path}");
                return null;
            }

            try
            {
                int lenght = File.ReadAllLines(path).Length;
                int[] array = new int[lenght];

                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    string line;
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        array[i] = Convert.ToInt32(line.Trim());
                        i++;
                    }
                }

                return array;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка чтения файла: " + e.Message);
                return null;
            }        
        }

        public static int CountCoupleDiv3(int[] array)
        {
            int couple = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] % 3 == 0) != (array[i + 1] % 3 == 0))
                    couple++;
            }

            return couple;
        }
    }
}
