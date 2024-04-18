namespace Asjc.Extensions.Tests
{
    [TestClass]
    public class ObjectExtensionsTests
    {
        [TestMethod]
        public void ChangeTypeTest()
        {
            string s = "1";
            int i = (int)s.ChangeType(typeof(int));
            Assert.AreEqual(1, i);
        }
    }
}