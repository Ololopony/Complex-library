using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public class ComplexNumber
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Arg { get; set; }

        public ComplexNumber(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.X + num2.X, num1.Y + num2.Y);
        }

        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.X - num2.X, num1.Y - num2.Y);
        }

        public static ComplexNumber operator *(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.X * num2.X - num1.Y * num2.Y, num1.X * num2.Y + num2.X * num1.Y);
        }

        public static ComplexNumber operator /(ComplexNumber num1, ComplexNumber num2)
        {
            double xc = ((num1.X * num2.X + num1.Y * num2.Y) / (Math.Pow(num2.X, 2) + Math.Pow(num2.Y, 2)));
            double yc = ((num2.X * num1.Y - num1.X * num2.Y) / (Math.Pow(num2.X, 2) + Math.Pow(num2.Y, 2)));
            return new ComplexNumber(xc, yc);
        }

        public double Module()
        {
            return Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2));
        }
    }
}
