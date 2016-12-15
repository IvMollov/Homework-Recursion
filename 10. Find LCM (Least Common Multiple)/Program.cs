using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Find_LCM__Least_Common_Multiple_
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter first number: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int numberTwo = int.Parse(Console.ReadLine());

            int max = 0;
            if(numberOne > numberTwo)
            {
                max = numberOne;
            }
            else
            {
                max = numberTwo;
            }
            int LCM = FindLCM(numberOne, numberTwo, max);
            Console.WriteLine("LCM: {0}", LCM);
            Console.ReadLine();
        }

        public static int FindLCM(int numberOne, int numberTwo, int max)
        {

            int LCM = 0;
           // return LCM = (numberOne * numberTwo) / FindGCD(numberOne, numberTwo);
            if ((max % numberOne == 0) && (max % numberTwo) == 0)
            {
                return max;
            }
            else
            {
                return LCM = FindLCM(numberOne, numberTwo, max + 1);
            }
        }

        //public static int FindGCD(int numberOne, int numberTwo)
        //{
        //    int GCD = 0;
        //    if (numberTwo <= 0)
        //    {
        //        return numberOne;
        //    }
        //    else
        //    {
        //        return GCD = FindGCD(numberTwo, numberOne % numberTwo);
        //    }
        //}
    }
}
