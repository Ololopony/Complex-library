using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class PolarComplexNumber
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

        public void ArgCount()
        {
            if (Complex.X > 0 && Complex.Y > 0)
                this.Arg = Math.Atan(Complex.Y / Complex.X);

            else if (Complex.X > 0 && Complex.Y < 0)
                this.Arg = -Math.Atan(Complex.Y / Complex.X);

            else if (Complex.X < 0 && Complex.Y > 0)
                this.Arg = Math.PI - Math.Atan(Complex.Y / Complex.X);

            else if (Complex.X < 0 && Complex.Y < 0)
                this.Arg = -Math.PI + Math.Atan(Complex.Y / Complex.X);

            else if (Complex.X == 0 && Complex.Y > 0)
                this.Arg = Math.PI / 2;

            else if (Complex.X == 0 && Complex.Y < 0)
                this.Arg = -Math.PI / 2;

            else if (Complex.X > 0 && Complex.Y == 0)
                this.Arg = 0;

            else if (Complex.X < 0 && Complex.Y == 0)
                this.Arg = Math.PI;
        }

        public PolarComplexNumber Exponentiation(int n)
        {
            return new PolarComplexNumber(Math.Pow(this.Module, n), this.Arg * n);
        }

        public ICollection<PolarComplexNumber> Rooting(int n)
        {
            ICollection<PolarComplexNumber> roots = new List<PolarComplexNumber>();

            for (int k = 0; k < n; k++)
            {
                roots.Add(new PolarComplexNumber((this.Arg + 2 * k * Math.PI) / n, Math.Pow(this.Module, 1 / n)));
            }

            return roots;
        }
    }
}
