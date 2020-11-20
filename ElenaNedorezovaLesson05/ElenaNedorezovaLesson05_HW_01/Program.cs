using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson05_HW_01
{
    /*
    Задание:
    1. Создать программу, которая будет проверять корректность ввода логина. 
    Корректным логином будет строка от 2 до 10 символов, 
    содержащая только буквы латинского алфавита или цифры, 
    при этом цифра не может быть первой:
    
    а) без использования регулярных выражений;
    б) с использованием регулярных выражений.

    Студент: Недорезова Елена
     */
    class Program
    {
        static void Main(string[] args)
        {
            string[] logins = new string[7];
            logins[0] = "Elena";
            logins[1] = "E";
            logins[2] = "ElenaElenaE";
            logins[3] = "1Elena";
            logins[4] = "El1ena";
            logins[5] = "Ele/na";
            logins[6] = "Elen$a";

            foreach (var item in logins)
            {
                Console.WriteLine($"{item} {IsCorrectLogin(item)}");
            }

            Console.WriteLine();
            foreach (var item in logins)
            {
                Console.WriteLine($"{item} {IsCorrectLoginRegex(item)}");
            }

            Console.ReadLine();
        }

        private static bool IsCorrectLogin(string login)
        {
            int length = login.Length;
            if (length < 2 || length > 10)
                return false;

            if (char.IsNumber(login[0]))
                return false;

            foreach (char item in login)
            {
                if (!char.IsLetterOrDigit(item))
                    return false;
            }

            return true;
        }

        private static bool IsCorrectLoginRegex(string login)
        {
            Regex regex = new Regex(@"^([a-z]|[A-Z])([a-z]|[A-Z]|[0-9]){1,9}$");
            return regex.IsMatch(login);
        }
    }
}
