using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAttributes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Owner("Ömer")]
        [TestCategory("Tester")]
        [Priority(1)]
        [TestProperty("Günceleyen", "Engin")]
        public void TestMethod1()
        {
            Assert.AreEqual(1,1);
        }

        [TestMethod]
        [Owner("Ömer")]
        [TestCategory("Tester")]
        [Priority(1)]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        [Owner("Ali")]
        [TestCategory("Developer")]
        [Priority(2)]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        [Owner("Ali")]
        [Priority(4)]
        [TestCategory("Developer")]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        [Owner("Hande")]
        [Priority(3)]
        [TestCategory("Developer")]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
