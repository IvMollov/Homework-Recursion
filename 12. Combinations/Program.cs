using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());           
            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());
            int[] array = new int[K];

            Combinations(array, 0, 1, N);
            Console.ReadLine();
        }
        public static void Combinations(int[] array, int index, int start, int end)
        {
            Console.WriteLine("Enter index = {0}, start = {1}", index, start);
            if (index > array.Length - 1)
            {
                Print(array);
            }
            else
            {
                for (int i = start; i <= end ; i++)
                {
                    Console.WriteLine("Enter loop i = {0}, index = {1}", i, index);
                    array[index] = i;
                    Console.WriteLine("Before recursion index = {0}, i = {1}", index, i);
                    Combinations(array, index + 1, i, end);
                    Console.WriteLine("After recursion index = {0}, i = {1}", index, i);
                }
            }
        }
        public static void Print(int[] array)
        {
            Console.Write("(");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write("{0}", array[i]);
                }
                else
                {
                    Console.Write("{0} ", array[i]);
                }
            }
            Console.Write("), ");
        }
    }
}
