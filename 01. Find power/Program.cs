using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Find_power
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter number: ");
            long number = long.Parse(Console.ReadLine());
            Console.Write("Enter power: ");
            int power = int.Parse(Console.ReadLine());

            long result = FindPower(number, power);
            Console.WriteLine("Result is: {0}", result);
            Console.ReadLine();
        }

        public static long FindPower(long number, int power)
        {
            long result = 0;
            if (power == 1)
            {
                return number;
            }
            else if (power == 0)
            {
                return result = 1 * FindPower(1, 1);
            }
            else
            {
                result = number * FindPower(number, power - 1);
                return result;
            }

        }
    }
}
