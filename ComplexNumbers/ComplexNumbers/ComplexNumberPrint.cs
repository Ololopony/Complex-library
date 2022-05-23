using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class ComplexNumberPrint : ComplexNumber
    {
        public ComplexNumberPrint(double x, double y) : base(x, y)
        {
        }

        public string Print()
        {
            return $"z = {this.X} + i * {this.Y}";
        }
    }
}
