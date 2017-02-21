using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CatTestMethod()
        {
            Cat cat = new Cat();
            cat.Age = 20;

            Assert.AreEqual(cat.ReturnAge(), 20);
        }

        [TestMethod]
        public void CatTestMethod2()
        {
            Cat cat = new Cat();

            Assert.AreEqual(cat.Age, 0);
        }

        [TestMethod]
        public void CatTestMethod3()
        {
            Assert.AreEqual(0, 0);
        }
    }
}
