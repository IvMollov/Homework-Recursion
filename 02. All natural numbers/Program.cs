using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.All_natural_numbers
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

            PrintNumbers(number);
            Console.ReadLine();
        }

        public static void PrintNumbers(int number)
        {

            if (number > 0)
            {
                PrintNumbers(number - 1);
                Console.Write("{0}, ", number);
            }
        }

    }
}
