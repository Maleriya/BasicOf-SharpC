using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson01_HW_06
{
    /*
    Задача:
    Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
    
    Студент: Елена Недорезова
    */

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.Print("Просто печатаем.");
            ConsoleHelper.PrintCentreScreenPosition("Печатаем посередине окна.");
            ConsoleHelper.PrintCustomPosition("Печатаем, где посчитаем нужным.", 15, 23);
            ConsoleHelper.Pause();
        }
    }
}
