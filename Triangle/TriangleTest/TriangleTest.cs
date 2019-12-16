using System;
using NUnit.Framework;
using Triangle;

namespace Tests
{
    public class Tests
    {
        
        public TriangleCheck triangle = new TriangleCheck();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EnterNegative()
        {
            Assert.Throws<TriangleException>(() => triangle.Cheking(-1, 3, 6));
        }
        
        [Test]
        public void AllZeroSides()
        {
            Assert.Throws<TriangleException>(() => triangle.Cheking(0, 0, 0));
        }

        [Test]
        public void EquilateralTriangle()
        {
            Assert.AreEqual(true, triangle.Cheking(9, 10, 6));
        }

        [Test]
        public void SumOfTwoSidesEqualsThird()
        {
            Assert.AreEqual(false, triangle.Cheking(9, 1, 10));
        }

        [Test]
        public void OneZeroSide()
        {
            Assert.Throws<TriangleException>(() => triangle.Cheking(10, 0, 10));
        }
        
        [Test]
        public void IsoscelesTriangle()
        {
            Assert.IsFalse(triangle.Cheking(9,1,6));
        }

        [Test]
        public void RightTriangle()
        {
            Assert.IsTrue(triangle.Cheking(9,10,6));
        }

        [Test]
        public void TrueTriangle()
        {
            Assert.That(triangle.Cheking(9,6,10), Is.EqualTo(true));
        }

        [Test]
        public void AllOfTheSideIsMaxInt()
        {
            Assert.That(triangle.Cheking(int.MaxValue,int.MaxValue,int.MaxValue), Is.EqualTo(false));
        }
        
        
        [Test]
        public void OneOfTheSideIsMaxInt()
        {
            Assert.False(triangle.Cheking(int.MaxValue,6,1));
        }
    }
}