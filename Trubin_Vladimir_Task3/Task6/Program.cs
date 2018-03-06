using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            Regex rgx1 = new Regex("^[0-9]*[.,]?[0-9]+$");
            Regex rgx2 = new Regex("^-[0-9]*[.,]?[0-9]+$");
            Regex rgx3 = new Regex("^[0-9]*[.,]?[0-9]*e[0-9]+$");
            Regex rgx4 = new Regex("^-[0-9]*[.,]?[0-9]*e[0-9]+$");
            Regex rgx5 = new Regex("^[0-9]*[.,]?[0-9]*e-[0-9]+$");
            Regex rgx6 = new Regex("^-[0-9]*[.,]?[0-9]*e-[0-9]+$");
            if (rgx1.IsMatch(number))
            {
                Console.WriteLine("Это число в обычной нотации");
            }
            else if (rgx2.IsMatch(number))
            {
                Console.WriteLine("Это число в обычной нотации");
            }
            else if (rgx3.IsMatch(number))
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else if (rgx4.IsMatch(number))
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else if (rgx5.IsMatch(number))
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else if (rgx6.IsMatch(number))
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else
            {
                Console.WriteLine("Это не число");
            }


            Console.ReadKey();

        }
    }
}
