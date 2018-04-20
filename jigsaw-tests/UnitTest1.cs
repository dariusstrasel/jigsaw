using NUnit.Framework;

namespace JigsawTests
{
    [TestFixture]
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }
        [TearDown]
        public void Teardown()
        {
        }
        [Test]
        public void Test()
        {
            Assert.AreEqual(1,1);
        }
    }
}
