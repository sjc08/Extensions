namespace Asjc.Extensions.Tests
{
    [TestClass]
    public class ObjectExtensionsTests
    {
        [TestMethod]
        public void ConvertToTest1()
        {
            Assert.IsTrue("1".ConvertTo(typeof(int), out var result));
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void ConvertToTest2()
        {
            Assert.IsFalse("A".ConvertTo(typeof(int), out var result));
            Assert.AreEqual(result, null);
        }

        [TestMethod]
        public void ConvertToTest3()
        {
            object? obj = null;
            Assert.IsFalse(obj.ConvertTo(typeof(int), out var result));
            Assert.AreEqual(result, null);
        }

        [TestMethod]
        public void ConvertToTest4()
        {
            object? obj = null;
            Assert.IsTrue(obj.ConvertTo(typeof(string), out var result));
            Assert.AreEqual(result, null);
        }
    }
}