using System;
using System.IO;

namespace ElenaNedorezovaLesson_06_HW01
{
    /*
     Задача:
     1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). 
     Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

     Студент: Недорезова Елена
     */
    class Program
    {
        static void Main(string[] args)
        {
            string nameFile = "data.bin";
            SaveFunc(nameFile, -100, 100, 0.5, F2);
            Console.WriteLine(Load(nameFile));

            nameFile = "data2.bin";
            SaveFunc(nameFile, -100, 100, 0.5, F3);
            Console.WriteLine(Load(nameFile));
            Console.ReadKey();

        }

        public delegate double DelF(double x);

        public static double F2(double x)
        {
            return x * x;
        }
        public static double F3(double x)
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
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
    }

}
