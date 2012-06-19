using NUnit.Framework;
using TestApplication.Lib;

namespace TestApplication.Tests
{
    [TestFixture]
    public class TestUser
    {
        [Test]
        public void TestSayHello()
        {
            var user = new User(); 
            Assert.AreEqual("Hello, JCM", user.SayHello("JCM"));
        }
    }
}
