using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public class PolarComplexNumber:ComplexNumber, ICloneable
    {
        public double Arg { get; set; }
        public double Module { get; set; }
        public PolarComplexNumber()
        {
            this.Arg = 0;
            this.Module = 0;
        }
        public PolarComplexNumber(double arg, double module)
        {
            this.Arg = arg;
            this.Module = module;
        }

        public static PolarComplexNumber operator *(PolarComplexNumber num1, PolarComplexNumber num2)
        {
            return new PolarComplexNumber(num1.Arg + num2.Arg, num1.Module * num2.Module);
        }

        public static PolarComplexNumber operator /(PolarComplexNumber num1, PolarComplexNumber num2)
        {
            return new PolarComplexNumber(num1.Arg - num2.Arg, num1.Module / num2.Module);
        }
        public ComplexNumber ConvertToDekart()
        {
            double x = Module * Math.Cos(Arg);
            double y = Module * Math.Sin(Arg);

            return new ComplexNumber(x, y);
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

        public new string Print()
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
        object ICloneable.Clone()
        {
            return new PolarComplexNumber(Arg, Module);
        }
    }
}
