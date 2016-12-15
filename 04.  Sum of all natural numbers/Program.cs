using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_of_all_natural_numbers
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter number (>= 1): ");
            int number = int.Parse(Console.ReadLine());
            while (number < 1)
            {
                Console.Write("Enter number (>= 1): ");
                number = int.Parse(Console.ReadLine());
            }

            int sum = CalculateSum(number);
            Console.Write("Sum of natural numbers from 1 to {0}: {1}", number, sum);

            Console.ReadLine();
        }

        public static int CalculateSum(int number)
        {
            int sum = 0;
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return sum = number + CalculateSum(number - 1);
            }
        }

    }
}
