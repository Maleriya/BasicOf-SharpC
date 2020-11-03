using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson02_HW02
{
    /*
    Задание:
    Написать метод подсчета количества цифр числа.

    Студент: Недорезова Елена    
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целове число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"В данном числе {GetLenght(a)} цифр");
            Console.ReadKey();
        }

        private static int GetLenght(int a)
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
