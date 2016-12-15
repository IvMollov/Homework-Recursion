using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Calculate_sum_of_digits
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = SumOfDigits(number);
            Console.WriteLine("Sum of digits: {0}", sum);
            Console.ReadLine();
        }

        public static int SumOfDigits(int number)
        {
            int digit = 0;
            int sum = 0;

            if (number == 0)
            {
                return 0;
            }
            else
            {
                digit = number % 10;
                return sum = digit + SumOfDigits(number / 10);
            }
        }

    }
}
