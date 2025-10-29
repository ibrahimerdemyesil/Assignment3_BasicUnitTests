using NUnit.Framework;
using System;

namespace Assignment3Task2.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void TestAddition()
        {
            Calculator calc = new Calculator(10, 5, '+');
            Assert.That(calc.Calculate(), Is.EqualTo(15));
        }

        [Test]
        public void TestSubtraction()
        {
            Calculator calc = new Calculator(10, 5, '-');
            Assert.That(calc.Calculate(), Is.EqualTo(5));
        }

        [Test]
        public void TestMultiplication()
        {
            Calculator calc = new Calculator(10, 5, '*');
            Assert.That(calc.Calculate(), Is.EqualTo(50));
        }

        [Test]
        public void TestDivision()
        {
            Calculator calc = new Calculator(10, 5, '/');
            Assert.That(calc.Calculate(), Is.EqualTo(2));
        }

        [Test]
        public void TestDivisionByZero()
        {
            Calculator calc = new Calculator(10, 0, '/');
            Assert.Throws<DivideByZeroException>(() => calc.Calculate());
        }

        [Test]
        public void TestInvalidOperation()
        {
            Calculator calc = new Calculator(10, 5, '%');
            Assert.Throws<InvalidOperationException>(() => calc.Calculate());
        }
    }
}