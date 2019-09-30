using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = GetNumber("Enter number A: ");
                int num2 = GetNumber("Enter number B: ");

                Console.WriteLine("Division = {0}", Calculator.Divide(num1, num2));

                Console.Read();
            }
            catch (CalculatorException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception)
            {
                Console.WriteLine("Neparedzeta kluda!");
            }

            Console.Read();

        }

        static int GetNumber (string text) // funkcija prieks katras ievades
        {
            Console.Write(text);
            string input = Console.ReadLine();

            // 1 variants
            //if (int.TryParse(input, out int result))
            //{
            //    return result; // atgrie'z true vai false
            //}

            // 2 variants:
            try
            {
                int result = int.Parse(input);
                return result;
            }
            catch (Exception) // beigas variable ex, ja mes velamies to izmantot talak ex.message piemeram
            {

                Console.WriteLine("Invalid number!");
                return GetNumber(text);
            }

        }
    }
}
