using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WikipediaTests.Wikipedia.Pages
{
    public class AncientGreecePage : WikipediaPage
    {
        public static readonly string XPATH_TITLE = "//h1[contains(text(),'Ancient Greece')]";
        public AncientGreecePage(IWebDriver driver, WebDriverWait wait) : base(driver, wait) { }
    }
}
