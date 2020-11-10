using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson05_HW_03
{
    /*
    Задание:
    3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
    а) с использованием методов C#;
    б) *разработав собственный алгоритм.
    Например:
    badc являются перестановкой abcd.

    Студент: Недорезова Елена
     */
    class Program
    {
        static void Main(string[] args)
        {
            string main = "badc";
            string checking = "abcd";
            Console.WriteLine(IsMixStringStandart(main, checking));
            Console.WriteLine(IsMixString(main, checking));

            main = "badc";
            checking = "badc";
            Console.WriteLine(IsMixStringStandart(main, checking));
            Console.WriteLine(IsMixString(main, checking));

            Console.ReadKey();
        }

        private static bool IsMixString(string main, string checking)
        {
            main = main.ToUpper();
            checking = checking.ToUpper();

            if (main.Length != checking.Length)
                return false;

            int sovpadenie100 = 0;
            for (int i = 0; i < main.Length; i++)
            {
                if (!checking.Contains(main[i]))
                    return false;

                if (checking[0].Equals(main[i]))
                    sovpadenie100++;

                checking = checking.Remove(checking.IndexOf(main[i]), 1);
            }
            if (sovpadenie100 == main.Length)
                return false;

            return true;
        }

        private static bool IsMixStringStandart(string main, string checking)
        {
            if (main.Length != checking.Length)
                return false;

            if (string.Equals(main,checking))
                return false;

            return main.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(checking.Select(Char.ToUpper).OrderBy(x => x));
        }
    }
}
