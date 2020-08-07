using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecursion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number to calculate the factorial: ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Factorial of " + baseNumber.ToString() + " is " + factorial(baseNumber).ToString());
            Console.ReadLine();
        }

        public static long factorial(int baseNumber)
        {
           
            if (baseNumber == 1)
            {
                return 1;
            }
            else
            {
                return (baseNumber * (factorial(baseNumber - 1)));
            }
        }
    }
}
