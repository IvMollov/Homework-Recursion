using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Print_all_elements_of_array
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter length of the array: ");
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter {0} element: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Output: ");
            PrintElements(array, length);
            Console.ReadLine();
        }

        public static void PrintElements(int[] array, int length)
        {
            int sum = 0;
            if (length <= 0)
            {
                return;
            }
            else
            {
                PrintElements(array, length - 1);
                Console.Write("{0}, ", array[length - 1]);
            }
        }

    }
}
