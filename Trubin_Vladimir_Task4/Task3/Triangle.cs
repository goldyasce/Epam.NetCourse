using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;

        public double SideA
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
            }
        }

        public double SideB
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
            }
        }

        public double SideC
        {
            get
            {
                return c;
            }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
            }
        }

        public double Square(double a, double b, double c)
        {
            if ((b + c > a) && (a + c > b) && (a + b > c))
            {
                double p = Perimetr(a, b, c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return 0;
        }

        public double Perimetr(double a, double b, double c)
        {
            if ((b + c > a) && (a + c > b) && (a + b > c))
            {
                return a + b + c;
            }
            return 0;
        }
    }
}
