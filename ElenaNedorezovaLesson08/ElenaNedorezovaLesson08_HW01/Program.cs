using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ElenaNedorezovaLesson08_HW01
{
    /*
    Задание:
    С помощью рефлексии выведите все свойства структуры DateTime

    Студент:
    Елена Недорезова
    */

    class Program
    {

        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            MemberInfo[] memberInfos = dateTime.GetType().GetMembers();

            foreach (var item in memberInfos)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }

    }
}
