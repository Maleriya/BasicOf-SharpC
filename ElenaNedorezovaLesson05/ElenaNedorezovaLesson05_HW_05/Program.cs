using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson05_HW_05
{
    /*
    Задание:
    5. **Написать игру «Верю. Не верю». 
    В файле хранятся вопрос и ответ, правда это или нет. 
    Например: «Шариковую ручку изобрели в древнем Египте», «Да». 
    Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку. 
    Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ. 

    Студент: Недорезова Елена
     */
    class Program
    {
        static void Main(string[] args)
        {
            YesOrNo mainGame = new YesOrNo("ExHW05.txt");
            mainGame.MixGameList();
            int sumBall = 0;
            for(int i=0; i<5; i++)
            {
                Console.WriteLine($"Вопрос {mainGame.yesOrNos[i].num}: {mainGame.yesOrNos[i].Q}");
                string answChar = "";
                while(answChar != "Y" && answChar != "N")
                {
                    Console.WriteLine("\nY/N");
                    answChar = Console.ReadKey().KeyChar.ToString().ToUpper();
                }

                bool answ = answChar == "Y" ? true : false;
                if (answ == mainGame.yesOrNos[i].A)
                {
                    Console.WriteLine("Правильно :)\n");
                    sumBall++;
                }
                else
                    Console.WriteLine("Вы ошиблись :(\n");
            }

            Console.WriteLine("Игра окончена. Сумма ваших баллов " + sumBall);
            Console.ReadKey();
        }
    }

    public class YesOrNo
    {
        public List<YesOrNo> yesOrNos { get; private set; }

        public YesOrNo(string path)
        {
            yesOrNos = GetYesOrNoList(path);
        }

        public YesOrNo()
        {

        }

        public string Q { get; private set; }
        public bool A { get; private set; }
        public int num { get; private set; }

        private static List<YesOrNo> GetYesOrNoList(string path)
        {
            List<YesOrNo> list = new List<YesOrNo>();

            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                int num=0;
                while ((line = sr.ReadLine()) != null)
                {
                    YesOrNo game = new YesOrNo();
                    game.Q = line;
                    game.A = sr.ReadLine() == "Да" ? true : false;
                    game.num = ++num;
                    list.Add(game);
                }
            }

            return list;
        }

        public void MixGameList()
        {
            Random random = new Random();
            List<YesOrNo> newGameList = new List<YesOrNo>();
            foreach (var itemGame in yesOrNos)
            {
                int j = random.Next(newGameList.Count + 1);
                if (j == newGameList.Count)
                {
                    newGameList.Add(itemGame);
                }
                else
                {
                    newGameList.Add(newGameList[j]);
                    newGameList[j] = itemGame;
                }
            }

            yesOrNos = newGameList;
        }

    }
}
