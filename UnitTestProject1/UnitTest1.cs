using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest.Project
{
    [TestClass]
    public class ByAlphabeticalOrder
    {
        public static bool TestACalled;
        public static bool TestaCalled;
        public static bool TestbCalled;

        [TestMethod]
        public void Testa()
        {
            TestaCalled = true;

            Assert.IsTrue(TestACalled);
            Assert.IsFalse(TestbCalled);
        }

        [TestMethod]
        public void TestA()
        {
            TestACalled = true;

            Assert.IsFalse(TestaCalled);
            Assert.IsFalse(TestbCalled);
        }

        [TestMethod]
        public void Testb()
        {
            TestbCalled = true;

            Assert.IsTrue(TestACalled);
            Assert.IsTrue(TestaCalled);
        }
    }
}