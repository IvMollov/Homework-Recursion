using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sum_of_all_even_or_odd_numbers
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter range from 1 to: ");
            int number = int.Parse(Console.ReadLine());
            while (number < 1)
            {
                Console.Write("Enter number (>= 1): ");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Choose number \"1\" to find sum of all even numbers between 1 and {0}." +
                                "\nChoose number \"2\" to find sum of all odd numbers between 1 and {0}.", number);

            Console.Write("Your choice is: ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                int sum = FindEvenNumbersSum(number);
                Console.WriteLine("Sum of all even numbers in range (1 - {0}) is: {1}", number, sum);
            }
            if (choose == 2)
            {
                int sum = FindOddNumbersSum(number);
                Console.WriteLine("Sum of all odd numbers in range (1 - {0}) is: {1}", number, sum);
            }
            Console.ReadLine();
        }

        public static int FindEvenNumbersSum(int number)
        {
            int sum = 0;
            int evenNumber = 0;
            if (number <= 1)
            {
                return 0;
            }
            else
            {
                evenNumber = FindEven(number);
                return sum = evenNumber + FindEvenNumbersSum(number - 1);
            }
        }

        public static int FindEven(int number)
        {
            int evenNumber = 0;
            if (number % 2 == 0)
            {
                evenNumber = number;
            }

            return evenNumber;
        }

        public static int FindOddNumbersSum(int number)
        {
            int sum = 0;
            int oddNumber = 0;
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                oddNumber = FindOdd(number);
                return sum = oddNumber + FindOddNumbersSum(number - 1);
            }
        }

        public static int FindOdd(int number)
        {
            int oddNumber = 0;
            if (number % 2 != 0)
            {
                oddNumber = number;
            }

            return oddNumber;
        }

    }
}
