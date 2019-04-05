using NUnit.Framework;

namespace PadawansTask1.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [Test]
        public void GetYearsTest_With_Result_15()
        {
            Assert.AreEqual(Population.GetYears(1500, 5, 100, 5000), 15);
        }
    }
}