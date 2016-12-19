using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SmartBooks.Tests.Tests
{
    [TestClass]
    public class LoginTests : SmartBooksTest
    {
        [TestMethod]
        public void AdminUserCanLogin()
        {
            Assert.IsTrue(HomePage.IsAt, "Failed to login.");
        }
    }
}
