using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson01_HW_03
{
    class Program
    {
        /*
        Задача:
        а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
        по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
        Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
        б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

        Студент: Елена Недорезова
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчитывает расстояние между двумя точками.");
            Console.WriteLine("Введите x1 y1 x2 y2 через пробел");
            string[] coordinates = Console.ReadLine().TrimEnd().Replace('.',',').Split(' ').ToArray();

            if (!CheckCount(coordinates))
                return;

            if (!CheckIsNumerals(coordinates))
                return;

            double x1 = double.Parse(coordinates[0]);
            double y1 = double.Parse(coordinates[1]);
            double x2 = double.Parse(coordinates[2]);
            double y2 = double.Parse(coordinates[3]);

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точками = {0:F2}", r);
            Console.WriteLine("Расстояние между точками по методу = {0:F2}", GetDistance(x1, y1, x2, y2));

            Console.ReadKey();
        }

        /// <summary>
        /// Проверяет, что введено 4 координаты
        /// </summary>
        private static bool CheckCount(string[] numers)
        {
            if (numers.Length != 4)
            {
                Console.WriteLine("Вы ввели неверное количество координат. Всего доброго.");
                Console.ReadKey();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Проверяет, что введеные знаки можно преобразовать в числа
        /// </summary>
        private static bool CheckIsNumerals(string[] numerals)
        {
            foreach (string numer in numerals)
            {
                if (!double.TryParse(numer, out double D))
                {
                    Console.WriteLine("Вы ввели что-то кроме цифр. Всего доброго.");
                    Console.ReadKey();
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Возвращает расстояние между двумя точками заданными координатами
        /// </summary>
        private static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
