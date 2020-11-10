using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson05_HW_04
{
    /*
    Задание:
    4. Задача ЕГЭ.
    На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. 
    В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, 
    каждая из следующих N строк имеет следующий формат:
    <Фамилия> <Имя> <оценки>,
    где <Фамилия> — строка, состоящая не более чем из 20 символов, 
    <Имя> — строка, состоящая не более чем из 15 символов, 
    <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. 
    <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.
    Пример входной строки:
    Иванов Петр 4 5 3
    Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
    Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.

    Студент: Недорезова Елена
     */
    class Program
    {
        static void Main(string[] args)
        {
            SchoolChild[] schoolChildrens;

            string path = @"ExHW04.txt";

            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                schoolChildrens = new SchoolChild[Convert.ToInt32(sr.ReadLine().Trim())];
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lineSplit = line.Split(' ').ToArray();
                    schoolChildrens[i] = new SchoolChild(
                        lineSplit[0], 
                        lineSplit[1], 
                        Convert.ToInt32(lineSplit[2]), 
                        Convert.ToInt32(lineSplit[3]), 
                        Convert.ToInt32(lineSplit[4]));
                    i++;
                }
            }

            var averageBall = schoolChildrens.GroupBy(x => x.Avrage).OrderBy(x => x.Key).ToList();
            int count = averageBall.Count();
            int averageMax = count >= 3 ? averageBall[2].Key : count >= 2 ? averageBall[1].Key : averageBall[0].Key;

            foreach (var item in schoolChildrens)
            {
                if (item.Avrage <= averageMax)
                    Console.WriteLine($"{item.Name} {item.SurName} {item.Avrage}");
            }
            

            Console.ReadKey();
        }

        
    }

    public class SchoolChild
    {
        public SchoolChild(string name, string surName, int ball_1, int ball_2, int ball_3)
        {
            Name = name;
            SurName = surName;
            Ball_1 = ball_1;
            Ball_2 = ball_2;
            Ball_3 = ball_3;
            Avrage = (ball_1 + ball_2 + ball_3) / 3;
        }

        public string Name { get; private set; }
        public string SurName { get; private set; }
        public int Ball_1 { get; private set; }
        public int Ball_2 { get; private set; }
        public int Ball_3 { get; private set; }
        public int Avrage { get; private set; }

    }
}
