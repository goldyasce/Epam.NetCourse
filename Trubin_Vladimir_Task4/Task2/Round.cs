using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        private double x;
        private double y;
        private double radius;
        private double pi = 3.14;

        public double Xcoordinate
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public double Ycoordinate
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
            }
        }

        public double RoundSquare(double round)
        {
            return pi * Math.Pow(radius, 2);
        }

        public double RoundLength(double round)
        {
            return pi * radius * 2;
        }
    }
}
