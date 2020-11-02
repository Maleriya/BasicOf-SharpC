using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson01_HW_01
{
    class Program
    {
        /*
        Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
        В результате вся информация выводится в одну строчку:
            а) используя  склеивание;
	        б) используя форматированный вывод;
	        в) используя вывод со знаком $.

        Студент: Елена Недорезова
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию:");
            string surName = Console.ReadLine();

            Console.WriteLine("Введите возраст:");
            string age = Console.ReadLine();

            Console.WriteLine("Введите рост:");
            double high = double.Parse(Console.ReadLine().Replace('.','.'));

            Console.WriteLine("Введите вес:");
            double weight = double.Parse(Console.ReadLine().Replace('.', '.'));

            Console.WriteLine(name + " " + surName + " " + age + " " + high + " " + weight);
            Console.WriteLine(string.Join(" ", name, surName, age, high, weight));
            Console.WriteLine("{0} {1} {2} {3:F1} {4:F1}", name, surName, age, high, weight);
            Console.WriteLine($"{name} {surName} {age} {high} {weight}");

            Console.ReadKey();
        }
    }
}
