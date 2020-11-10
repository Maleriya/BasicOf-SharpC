using System;
using System.IO;
using System.Text;

namespace ElenaNedorezovaLesson04_HW_04
{
    /*
    Задание:
    Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
    Создайте структуру Account, содержащую Login и Password.

    Студент: Недорезова Елена
     */

    class Program
    {
        static void Main(string[] args)
        {
            // предположим, что в фале может быть нсколько строк с логинами и паролями
            // но правильный логин и пароль только один
            string path = "new 4.txt";
            if (!File.Exists(path))
            {
                Console.WriteLine($"Файл нe найден {path}");
                Console.ReadLine();
                return;
            }

            int length = File.ReadAllLines(path).Length;
            if (length == 0)
            {
                Console.WriteLine($"В файле нет строки");
                Console.ReadLine();
                return;
            }

            Account[] account = new Account[length];

            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    string line;
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] str = line.Split(' ');
                        account[i] = new Account(str[0], str[1]);
                        i++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка чтения файла: " + e.Message);
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Пара с {i+1} строки");
                if (account[i].Login == "root" && account[i].Password == "GeekBrains")
                    Console.WriteLine($"Добро пожаловать, {account[i].Login}!");
                else
                    Console.WriteLine($"Вы ввели неверные параметры.");
            }

            Console.ReadKey();
        }
    }

    public struct Account
    {
        public string Login;
        public string Password;

        public Account(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
