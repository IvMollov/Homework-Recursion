using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.All_permutations
{
    class Program
    {
        static int[] first;
        public static void Main()
        {
            Console.Write("Enter number (> 1): ");
            int length = int.Parse(Console.ReadLine());
            while (length <= 1)
            {
                Console.Write("Enter number (> 1): ");
                length = int.Parse(Console.ReadLine());
            }
            first = new int[length];

            int[] array = new int[length];

            Permutation(0, length, array);
            Console.ReadLine();
        }

        public static void Permutation(int index, int end, int[] array)
        {
            if (index >= end)
            {
                Print(array);
            }
            else
            {
                for (int i = 0; i < end; i++)
                {
                    if (first[i] == 0)
                    {
                        first[i] = 1;
                        array[index] = i + 1;
                        Permutation(index + 1, end, array);
                        first[i] = 0;
                    }
                }
            }

        }
        public static void Print(int[] array)
        {
            Console.Write("{");
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
            Console.Write("}, ");
        }

    }
}