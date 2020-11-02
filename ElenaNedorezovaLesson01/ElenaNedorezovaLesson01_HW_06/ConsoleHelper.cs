using System;

namespace ElenaNedorezovaLesson01_HW_06
{
    /// <summary>
    /// Класс со вспомогательными методами для работы с консолью
    /// </summary>
    public static class ConsoleHelper
    {
        /// <summary>
        /// Печатает введенную строку там, где стоит курсор
        /// </summary>
        public static void Print(string info)
        {
            Console.WriteLine(info);
        }

        /// <summary>
        /// Печатаем введенную строку по центру консоли
        /// </summary>
        public static void PrintCentreScreenPosition(string info)
        {
            int winHeightCentre = Console.WindowHeight / 2;
            int winWidthCentre = Console.WindowWidth / 2;
            Console.SetCursorPosition(winWidthCentre - (info.Length / 2), winHeightCentre);
            Console.WriteLine(info);
        }

        /// <summary>
        /// Печатаем введенную строку в заданных координатах
        /// Не выходя за пределы окна консоли
        /// </summary>
        /// <param name="x">расстояние от левого края</param>
        /// <param name="y">расстояние от верха</param>
        public static void PrintCustomPosition(string info, int x, int y)
        {
            int positionHeight = y < 0 ? 0 : y > Console.WindowHeight ? Console.WindowHeight : y;
            int positionWidth = x < 0 ? 0 : x > Console.WindowWidth ? Console.WindowWidth : x;
            Console.SetCursorPosition(positionWidth, positionHeight);
            Console.WriteLine(info);
        }

        /// <summary>
        /// Ставим на ожидания до нажатия любой клавиши
        /// </summary>
        public static void Pause()
        {
            Console.WriteLine("Будем ждать, пока вы что-нибудь не нажмете.");
            Console.ReadKey();
        }
    }
}
