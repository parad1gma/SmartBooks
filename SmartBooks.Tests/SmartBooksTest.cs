using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SmartBooks.Tests
{
    [TestClass]
    public class SmartBooksTest
    {
        [TestInitialize]
        public void StartUp()
        {
            Driver.Initialize();

            LoginPage.GoTo();
            LoginPage.LoginAs("admin@gmail.com").WithPassword("123123").Login();
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Fina1ize();
        }
    }
}
