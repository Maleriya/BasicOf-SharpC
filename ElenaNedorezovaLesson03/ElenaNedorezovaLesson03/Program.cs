using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson03
{
    /*
    Задача:
    а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
    б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;

    Студент: Недорзова Елена
    */

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(4, 4);
            Complex complex2 = new Complex(2, 1);
            complex2.Im = 3;
            Complex resultPlus = complex1.Plus(complex2);
            Console.WriteLine(resultPlus.ToString());
            Complex resultSub = complex1.Sub(complex2);
            Console.WriteLine(resultSub.ToString());
            Complex resultMul = complex1.Mul(complex2);
            Console.WriteLine(resultMul.ToString());

            Console.ReadKey();
        }
    }

}
