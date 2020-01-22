using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WikipediaTests.Wikipedia.Pages
{
    public class AncientGreece : WikipediaPage
    {
        public static readonly string XPATH_TITLE = "//h1[contains(text(),'Ancient Greece')]";
        public AncientGreece(IWebDriver driver, WebDriverWait wait) : base(driver, wait) { }
    }
}
