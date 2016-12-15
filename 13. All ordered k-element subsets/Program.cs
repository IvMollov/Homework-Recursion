using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.All_ordered_k_element_subsets
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter N (> 1): ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());
            int[] array = new int[K];

            PrintOrderedSubsets(0, N, array);
            Console.ReadLine();
        }

        public static void PrintOrderedSubsets(int index, int end, int[] array)
        {
            if (index > array.Length - 1)
            {
                Print(array);
            }
            else
            {
                for (int i = 1; i <= end; i++)
                {
                    array[index] = i;
                    PrintOrderedSubsets(index + 1, end, array);
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
                    Console.Write("{0}, ", array[i]);
                }
            }
            Console.Write("), ");
        }
    }
}

