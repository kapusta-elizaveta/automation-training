using NUnit.Framework;
using Triangle;

namespace Tests
{
    public class Tests
    {
        
        public TriangleCheck tr = new TriangleCheck();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, tr.Cheking(9, 10, 6));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, tr.Cheking(9, 1, 6));
        }

        [Test]
        public void Test3()
        {
            Assert.AreNotEqual(false, tr.Cheking(9, 10, 6)); 
        }
        
        [Test]
        public void Test4()
        {
            Assert.AreNotEqual(true, tr.Cheking(9, 1, 6));
        }

        [Test]
        public void Test5()
        {
            Assert.IsFalse(tr.Cheking(9,1,6));
        }

        [Test]
        public void Test6()
        {
            Assert.IsTrue(tr.Cheking(9,10,6));
        }

        [Test]
        public void Test7()
        {
            Assert.That(tr.Cheking(9,6,10), Is.EqualTo(true));
        }

        [Test]
        public void Test8()
        {
            Assert.That(tr.Cheking(9,6,1), Is.EqualTo(false));
        }
        
        [Test]
        public void Test9()
        {
            Assert.True(tr.Cheking(9,6,10));
        }
        
        [Test]
        public void Test10()
        {
            Assert.False(tr.Cheking(9,6,1));
        }
    }
}