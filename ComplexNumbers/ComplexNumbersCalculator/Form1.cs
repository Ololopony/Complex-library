using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComplexNumbers;

namespace ComplexNumbersCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            ComplexNumber num1 = new ComplexNumber(double.Parse(textX1.Text), double.Parse(textY1.Text));
            ComplexNumber num2 = new ComplexNumber(double.Parse(textX2.Text), double.Parse(textY2.Text));

            ComplexNumber res = num1 + num2;

            Result.Text += num1.Print();
            Result.Text += "+\r\n";
            Result.Text += num2.Print();
            Result.Text += "=\r\n";
            Result.Text += res.Print();
            Result.Text += "------------------\r\n";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            ComplexNumber num1 = new ComplexNumber(double.Parse(textX1.Text), double.Parse(textY1.Text));
            ComplexNumber num2 = new ComplexNumber(double.Parse(textX2.Text), double.Parse(textY2.Text));

            ComplexNumber res = num1 - num2;

            Result.Text += num1.Print();
            Result.Text += "-\r\n";
            Result.Text += num2.Print();
            Result.Text += "=\r\n";
            Result.Text += res.Print();
            Result.Text += "------------------\r\n";
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            ComplexNumber num1 = new ComplexNumber(double.Parse(textX1.Text), double.Parse(textY1.Text));
            ComplexNumber num2 = new ComplexNumber(double.Parse(textX2.Text), double.Parse(textY2.Text));

            ComplexNumber res = num1 * num2;

            Result.Text += num1.Print();
            Result.Text += "*\r\n";
            Result.Text += num2.Print();
            Result.Text += "=\r\n";
            Result.Text += res.Print();
            Result.Text += "------------------\r\n";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            ComplexNumber num1 = new ComplexNumber(double.Parse(textX1.Text), double.Parse(textY1.Text));
            ComplexNumber num2 = new ComplexNumber(double.Parse(textX2.Text), double.Parse(textY2.Text));

            ComplexNumber res = num1 / num2;

            Result.Text += num1.Print();
            Result.Text += "/\r\n";
            Result.Text += num2.Print();
            Result.Text += "=\r\n";
            Result.Text += res.Print();
            Result.Text += "------------------\r\n";
        }

        private void Module_Click(object sender, EventArgs e)
        {
            ComplexNumber num = new ComplexNumber(double.Parse(textX.Text), double.Parse(textY.Text));

            double res = num.Module();

            Result.Text += num.Print();
            Result.Text += $"|Z| = {res}\r\n";
            Result.Text += "------------------\r\n";
        }

        private void ConvToPolar_Click(object sender, EventArgs e)
        {
            ComplexNumber num = new ComplexNumber(double.Parse(textX.Text), double.Parse(textY.Text));

            PolarComplexNumber res = new PolarComplexNumber(num);
            res = res.ConvertToPolar();

            Result.Text += num.Print();
            Result.Text += $"=\r\n";
            Result.Text += res.Print();
            Result.Text += "------------------\r\n";
        }

        private void Expon_Click(object sender, EventArgs e)
        {
            ComplexNumber num = new ComplexNumber(double.Parse(textX.Text), double.Parse(textY.Text));
            int n = Int32.Parse(textN.Text);

            PolarComplexNumber res = new PolarComplexNumber(num);
            res = res.ConvertToPolar();
            res = res.Exponentiation(n);

            Result.Text += num.Print();
            Result.Text += $"Z^n = \r\n";
            Result.Text += res.Print();
            Result.Text += "------------------\r\n";
        }

        private void Rooting_Click(object sender, EventArgs e)
        {
            ComplexNumber num = new ComplexNumber(double.Parse(textX.Text), double.Parse(textY.Text));
            int n = Int32.Parse(textN.Text);

            PolarComplexNumber res = new PolarComplexNumber(num);
            res = res.ConvertToPolar();

            Result.Text += num.Print();
            Result.Text += $"Z^(1/n) = \r\n";
            Result.Text += res.PrintList(res.Rooting(n));
            Result.Text += "------------------\r\n";
        }
    }
}
