using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_L3_TryCatchExceptions_v2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter first integer: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Please enter second integer: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            }

            // First exeception:
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\nSystem error to be logged in a file: ");
                Console.WriteLine(ex);

                Console.WriteLine("\nError message printed to screen for user: ");
                Console.Write("Cannot divide by zero. Please try again.");
            }

            // Second exeception:
            catch (FormatException ex)
            {
                Console.WriteLine("\nSystem error to be logged in a file: ");
                Console.WriteLine(ex);

                Console.WriteLine("\nError message printed to screen for user: ");
                Console.Write("Not a valid number. Please try again.");
            }

            Console.ReadLine();
        }
    }
}
