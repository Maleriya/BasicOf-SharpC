using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson01_HW_02
{
    class Program
    {
        /*
        Задача:
        Ввести вес и рост человека. 
        Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
        где m — масса тела в килограммах, h — рост в метрах.

        Студент: Елена Недорезова
        */
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
            { x => x < 16 , () => Console.Write("выраженный дефицит массы тела.")},
            { x => x < 18.5, () => Console.Write("недостаточная(дефицит) масса тела.")},
            { x => x < 25, () => Console.Write("норма.")},
            { x => x < 30, () => Console.Write("избыточная масса тела(предожирение).")},
            { x => x < 35, () => Console.Write("ожирение.")},
            { x => x < 40, () => Console.Write("ожирение резкое.")},
            { x => x >= 40, () => Console.Write("очень резкое ожирение.")}
            };

            customSwitch.First(sw => sw.Key(IMT)).Value();
            
            Console.ReadKey();
        }
    }
}
