using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson01_HW_05
{
    class Program
    {
        /*
        Задача:
        а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        б) *Сделать задание, только вывод организовать в центре экрана.
        в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).

        Студент: Елена Недорезова
        */
        static void Main(string[] args)
        {
            string name = "Елена";
            string surName = "Недорезова";
            string city = "Москва";

            PrintPersonalInfo(name, surName, city);
            PrintPersonalInfoCentreScreen(name, surName, city);

            Console.ReadKey();
        }

        private static void PrintPersonalInfo(string name, string surName, string city)
        {
            Console.WriteLine($"{name} {surName} {city}");
        }

        private static void PrintPersonalInfoCentreScreen(string name, string surName, string city)
        {
            int winHeightCentre = Console.WindowHeight / 2;
            int winWidthCentre = Console.WindowWidth / 2;
            string personalInfo = $"{name} {surName} {city}";
            Console.SetCursorPosition(winWidthCentre - (personalInfo.Length / 2), winHeightCentre);
            Console.WriteLine(personalInfo);
        }
    }
}
