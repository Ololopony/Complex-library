using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class PolarComplexNumberPrint : PolarComplexNumber
    {
        public PolarComplexNumberPrint(ComplexNumber Complex) : base(Complex)
        {
        }

        public PolarComplexNumberPrint(double arg, double module) : base(arg, module)
        {
        }

        public string Print()
        {
            return $"z = {this.Module} * (cos{this.Arg} + sin{this.Arg})";
        }

        public string PrintList(int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += $"{Print()}\n";
            }

            return result;
        }
    }
}
