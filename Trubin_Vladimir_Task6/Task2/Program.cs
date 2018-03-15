using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApplication;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var gp = new GeomProg(2, 3);
            InterfacesDemo.PrintSeries(gp);
            Console.ReadKey();
        }
    }
}
