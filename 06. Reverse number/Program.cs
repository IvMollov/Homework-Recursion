using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_number
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            string numberToText = ReverseNumber(number);
            Console.WriteLine("Reverse number: {0}", numberToText);
            Console.ReadLine();
        }

        public static string ReverseNumber(int number)
        {
            string numberText = "";
            int digit = 0;

            if (number == 0)
            {
                return " ";
            }
            else
            {
                digit = number % 10;
                return numberText = digit + ReverseNumber(number / 10);
            }
        }

    }
}
