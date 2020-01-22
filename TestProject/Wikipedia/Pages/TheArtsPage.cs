using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WikipediaTests.Wikipedia.Pages
{
    public class TheArtsPage : WikipediaPage
    {
        public static readonly string XPATH_TITLE = "//h1[contains(text(),'The arts')]";

        public TheArtsPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait) {}
    }
}
