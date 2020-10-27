using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson01_HW_04
{
    class Program
    {
        /*
        Задача:
        Написать программу обмена значениями двух переменных:
        а) с использованием третьей переменной;
	    б) *без использования третьей переменной.

        Студент: Елена Недорезова
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Программа занимается обменом значений между двумя переменными");
            Console.WriteLine();
            Console.WriteLine("Введите значение для первой переменной");
            var a = Console.ReadLine().Replace('.',',');

            Console.WriteLine("Введите значение для второй переменной");
            var b = Console.ReadLine().Replace('.', ',');
            Console.WriteLine();

            if (double.TryParse(a, out double A) && double.TryParse(b, out double B))
            {
                Console.WriteLine("Метод с третьей переменной");
                ReplaceWithGlass(A, B);

                Console.WriteLine();

                Console.WriteLine("Метод без третьей переменной");
                ReplaceWithoutGlass(A, B);
            }
            else
            {
                Console.WriteLine("Программа работает с числами. Всего доброго.");
                return;
            }

            Console.ReadKey();
        }

        private static void ReplaceWithGlass(double a, double b)
        {
            Console.WriteLine($"Было а={a} b={b}");
            double c = a;
            a = b;
            b = c;
            Console.WriteLine($"Стало a={a} b={b}");
        }

        private static void ReplaceWithoutGlass(double a, double b)
        {
            Console.WriteLine($"Было а={a} b={b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Стало a={a} b={b}");
        }

    }
}
