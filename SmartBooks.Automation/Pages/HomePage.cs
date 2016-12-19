using OpenQA.Selenium;

namespace SmartBooks.Tests.Tests
{
    public class HomePage
    {
        public static bool IsAt
        {
            get
            {
                var h1 = Driver.Instance.FindElement(By.CssSelector("h1"));
                if (h1 != null)
                    return h1.Text == "Smart Books";
                return false;

            }
        }
    }
}