using System;

namespace ElenaNedorezovaLesson04
{
    /*
    Задание:
    Дан  целочисленный  массив  из 20 элементов.  
    Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  
    Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
    В данной задаче под парой подразумевается два подряд идущих элемента массива. 
    Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

    Студент: Недорезова Елена
     */

    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayFromExample = GetArrayFromExample();
            int coupleFromExample = CountCoupleDiv3(arrayFromExample);
            Console.WriteLine($"В массиве из примера {coupleFromExample} {GetRightWordCouple(coupleFromExample)} элементов, " +
                $"в которых только одно число делится на 3");

            int[] arrayTask = GetArrayFillRandom(20, -10000, 10000);
            int coupleTask = CountCoupleDiv3(arrayTask);
            Console.WriteLine($"В массиве из задачи {coupleTask} {GetRightWordCouple(coupleTask)} элементов, " +
                $"в которых только одно число делится на 3");

            Console.ReadKey();
        }

        private static string GetRightWordCouple(int count)
        {
            if (count > 0 && count < 5)
                return "пары";

            return "пар";
        }

        private static int[] GetArrayFromExample()
        {
            return new int[] { 6, 2, 9, -3, 6 };
        }

        private static int[] GetArrayFillRandom (int counElement, int min, int max)
        {
            int[] array = new int[counElement];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max);
            }

            return array;
        }

        private static int CountCoupleDiv3 (int[] array)
        {
            int couple = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] % 3 == 0) != (array[i + 1] % 3 == 0))
                    couple++;
            }

            return couple;
        }
    }
}
