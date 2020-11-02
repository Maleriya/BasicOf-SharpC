using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson02_HW07
{
    /*
    Задача:
    a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

    Студент: Елена Недорезова
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Рекурсионно выводим цифры от {a} до {b}");
            WriteNumeralRecursion(a, b);

            Console.Write($"Рекурсионно считаем сумма цифры от {a} до {b} =");
            SummRecursion(a, b);

            Console.ReadKey();
        }

        private static void WriteNumeralRecursion(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
                if (a != b)
                {
                    a++;
                    WriteNumeralRecursion(a, b);
                }
            }
        }

        private static void SummRecursion(int a, int b, int summ = 0)
        {
            if (a <= b)
            {
                summ += a;
                if (a != b)
                {
                    a++;
                    SummRecursion(a, b, summ);
                }
                else
                {
                    Console.Write($" {summ}");
                }
            }
        }

    }
}
