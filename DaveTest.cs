using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace webdriverdotnet
{
    [TestClass]
    public class DaveTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("David Rosskopf" + Keys.Enter);

            Home home = new Home(driver);
            home.Search.SendKeys("David Rosskopf" + Keys.Enter);
            driver.Quit();
        }

    }
}
