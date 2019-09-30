using NUnit.Framework;
using ConsoleApp4;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            Assert.AreEqual("It is Equilteral triangle", TriangleSolver.Analyze(5,5,5));
        }
        [Test]
        public void Test2()
        {

            Assert.AreEqual("Enter Valid Dimnesions", TriangleSolver.Analyze(0, 0, 0));
        }
        [Test]
        public void Test3()
        {

            Assert.AreEqual("It is Isosceles triangle", TriangleSolver.Analyze(15, 15, 16));
        }
        [Test]
        public void Test4()
        {

            Assert.AreEqual("Enter Valid Dimnesions", TriangleSolver.Analyze(-2, 2, 0));
        }
        [Test]
        public void Test5()
        {

            Assert.AreEqual("It is Scalene triangle", TriangleSolver.Analyze(2, 4, 5));
        }
        [Test]
        public void Test6()
        {

            Assert.AreEqual("It is Scalene triangle", TriangleSolver.Analyze(2, 3, 4));
        }
        [Test]
        public void Test7()
        {

            Assert.AreEqual("It is Isosceles triangle", TriangleSolver.Analyze(2, 2, 3));
        }
        [Test]
        public void Test8()
        {

            Assert.AreEqual("Enter Valid Dimnesions", TriangleSolver.Analyze(-2, -2, 0));
        }

    }
}