using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Ring : Round
    {
        private double innerR;

        public Ring(double x, double y, double r, double innerR) : base(x, y, r)
        {
            if (innerR > 0 && innerR < r)
            {
                InnerRadius = innerR;
            }
        }

        public double InnerRadius { get; set; }

        public double SummaryLength(double innerRadius, double radius)
        {
            return (Length(radius) + Length(innerRadius));
        }

        public double Square(double innerRadius, double radius)
        {
            return (Square(radius) - Square(innerRadius));
        }
    }
}
