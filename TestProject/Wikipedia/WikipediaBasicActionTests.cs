using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WikipediaTests.Wikipedia.Pages;

namespace WikipediaTests

{
    [TestClass]
    public class WikipediaBasicActionTests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [TestInitialize]
        public void Initialize() {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver,
                TimeSpan.FromSeconds(Constants.STANDARD_WAIT_TIME));
        }

        [TestMethod]
        public void LearnAboutTheArts() {
            MainPage wikipediaMain = new MainPage(driver, wait);
            wikipediaMain.Load();

            ArtPortalPage wikipediaArtPage = wikipediaMain.MoveToArts();
            TheArtsPage wikipediaTheArtsPage = wikipediaArtPage.MoveToTheArts();
        }

        [TestMethod]
        public void SearchGreece() {
            MainPage wikipediaMain = new MainPage(driver, wait);
            wikipediaMain.Load();

            ArtPortalPage wikipediaArtPage = wikipediaMain.MoveToArts();
            wikipediaArtPage.Search("Ancient Greece");

            IWebElement searchResult = driver.FindElement(By.XPath(AncientGreece.XPATH_TITLE));
        }


        [TestCleanup]
        public void Clean() {
            Thread.Sleep(Constants.DEMO_VIEW_TIME); // Only for viewing purposes
            driver.Close();
        }

    }
}
