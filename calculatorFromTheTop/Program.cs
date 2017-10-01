using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorFromTheTop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the calculator!");

            Console.WriteLine("Enter your first number: ");
            string num1 = Console.ReadLine();
            Console.WriteLine("Enter your second number: ");
            string num2 = Console.ReadLine();

            int userInteger1 = int.Parse(num1);
            int userInteger2 = int.Parse(num2);

            int result = userInteger2 * userInteger1;  


            Console.WriteLine("Your answer is " + result);
            Console.ReadLine();
        }
    }
}
