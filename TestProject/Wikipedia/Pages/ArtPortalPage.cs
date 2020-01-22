using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WikipediaTests.Wikipedia.Pages
{
    public class ArtPortalPage : WikipediaPage
    {

        public static readonly string XPATH_TITLE = "//h1[contains(text(),'Portal:Arts')]";
        public static readonly string XPATH_THE_ARTS_ANCHOR = "//a[contains(@title, 'The arts') and contains(text(), 'The arts')]";

        public ArtPortalPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait) {}

        public TheArtsPage MoveToTheArts() {
            driver.FindElement(By.XPath(XPATH_THE_ARTS_ANCHOR)).Click();
            wait.Until(driver => driver.FindElement(By.XPath(TheArtsPage.XPATH_TITLE)));
            return new TheArtsPage(driver, wait);
        }
    }
}
