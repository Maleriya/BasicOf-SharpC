using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson02_HW04
{
    /*
    Задание:
    Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
    На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
    Используя метод проверки логина и пароля, написать программу: 
    пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
    С помощью цикла do while ограничить ввод пароля тремя попытками.

    Студент: Недорезова Елена
    */
    class Program
    {
        static void Main(string[] args)
        {
            string login, pass;
            
            int countTry = 3;

            while (countTry != 0)
            {
                Console.WriteLine("Введите логин:");
                login = Console.ReadLine();

                Console.WriteLine("Введите пароль:");
                pass = Console.ReadLine();

                if (IsSuccess(login, pass))
                {
                    Console.WriteLine($"Добро пожаловать, {login}!");
                    break;
                }
                else
                {
                    countTry--;
                    if (countTry != 0)
                    {
                        string endingWord = (countTry != 1) ? "ок" : "ка";
                        Console.WriteLine($"Вы ввели неверные параметры. " +
                            $"Осталось {countTry} попыт{endingWord}");
                    }
                    else
                        Console.WriteLine("Количеcтво попыток войти исчерпано");
                }
            }

            Console.ReadKey();
        }

        private static bool IsSuccess(string login, string pass)
        {
            if (login != "root" && pass != "GeekBrains")
                return false;

            return true;
        }
    }
}
