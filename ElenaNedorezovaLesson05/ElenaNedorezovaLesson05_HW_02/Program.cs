using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson05_HW_02
{
    /*
    Задание:
    2. Разработать класс Message, содержащий следующие статические методы для обработки текста:
    а) Вывести только те слова сообщения, которые содержат не более n букв.
    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    в) Найти самое длинное слово сообщения.
    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    Продемонстрируйте работу программы на текстовом файле с вашей программой.

    Студент: Недорезова Елена
     */
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"ExempleHW_02.txt";
            List<string> stringList = new List<string>();
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    stringList.Add(line);
                }
            }

            // В файле 4 строки, чтобы проверить работу функций
            Console.WriteLine(stringList[0]);
            Console.WriteLine(Message.GetMessageWithoutSomeWord(stringList[0], 5));
            Console.WriteLine("\n");

            Console.WriteLine(stringList[1]);
            Console.WriteLine(Message.GetMessageWithoutSomeWord(stringList[1], 'н'));
            Console.WriteLine("\n");

            Console.WriteLine(stringList[2]);
            Console.WriteLine(Message.GetMostBigWordnMessage(stringList[2]));
            Console.WriteLine("\n");

            Console.WriteLine(stringList[3]);
            Console.WriteLine(Message.GetMessageByMostBigWordnMessage(stringList[3]));

            Console.ReadKey();
        }
    }

    public class Message
    {
        public static string GetMessageWithoutSomeWord(string message, int maxLetter)
        {
            string[] array = message.Split(' ').ToArray();
            string res = string.Empty;
            foreach (var item in array)
            {
                if (item.Length <= maxLetter)
                    res += item + " ";
            }

            return res.Trim();
        }

        public static string GetMessageWithoutSomeWord(string message, char letter)
        {
            string[] array = message.Split(' ').ToArray();
            string res = string.Empty;
            foreach (var item in array)
            {
                if (item[item.Length - 1] != letter)
                    res += item + " ";
            }

            return res.Trim();
        }

        public static string GetMostBigWordnMessage(string message)
        {
            string[] array = message.Split(' ').ToArray();
            string maxWord = string.Empty;
            foreach (var item in array)
            {
                if (item.Length > maxWord.Length)
                    maxWord = item;
            }

            return maxWord;
        }

        public static StringBuilder GetMessageByMostBigWordnMessage(string message)
        {
            string bigWord = GetMostBigWordnMessage(message);
            string[] array = message.Split(' ').ToArray();
            int count = array.Count(x => x == bigWord);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append($"{bigWord} ");
            }
            return stringBuilder;
        }

    }
}
