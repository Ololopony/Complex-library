using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public class PolarComplexNumber
    {
        public ComplexNumber Complex { get; set; }
        public double Arg { get; set; }
        public double Module { get; set; }

        public PolarComplexNumber(ComplexNumber Complex)
        {
            this.Complex = Complex;
        }

        public PolarComplexNumber(double arg, double module)
        {
            this.Arg = arg;
            this.Module = module;
        }

        public double ArgCount()
        {
            if (Complex.X > 0 && Complex.Y > 0)
                return Math.Atan(Complex.Y / Complex.X);

            else if (Complex.X > 0 && Complex.Y < 0)
                return -Math.Atan(Complex.Y / Complex.X);

            else if (Complex.X < 0 && Complex.Y > 0)
                return Math.PI - Math.Atan(Complex.Y / Complex.X);

            else if (Complex.X < 0 && Complex.Y < 0)
                return -Math.PI + Math.Atan(Complex.Y / Complex.X);

            else if (Complex.X == 0 && Complex.Y > 0)
                return Math.PI / 2;

            else if (Complex.X == 0 && Complex.Y < 0)
                return -Math.PI / 2;

            else if (Complex.X > 0 && Complex.Y == 0)
                return 0;

            else
                return Math.PI;
        }

        public PolarComplexNumber ConvertToPolar()
        {
            return new PolarComplexNumber(ArgCount(), Complex.Module());
        }

        public PolarComplexNumber Exponentiation(int n)
        {
            return new PolarComplexNumber(this.Arg * n, Math.Pow(this.Module, n));
        }

        public List<PolarComplexNumber> Rooting(double n)
        {
            List<PolarComplexNumber> roots = new List<PolarComplexNumber>();

            for (int k = 0; k < n; k++)
            {
                roots.Add(new PolarComplexNumber((this.Arg + 2 * k * Math.PI) / n, Math.Pow(this.Module, 1/n)));
            }

            return roots;
        }

        public string Print()
        {
            return $"z = {this.Module} * (cos{this.Arg} + i * sin{this.Arg})\r\n";
        }

        public string PrintList(List<PolarComplexNumber> roots)
        {
            string result = "";
            foreach (PolarComplexNumber polar in roots)
            {
                result += $"{polar.Print()}";
            }

            return result;
        }
    }
}
