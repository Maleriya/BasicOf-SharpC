using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson02
{
    /*
     Задание:
    Написать метод, возвращающий минимальное из трёх чисел.
    
    Студент: Недорезова Елена    
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int max = GetMax(a, b, c);
            Console.WriteLine($"максимальное число {max}");
            Console.ReadKey();
        }

        private static int GetMax(int a, int b, int c)
        {
            int max = a;
            max = (max < b) ? b : max;
            max = (max < c) ? c : max;
            return max;
        }
    }
}
