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
    class PolarComplexNumberTests
    {
        [Test]
        public void MultiplicationTest()
        {
            PolarComplexNumber num1 = new PolarComplexNumber(10, 10);
            PolarComplexNumber num2 = new PolarComplexNumber(2, 3);

            PolarComplexNumber expected = new PolarComplexNumber(12, 30);
            PolarComplexNumber actual = num1 * num2;

            expected.Should().BeEquivalentTo(actual);
        }

        [Test]
        public void DivisionTest()
        {
            PolarComplexNumber num1 = new PolarComplexNumber(10, 10);
            PolarComplexNumber num2 = new PolarComplexNumber(3, 2);

            PolarComplexNumber expected = new PolarComplexNumber(7, 5);
            PolarComplexNumber actual = num1 / num2;

            expected.Should().BeEquivalentTo(actual);
        }

        [Test]
        public void ArgCount1Test()
        {
            ComplexNumber num = new ComplexNumber(10, 5);
            PolarComplexNumber polNum = new PolarComplexNumber();
            polNum = num.ConvertToPolar();
            double expected =  Math.Atan(5 / 10.0);
            double actual = polNum.Arg;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArgCount2Test()
        {
            ComplexNumber num = new ComplexNumber(10, -5);
            PolarComplexNumber polNum = new PolarComplexNumber();
            polNum = num.ConvertToPolar();
            double expected = -Math.Atan(-5 / 10.0);
            double actual = polNum.Arg;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArgCount3Test()
        {
            ComplexNumber num = new ComplexNumber(-10, 5);
            PolarComplexNumber polNum = new PolarComplexNumber();
            polNum = num.ConvertToPolar();
            double expected = Math.PI - Math.Atan(5 / -10.0);
            double actual = polNum.Arg;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArgCount4Test()
        {
            ComplexNumber num = new ComplexNumber(-10, -5);
            PolarComplexNumber polNum = new PolarComplexNumber();
            polNum = num.ConvertToPolar();
            double expected = - Math.PI + Math.Atan(-5 / -10.0);
            double actual = polNum.Arg;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArgCount5Test()
        {
            ComplexNumber num = new ComplexNumber(0, 5);
            PolarComplexNumber polNum = new PolarComplexNumber();
            polNum = num.ConvertToPolar();
            double expected = Math.PI / 2;
            double actual = polNum.Arg;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArgCount6Test()
        {
            ComplexNumber num = new ComplexNumber(0, -5);
            PolarComplexNumber polNum = new PolarComplexNumber();
            polNum = num.ConvertToPolar();
            double expected = -Math.PI / 2;
            double actual = polNum.Arg;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArgCount7Test()
        {
            ComplexNumber num = new ComplexNumber(10, 0);
            PolarComplexNumber polNum = new PolarComplexNumber();
            polNum = num.ConvertToPolar();
            double expected = 0;
            double actual = polNum.Arg;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArgCount8Test()
        {
            ComplexNumber num = new ComplexNumber(-10, 0);
            PolarComplexNumber polNum = new PolarComplexNumber();
            polNum = num.ConvertToPolar();
            double expected = Math.PI;
            double actual = polNum.ArgCount();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConvertToDekartTest()
        {
            PolarComplexNumber num = new PolarComplexNumber((2 * Math.PI) / 3, 206);
            ComplexNumber expected = new ComplexNumber(-102.99999999999996, 178.40123317959439);
            ComplexNumber actual = new ComplexNumber();

            actual = num.ConvertToDekart();

            expected.Should().BeEquivalentTo(actual);
        }

        [Test]
        public void ExponentiationTest()
        {
            PolarComplexNumber actual = new PolarComplexNumber(10, 5);
            int n = 4;
            PolarComplexNumber expected = new PolarComplexNumber(40, 625);

            actual = actual.Exponentiation(n);

            expected.Should().BeEquivalentTo(actual);
        }

        [Test]
        public void RootingTest()
        {
            List<PolarComplexNumber> expected = new List<PolarComplexNumber>();
            PolarComplexNumber num = new PolarComplexNumber(10, 5);
            int n = 3;
            expected.Add(new PolarComplexNumber(10 / 3.0, Math.Pow(5, 1 / 3.0)));
            expected.Add(new PolarComplexNumber((10 + 2 * Math.PI) / 3.0, Math.Pow(5, 1 / 3.0)));
            expected.Add(new PolarComplexNumber((10 + 4 * Math.PI)/ 3.0, Math.Pow(5, 1 / 3.0)));

            List<PolarComplexNumber> actual = num.Rooting(n);

            expected.Should().BeEquivalentTo(actual);
        }
    }
}
