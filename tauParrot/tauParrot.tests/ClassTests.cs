using NUnit.Framework;

namespace tauParrot.tests
{
    public class ClassTests
    {
        [Test]
        public void ShouldPass()
        {
            Assert.Pass("should pass");
        }

        [Test]
        public void ShouldFail()
        {
            Assert.Fail("should fail");
        }
    }
}
