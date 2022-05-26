using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ComplexNumbers;
using FluentAssertions;

namespace ComplexNumbersTests
{
    [TestFixture]
    public class ComplexNumberTests
    {
        [Test]
        public void PlusTest()
        {
            ComplexNumber num1 = new ComplexNumber(10, 10);
            ComplexNumber num2 = new ComplexNumber(10.5, 10.5);

            ComplexNumber expected = new ComplexNumber(20.5, 20.5);
            ComplexNumber actual = num1 + num2;

            expected.Should().BeEquivalentTo(actual);
        }

        [Test]
        public void MinusTest()
        {
            ComplexNumber num1 = new ComplexNumber(10, 10);
            ComplexNumber num2 = new ComplexNumber(2, 3);

            ComplexNumber expected = new ComplexNumber(8, 7);
            ComplexNumber actual = num1 - num2;

            expected.Should().BeEquivalentTo(actual);
        }

        [Test]
        public void MultiplicationTest()
        {
            ComplexNumber num1 = new ComplexNumber(10, 10);
            ComplexNumber num2 = new ComplexNumber(2, 3);

            ComplexNumber expected = new ComplexNumber(-10, 50);
            ComplexNumber actual = num1 * num2;

            expected.Should().BeEquivalentTo(actual);
        }

        [Test]
        public void DivisionTest()
        {
            ComplexNumber num1 = new ComplexNumber(10, 10);
            ComplexNumber num2 = new ComplexNumber(5, 5);

            ComplexNumber expected = new ComplexNumber(2, 0);
            ComplexNumber actual = num1 / num2;

            expected.Should().BeEquivalentTo(actual);
        }

        [Test]
        public void ModuleTest()
        {
            ComplexNumber num = new ComplexNumber(2, 3);
            
            double expected = 3.6055512754639892931192212674705;
            double actual = num.Module();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertToDekartTest()
        {
            PolarComplexNumber num = new PolarComplexNumber((2 * Math.PI) / 3, 206);

            ComplexNumber expected = new ComplexNumber(-102.99999999999996, 178.40123317959439);
            ComplexNumber actual = new ComplexNumber(num);
            actual = actual.ConvertToDekart();

            expected.Should().BeEquivalentTo(actual);
        }
    }
}
