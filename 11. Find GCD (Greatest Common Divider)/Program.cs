using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Find_GCD__Greatest_Common_Divider_
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter first number: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int numberTwo = int.Parse(Console.ReadLine());

            int GCD = FindGCD(numberOne, numberTwo);
            Console.WriteLine("GCD (Greatest Common Divider): {0}", GCD);
            Console.ReadLine();
        }

        public static int FindGCD(int numberOne, int numberTwo)
        {
            int GCD = 0;

            if (numberTwo <= 0)
            {
                return numberOne;
            }
            else
            {
                return GCD = FindGCD(numberTwo, numberOne % numberTwo);
            }
        }

    }
}
