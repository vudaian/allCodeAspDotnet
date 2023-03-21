using System;
using System.Collections;

namespace TuKhoaYield
{
    class Program
    {
        public static IEnumerable GetArray1(int n)
        {
            int[] numbers = new int[n];
            for(int i = 0; i < n; i++)
            {
                numbers[i] = i;
            }
            return numbers;
        }

        public static IEnumerable GetArray2(int n)
        {
            for(int i = 0; i < n; i++)
            {
                yield return i;
            }
        }

        static void Main(string[] args)
        {
            IEnumerable arrInt = GetArray2(10);
            foreach(var item in arrInt)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
