using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SmartBooks.Tests
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);
        }

        public static LoginCommand LoginAs(string username)
        {
            return new LoginCommand(username);
        }
    }

    public class LoginCommand
    {
        private string username;
        private string password;


        public LoginCommand(string username)
        {
            this.username = username;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var loginLink = Driver.Instance.FindElement(By.Id("loginLink"));
            loginLink.Click();

            var inputEmail = Driver.Instance.FindElement(By.Id("Email"));
            inputEmail.Clear();
            inputEmail.SendKeys("admin@gmail.com");

            var inputPassword = Driver.Instance.FindElement(By.Id("Password"));
            inputPassword.Clear();
            inputPassword.SendKeys("123123");

            var loginButton = Driver.Instance.FindElement(By.CssSelector("input.btn.btn-info"));
            loginButton.Click();

            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.StalenessOf(loginButton));
        }
    }
}