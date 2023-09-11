using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32("45");

            Console.WriteLine(num1);

            Console.WriteLine("Enter first number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            double num3=Convert.ToDouble(Console.ReadLine());

            double num4=num2+num3;
            Console.WriteLine(num2 +" + " + num3 + " = " +num4);
            Console.WriteLine("The sum for the entered numbers is: " + num4);

            //freeze console
            Console.ReadLine();
        }
    }
}
