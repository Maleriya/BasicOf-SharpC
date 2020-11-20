using System;
using System.Collections.Generic;

namespace LibraryMyArray
{
    public class MyArray
    {
        int[] array;
        Random rnd = new Random();

        public MyArray(int n)
        {
            array = new int[n];
            for (int i = 0; i < n; i++)
                array[i] = rnd.Next(1, 10);
        }

        public MyArray(int length, int start, int step)
        {
            array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = start;
                start += step;
            }
        }

        public int Max
        {
            get
            {
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (array[i] > max) max = array[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (array[i] < min) min = array[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                    if (array[i] > 0) count++;
                return count;
            }
        }

        public int[] Inverse()
        {
            int[] arrayInverse = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayInverse[i] = array[i] * (-1);
            }
            return arrayInverse;
        }

        public void Multi(int mul)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= mul;
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                    sum += array[i];

                return sum;
            }
        }

        public int MaxCount
        {
            get
            {
                int count = 0;
                int max = Max;
                foreach (var item in array)
                {
                    if (item == max)
                        count++;
                }
                return count;
            }
        }

        public Dictionary<int, int> GetDictionary()
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (var item in array)
            {
                if (keyValuePairs.ContainsKey(item))
                    keyValuePairs[item]++;
                else
                {
                    keyValuePairs.Add(item, 1);
                }
            }
            return keyValuePairs;
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in array)
                s = s + v + " ";
            return s;
        }
    }
}
