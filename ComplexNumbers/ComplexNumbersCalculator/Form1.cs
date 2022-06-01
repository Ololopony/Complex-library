﻿using System;
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
            try
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
            catch (Exception)
            {
                MessageBox.Show("Числу были переданы нулевые значения.");

                ComplexNumber num1 = new ComplexNumber();
                ComplexNumber num2 = new ComplexNumber();
                ComplexNumber res = num1 + num2;

                Result.Text += num1.Print();
                Result.Text += "+\r\n";
                Result.Text += num2.Print();
                Result.Text += "=\r\n";
                Result.Text += res.Print();
                Result.Text += "------------------\r\n";
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Числу были переданы нулевые значения.");

                ComplexNumber num1 = new ComplexNumber();
                ComplexNumber num2 = new ComplexNumber();

                ComplexNumber res = num1 - num2;

                Result.Text += num1.Print();
                Result.Text += "-\r\n";
                Result.Text += num2.Print();
                Result.Text += "=\r\n";
                Result.Text += res.Print();
                Result.Text += "------------------\r\n";
            }
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Числу были переданы нулевые значения.");

                ComplexNumber num1 = new ComplexNumber();
                ComplexNumber num2 = new ComplexNumber();

                ComplexNumber res = num1 * num2;

                Result.Text += num1.Print();
                Result.Text += "*\r\n";
                Result.Text += num2.Print();
                Result.Text += "=\r\n";
                Result.Text += res.Print();
                Result.Text += "------------------\r\n";
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Числу были переданы нулевые значения.");

                ComplexNumber num1 = new ComplexNumber();
                ComplexNumber num2 = new ComplexNumber();

                ComplexNumber res = num1 / num2;

                Result.Text += num1.Print();
                Result.Text += "/\r\n";
                Result.Text += num2.Print();
                Result.Text += "=\r\n";
                Result.Text += res.Print();
                Result.Text += "------------------\r\n";
            }
        }

        private void Module_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexNumber num = new ComplexNumber(double.Parse(textX.Text), double.Parse(textY.Text));

                double res = num.Get_Module();

                Result.Text += num.Print();
                Result.Text += $"|Z| = {res}\r\n";
                Result.Text += "------------------\r\n";
            }
            catch (Exception)
            {
                MessageBox.Show("Числу были переданы нулевые значения.");

                ComplexNumber num = new ComplexNumber();

                double res = num.Get_Module();

                Result.Text += num.Print();
                Result.Text += $"|Z| = {res}\r\n";
                Result.Text += "------------------\r\n";
            }
        }

        private void ConvToPolar_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexNumber num = new ComplexNumber(double.Parse(textX.Text), double.Parse(textY.Text));

                num.ConvertToPolar();
                PolarComplexNumber res = new PolarComplexNumber();
                res = num.ConvertToPolar();

                Result.Text += num.Print();
                Result.Text += $"=\r\n";
                Result.Text += res.Print();
                Result.Text += "------------------\r\n";
            }
            catch (Exception)
            {
                MessageBox.Show("Числу были переданы нулевые значения.");
                ComplexNumber num = new ComplexNumber();

                num.ConvertToPolar();
                PolarComplexNumber res = new PolarComplexNumber();
                res = num.ConvertToPolar();

                Result.Text += num.Print();
                Result.Text += $"=\r\n";
                Result.Text += res.Print();
                Result.Text += "------------------\r\n";
            }
        }

        private void Expon_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexNumber num = new ComplexNumber(double.Parse(textX.Text), double.Parse(textY.Text));
                int n = Int32.Parse(textN.Text);

                PolarComplexNumber res = new PolarComplexNumber();
                res = num.ConvertToPolar();
                res = res.Exponentiation(n);

                Result.Text += num.Print();
                Result.Text += $"Z^n = \r\n";
                Result.Text += res.Print();
                Result.Text += "------------------\r\n";
            }
            catch (Exception)
            {
                MessageBox.Show("Числу были переданы нулевые значения.");

                ComplexNumber num = new ComplexNumber();
                int n = 1;

                PolarComplexNumber res = new PolarComplexNumber();
                res = num.ConvertToPolar();
                res = res.Exponentiation(n);

                Result.Text += num.Print();
                Result.Text += $"Z^n = \r\n";
                Result.Text += res.Print();
                Result.Text += "------------------\r\n";
            }
        }

        private void Rooting_Click(object sender, EventArgs e)
        {
            try
            {
                ComplexNumber num = new ComplexNumber(double.Parse(textX.Text), double.Parse(textY.Text));
                int n = Int32.Parse(textN.Text);

                PolarComplexNumber res = new PolarComplexNumber();
                res = num.ConvertToPolar();

                Result.Text += num.Print();
                Result.Text += $"Z^(1/n) = \r\n";
                Result.Text += res.PrintList(res.Rooting(n));
                Result.Text += "------------------\r\n";
            }
            catch (Exception)
            {
                MessageBox.Show("Числу были переданы нулевые значения.");

                ComplexNumber num = new ComplexNumber();
                int n = 1;

                PolarComplexNumber res = new PolarComplexNumber();
                res = num.ConvertToPolar();

                Result.Text += num.Print();
                Result.Text += $"Z^(1/n) = \r\n";
                Result.Text += res.PrintList(res.Rooting(n));
                Result.Text += "------------------\r\n";
            }
        }

        private void radioButtonDekart_CheckedChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                try
                {
                    PolarComplexNumber num1 = new PolarComplexNumber(double.Parse(textBox1.Text), double.Parse(textX1.Text));
                    PolarComplexNumber num2 = new PolarComplexNumber(double.Parse(textBox2.Text), double.Parse(textX2.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("Не введены значения");
                    textX1.Text = "0"; textY1.Text = "0"; textBox1.Text = "0";
                    textX2.Text = "0"; textY2.Text = "0"; textBox2.Text = "0";
                    textX.Text = "0"; textY.Text = "0"; textBox3.Text = "0";
                }
            }
            else
            if (tabControl1.SelectedTab == tabPage2)
            {
                try
                {
                    PolarComplexNumber num3 = new PolarComplexNumber(double.Parse(textBox3.Text), double.Parse(textX.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("Не введены значения");
                    textX1.Text = "0"; textY1.Text = "0"; textBox1.Text = "0";
                    textX2.Text = "0"; textY2.Text = "0"; textBox2.Text = "0";
                    textX.Text = "0"; textY.Text = "0"; textBox3.Text = "0";
                }
            }

            if (radioButtonDekart.Checked)
            {
                Module.Visible = true;
                ConvToPolar.Visible = true;
                Pass.Visible = false;

                PolarComplexNumber num1 = new PolarComplexNumber(double.Parse(textBox1.Text), double.Parse(textX1.Text));
                PolarComplexNumber num2 = new PolarComplexNumber(double.Parse(textBox2.Text), double.Parse(textX2.Text));
                PolarComplexNumber num3 = new PolarComplexNumber(double.Parse(textBox3.Text), double.Parse(textX.Text));

                ComplexNumber num4 = num1.ConvertToDekart();
                ComplexNumber num5 = num2.ConvertToDekart();
                ComplexNumber num6 = num3.ConvertToDekart();
                textX1.Text = num4.X.ToString(); textY1.Text = num4.Y.ToString();
                textX2.Text = num5.X.ToString(); textY2.Text = num5.Y.ToString();
                textX.Text = num6.X.ToString(); textY.Text = num6.Y.ToString();

                label1.Text = "Z1 = ";
                label2.Text = "  + i * ";
                textX1.Size = new Size(76, 22);
                textY1.Size = new Size(76, 22);
                textX1.Location = new Point(40, 6);

                label4.Text = "Z2 = ";
                label5.Text = "  + i * ";
                textX2.Size = new Size(76, 22);
                textY2.Size = new Size(76, 22);
                textX2.Location = new Point(40, 46);

                label7.Text = "Z = ";
                label6.Text = "+ i *";
                textX.Size = new Size(76, 20);
                textY.Size = new Size(76, 20);
                textX.Location = new Point(40, 11);

                label9.Text = "";
                label10.Text = "";
                label11.Text = "";
                textX1.BringToFront();
                textX2.BringToFront();
                textY1.BringToFront();
                textY2.BringToFront();
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
            }
            
            
        }
        private void radioButtonPolar_CheckedChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                try
                {
                    ComplexNumber num1 = new ComplexNumber(double.Parse(textX1.Text), double.Parse(textY1.Text));
                    ComplexNumber num2 = new ComplexNumber(double.Parse(textX2.Text), double.Parse(textY2.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("Не введены значения");
                    textX1.Text = "0"; textY1.Text = "0";
                    textX2.Text = "0"; textY2.Text = "0";
                    textX.Text = "0"; textY.Text = "0";
                }
            }
            else
            if (tabControl1.SelectedTab == tabPage2)
            {
                try
                {
                    ComplexNumber num3 = new ComplexNumber(double.Parse(textX.Text), double.Parse(textY.Text));
                }
                catch (Exception)
                {
                    MessageBox.Show("Не введены значения");
                    textX1.Text = "0"; textY1.Text = "0";
                    textX2.Text = "0"; textY2.Text = "0";
                    textX.Text = "0"; textY.Text = "0";
                }
            }

            if (radioButtonPolar.Checked)
            {
                Module.Visible = false;
                ConvToPolar.Visible = false;
                Pass.Visible = true;

                ComplexNumber num1 = new ComplexNumber(double.Parse(textX1.Text), double.Parse(textY1.Text));
                ComplexNumber num2 = new ComplexNumber(double.Parse(textX2.Text), double.Parse(textY2.Text));
                ComplexNumber num3 = new ComplexNumber(double.Parse(textX.Text), double.Parse(textY.Text));

                PolarComplexNumber num4 = num1.ConvertToPolar();
                PolarComplexNumber num5 = num2.ConvertToPolar();
                PolarComplexNumber num6 = num3.ConvertToPolar();

                textBox1.Text = num4.Arg.ToString(); textX1.Text = num4.Module.ToString(); textY1.Text = num4.Module.ToString();
                textBox2.Text = num5.Arg.ToString(); textX2.Text = num5.Module.ToString(); textY2.Text = num4.Module.ToString();
                textBox3.Text = num6.Arg.ToString(); textX.Text = num6.Module.ToString(); textY.Text = num6.Module.ToString();


                label1.Text = "Z1 =  r    * (cos(";
                label2.Text = ")+ sin(";
                textX1.Size = new Size(35, 22);
                textY1.Size = new Size(76, 22);
                textX1.Location = new Point(81, 6);

                label4.Text = "Z2 =  r    * (cos(";
                label5.Text = ")+ sin(";
                textX2.Size = new Size(35, 22);
                textY2.Size = new Size(76, 22);
                textX2.Location = new Point(81, 46);

                label7.Text = "Z =  r    * (cos(";
                label6.Text = ")+ sin(";
                textX.Size = new Size(44, 20);
                textY.Size = new Size(76, 20);
                textX.Location = new Point(74, 11);

                label9.Text = "))";
                label10.Text = "))";
                label11.Text = "))";
                textX1.BringToFront();
                textX2.BringToFront();
                textY1.BringToFront();
                textY2.BringToFront();
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
            }
        }
        private void textX1_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonPolar.Checked)
                textY1.Text = textX1.Text;
        }

        private void textY1_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonPolar.Checked)
                textX1.Text = textY1.Text;
        }

        private void textX2_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonPolar.Checked)
                textY2.Text = textX2.Text;
        }

        private void textY2_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonPolar.Checked)
                textX2.Text = textY2.Text;
        }

        private void textX_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonPolar.Checked)
                textY.Text = textX.Text;
        }

        private void textY_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonPolar.Checked)
                textX.Text = textY.Text;
        }
    }
}
