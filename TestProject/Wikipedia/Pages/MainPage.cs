using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WikipediaTests.Wikipedia.Pages
{
    public class MainPage : WikipediaPage
    {

        private static readonly string URL = "https://en.wikipedia.org/wiki/Main_Page";
        private static readonly string ID_LOGO = "p-logo";
        private static readonly string XPATH_ARTS = "//a[contains(text(),'Arts')]";

        public MainPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait) {}

        public void Load() {
            driver.Navigate().GoToUrl(URL);
            wait.Until(driver => driver.FindElement(By.Id(ID_LOGO)));
        }

        public ArtPortalPage MoveToArts() {
            driver.FindElement(By.XPath(XPATH_ARTS)).Click();
            wait.Until(driver => driver.FindElement(By.XPath(ArtPortalPage.XPATH_TITLE)));
            return new ArtPortalPage(driver, wait);
        }
    }
}

