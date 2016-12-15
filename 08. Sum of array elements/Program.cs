using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_array_elements
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

            int sum = SumOfArray(array, length);
            Console.WriteLine("Sum of elements: {0}", sum);
            Console.ReadLine();
        }

        public static int SumOfArray(int[] array, int length)
        {
            int sum = 0;
            if (length <= 0)
            {
                return 0;
            }
            else
            {
                return sum = array[length - 1] + SumOfArray(array, length - 1);
            }
        }

    }
}
