using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter culture name: ");
            string cultureName = Console.ReadLine();
            Console.Write("Enter culture name for contrast: ");
            string contrastCultureName = Console.ReadLine();
            Console.WriteLine();
            if ((cultureName == "en" || cultureName == "ru" || cultureName == "invariant") && (contrastCultureName == "en" || contrastCultureName == "ru" || contrastCultureName == "invariant"))
            {
                CultureContrast(cultureName, contrastCultureName);
            }
            else
            {
                Console.WriteLine("Wrong culture name!");
            }
            Console.Write("Enter number: ");
            double number = double.Parse(Console.ReadLine());
            NumberFormat(number);

            Console.ReadKey();
        }
        static void CultureContrast(string cultureName, string contrastCultureName)
        {
            DateTime thisDate = new DateTime(2018, 3, 6, 17, 37, 0);
            switch (cultureName)
            {
                case "en":
                    {
                        Console.Write("English format: ");
                        Console.WriteLine(thisDate.ToString("f", CultureInfo.CreateSpecificCulture("en")));
                        Console.WriteLine();
                        break;
                    }
                case "ru":
                    {
                        Console.Write("Russian format: ");
                        Console.WriteLine(thisDate.ToString("f", CultureInfo.CreateSpecificCulture("ru")));
                        Console.WriteLine();
                        break;
                    }
                case "invariant":
                    {
                        Console.Write("Standart format: ");
                        Console.WriteLine(thisDate.ToString("f", CultureInfo.CreateSpecificCulture("")));
                        Console.WriteLine();
                        break;
                    }
            }
            switch (contrastCultureName)
            {
                case "en":
                    {
                        Console.Write("English format: ");
                        Console.WriteLine(thisDate.ToString("f", CultureInfo.CreateSpecificCulture("en")));
                        Console.WriteLine();
                        break;
                    }
                case "ru":
                    {
                        Console.Write("Russian format: ");
                        Console.WriteLine(thisDate.ToString("f", CultureInfo.CreateSpecificCulture("ru")));
                        Console.WriteLine();
                        break;
                    }
                case "invariant":
                    {
                        Console.Write("Standart format: ");
                        Console.WriteLine(thisDate.ToString("f", CultureInfo.CreateSpecificCulture("")));
                        Console.WriteLine();
                        break;
                    }
            }

        }
        static void NumberFormat(double number)
        {
            Console.WriteLine("Money format: " + number.ToString("c3"));
            Console.WriteLine("Exponential format: " + number.ToString("e"));
            Console.WriteLine("Fixed dot format: " + number.ToString("F3"));
            Console.WriteLine("Optimal format: " + number.ToString("G5"));
            Console.WriteLine("Number format: " + number.ToString("N1"));
            Console.WriteLine("Percent format: " + number.ToString("P1"));
        }
    }
}
