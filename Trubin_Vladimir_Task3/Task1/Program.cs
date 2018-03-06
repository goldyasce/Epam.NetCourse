using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string line = Console.ReadLine();
            Console.WriteLine($"Average: {Average(line)}");

            Console.ReadKey();
        }
        static int Average(string line)
        {
            int nchars = 0;
            int nwords = 0;
            char[] punct = new char[line.Length];
            int j = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (!Char.IsLetter(line[i]))
                {
                    punct[j] = line[i];
                    j++;
                }
            }
            string[] substr = line.Split(punct, StringSplitOptions.RemoveEmptyEntries);
            string newstr = string.Join(" ", substr);
            for (int i = 0; i < newstr.Length; i++)
            {
                if (!(newstr[i] == ' '))
                {
                    nchars += 1;
                }
                else
                {
                    nwords++;
                }
            }
            nwords += 1;
            int avg = nchars / nwords;

            return avg;
        }
    }
}
