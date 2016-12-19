using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.ComponentModel;
using System.Threading;

namespace SmartBooks.Tests
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static string BaseAddress
        {
            get { return "http://admin.smartbooks.biz/"; }
        }

        public static void Initialize()
        {
            Instance = DriverFactory(DriverType.Chrome);
            TurnOnWait();
        }

        public static void Fina1ize()
        {
            Instance.Quit();
        }

        internal static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)timeSpan.TotalSeconds * 1000);
        }

        private static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        private static void TurnOffWait()
        {
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));
        }

        private static IWebDriver DriverFactory(DriverType driverType)
        {
            switch (driverType)
            {
                case DriverType.Firefox:
                    return new FirefoxDriver();
                case DriverType.Chrome:
                    return new ChromeDriver();
                case DriverType.Edge:
                    return new EdgeDriver();
                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        public enum DriverType
        {
            Firefox,
            Chrome,
            Edge
        }
    }


}