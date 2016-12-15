using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.All_even_or_odd_numbers
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

            Console.Write("Even numbers are: ");
            PrintEvenNumbers(number);

            Console.Write("\nOdd numbers are: ");
            PrintOddNumbers(number);
            Console.ReadLine();
        }

        public static void PrintEvenNumbers(int number)
        {
            if (number > 0)
            {
                PrintEvenNumbers(number - 1);
                if (number % 2 == 0)
                {
                    Console.Write("{0}, ", number);
                }
            }
        }
        public static void PrintOddNumbers(int number)
        {
            if (number > 0)
            {
                PrintOddNumbers(number - 1);
                if (number % 2 != 0)
                {
                    Console.Write("{0}, ", number);
                }
            }
        }

    }
}
