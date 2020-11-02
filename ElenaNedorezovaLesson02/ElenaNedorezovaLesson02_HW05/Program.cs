using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson02_HW05
{
    /*
    Задача: 
    а) Написать программу, которая запрашивает массу и рост человека, 
    вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

    Студент: Недорезова Елена
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес (в кг):");
            double weight = double.Parse(Console.ReadLine().Replace('.', ','));
            Console.WriteLine("Введите рост (в см):");
            double hight = double.Parse(Console.ReadLine()) / 100;
            double IMT = weight / (hight * hight);
            Console.WriteLine("ИМТ = {0}/({1}*{2}) = {3:F0}", weight, hight, hight, IMT);

            Console.Write("Если верить Вики, то ВОЗ говорит, что у Вас ");

            var customSwitch = new Dictionary<Func<double, bool>, Action>
            {
            { x => x < 16 , () => Console.WriteLine("выраженный дефицит массы тела.")},
            { x => x < 18.5, () => Console.WriteLine("недостаточная(дефицит) масса тела.")},
            { x => x < 25, () => Console.WriteLine("норма.")},
            { x => x < 30, () => Console.WriteLine("избыточная масса тела(предожирение).")},
            { x => x < 35, () => Console.WriteLine("ожирение.")},
            { x => x < 40, () => Console.WriteLine("ожирение резкое.")},
            { x => x >= 40, () => Console.WriteLine("очень резкое ожирение.")}
            };

            customSwitch.First(sw => sw.Key(IMT)).Value();

            if (IMT < 18.5)
                HowManyKgToLoseOrAdd(IMT, weight, hight, false);
            else if (IMT > 25)
                HowManyKgToLoseOrAdd(IMT, weight, hight, true);

            Console.ReadKey();
        }

        private static void HowManyKgToLoseOrAdd(double nowIMT, double nowKg, double hight, bool isLose)
        {
            double maxNorma = 24;
            double minNorma = 19;
            double normKg = (isLose ? maxNorma : minNorma) * (hight * hight);
            if (isLose)
                Console.WriteLine("Нужно сбросить {0:F1} кг", nowKg - normKg);
            else
                Console.WriteLine("Нужно набрать {0:F1} кг", normKg - nowKg);
        }
    }
}
