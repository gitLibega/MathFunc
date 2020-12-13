using NUnit.Framework;
using MathFunc;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        MathC mathFunc;
        Expression expression;

        [SetUp]
        public void InitTest()
        {
            mathFunc = new MathC();
            expression = new Expression();
        }
        public void TestSin()
        {
            var x = -10;
            var actual = mathFunc.Sin(x);
            var expected = System.Math.Sin(x);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        public void TestCos()
        {
            var x = 10;
            var actual = mathFunc.Cos(x);
            var exp = System.Math.Cos(x);

            Assert.AreEqual(exp, actual, 0.01);
        }




        [Test]
        public void TestCSC()
        {
            var x = 10;
            var actual = mathFunc.Csc(x);
            var exp = 1 / System.Math.Sin(x);

            Assert.AreEqual(exp, actual, 0.01);
        }



        [Test]
        public void TestLn1()
        {
            var x = 1;
            var actual = mathFunc.Ln(x);
            var expected = System.Math.Log(x);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestLn10()
        {
            var x = 10;
            var actual = mathFunc.Ln(x);
            var expected = System.Math.Log(x);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        public void TestLog()
        {
            var x = 16;
            var newBase = 3;

            var actual = mathFunc.Log(x, newBase);
            var expected = System.Math.Log(x, newBase);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        public void TestExp()
        {
            var x = 16;

            var actual = mathFunc.Exp(x);
            var expected = System.Math.Exp(x);

            Assert.AreEqual(expected, actual, 0.01);
        }


        [Test]
        public void TestPow()
        {
            var x = 10;
            var radix = 15;

            var actual = mathFunc.Pow(x, radix);
            var expected = System.Math.Pow(x, radix);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        public void TestNegativeAbs()
        {
            var x = -10;

            var actual = MathC.Abs(x);
            var expected = System.Math.Abs(x);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestPositiveAbs()
        {
            var x = 15;

            var actual = MathC.Abs(x);
            var expected = System.Math.Abs(x);

            Assert.AreEqual(expected, actual);
        }
       
      
            [Test]
            public void TestNegativeAndNull()
            {
            Assert.AreEqual(131805.63, expression.Calc(-3), 0.1);
            Assert.AreEqual(9.9364584255675883E+65d, expression.Calc(-83.3), 0.01);
            Assert.AreEqual(8.9, expression.Calc(-Math.PI / 2), 0.1);
            Assert.AreEqual(13.75, expression.Calc(-1), 0.1);
            Assert.AreEqual(Double.PositiveInfinity, expression.Calc(0), 0.1);


        }
            [Test]
            public void TestPositive()
		{
			
                Assert.AreEqual(13.9, expression.Calc(3),0.1);
            Assert.AreEqual(28148.27, expression.Calc(83.3), 0.01);
            Assert.AreEqual(0.21, expression.Calc(Math.PI / 2), 0.1);
            Assert.AreEqual(Double.NaN, expression.Calc(1), 0.1);



        }
        }
    }

