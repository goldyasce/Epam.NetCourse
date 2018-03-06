using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text with time: ");
            string number = Console.ReadLine();
            const string regex = "([01]?[0-9]|2[0-3]):[0-5][0-9]";
            int counter = 0;
            MatchCollection match1 = Regex.Matches(number, regex);
            foreach (Match m in match1)
            {
                counter++;
            }
            Console.WriteLine($"Время встречается {counter} раз.");

            Console.ReadKey();
        }
    }
}
