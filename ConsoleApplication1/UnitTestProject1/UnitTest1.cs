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
    }
}
