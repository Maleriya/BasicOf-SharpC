using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson02_HW03
{
    /*
    Задание:
    С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    
    Студент: Недорезова Елена
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа. 0 - стоп");

            int ch = 1;
            int positivOddSumm = 0;

            while(ch != 0)
            {
                ch = Convert.ToInt32(Console.ReadLine());
                if (ch > 0 && ch % 2 == 0)
                    positivOddSumm += ch;
            }

            Console.WriteLine($"Сумма всех нечетных положительных чисел {positivOddSumm}");
            Console.ReadKey();
        }
    }
}
