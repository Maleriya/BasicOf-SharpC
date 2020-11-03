using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson02_HW06
{
    /*
    Задание: 
    *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
    *«Хорошим» называется число, которое делится на сумму своих цифр. 
    *Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

    Студент: Елена Недорезова
     */
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            int countGood = 0;
            int from = 1;
            int to = 1000000000;

            for (int i = from; i < to; i++)
            {
                if (isGood(i))
                    countGood++;
            }

            DateTime endTime = DateTime.Now;
            Console.WriteLine($"В диапазоне от {from} до {to} Хороших чисел {countGood}");
            Console.WriteLine($"Время работы программы {endTime.Subtract(startTime).Seconds} секунд");
            Console.ReadKey();
        }

        private static bool isGood(int a)
        {
            int length = GetLength(a);
            if (a % length == 0)
                return true;

            return false;
        }

        private static int GetLength(int a)
        {
            int counter = 0;
            while (a != 0)
            {
                a = a / 10;
                counter++;
            }

            return counter;
        }
    }
}
