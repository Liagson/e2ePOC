using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WikipediaTests.Wikipedia
{
    public abstract class WikipediaPage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        private static readonly string XPATH_SEARCH = "//input[@name = 'search']";

        public WikipediaPage(IWebDriver driver, WebDriverWait wait) {
            this.driver = driver;
            this.wait = wait;
        }

        public void Search(string search) {
            IWebElement searchBar = driver.FindElement(By.XPath(XPATH_SEARCH));
            searchBar.Click();
            searchBar.SendKeys(search);
            searchBar.SendKeys(Keys.Return);
        }
    }
}
