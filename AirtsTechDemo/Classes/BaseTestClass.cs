namespace AirtsTechDemo.Classes
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Chrome;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using AirtsTechDemo.Pages.Google;
    using AirtsTechDemo.Pages.Airts;

    [TestClass]
    public class BaseTestClass
    {
        public IWebDriver driver;
        private ChromeOptions Options;
        public Actions actions;

        public Search Google;

        public HomePage Airts;

        [TestInitialize]
        public void SetUp()
        {
            Options = new ChromeOptions();
            Options.AddArgument("start-maximized");

            driver = new ChromeDriver(Options);

            actions = new Actions(driver);

            Google = new Search(driver);

            Airts = new HomePage(driver);

            driver.Url = "https://google.co.uk/";

            driver.Navigate();
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
