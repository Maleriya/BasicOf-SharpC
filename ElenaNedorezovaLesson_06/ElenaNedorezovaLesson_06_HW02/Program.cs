using System;
using System.IO;
using System.Linq;

namespace ElenaNedorezovaLesson_06_HW02
{
    /*
     Задача:
     2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
        а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
        б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
        в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она
            возвращает минимум через параметр.

     Студент: Недорезова Елена
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите функцию 1 - a*x^2, 2 - a*sin(x). Через пробел введите отрезок (тоже через пробел))))");
            Console.WriteLine("Например: 1 -100 100");
            int[] userStr = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int choose = userStr[0];
            double d = 0;
            DelF del = null;
            switch (choose)
            {
                case 1:
                    del = F1; 
                    break;
                case 2:
                    del = F2;
                    break;
                default:
                    Console.WriteLine("Такого выбора не было. Всего доброго.");
                    return;
            }

            string nameFile = "data.bin";
            SaveFunc(nameFile, userStr[1], userStr[2], 0.5, del);
            Load(nameFile, out d);
            Console.WriteLine(d);


            Console.ReadKey();

        }

        public delegate double DelF(double x);

        public static double F1(double x)
        {
            return x * x;
        }
        public static double F2(double x)
        {
            return Math.Sin(x);
        }

        public static void SaveFunc(string fileName, double a, double b, double h, DelF func)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(a * func(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double[] array = new double[fs.Length];
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                array[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();

            return array;
        }
    }
}
