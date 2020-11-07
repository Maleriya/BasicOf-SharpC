using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson03_HW02
{
    /*
    Задача:
    а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
    Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
    б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
    При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;

    Судент: Недорезова Елена
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа. 0 - стоп");

            int ch = 1;
            int positivOddSumm = 0;

            while (ch != 0)
            {
                if (int.TryParse(Console.ReadLine(), out int D))
                {
                    ch = D;
                    if (ch > 0 && ch % 2 != 0)
                        positivOddSumm += ch;
                }
                else
                {
                    Console.WriteLine($"Вы ввели некорректные данные. Больше так не делайте, пожалуйста.");
                }
            }

            Console.WriteLine($"Сумма всех нечетных положительных чисел {positivOddSumm}");
            Console.ReadKey();
        }
    }
}
