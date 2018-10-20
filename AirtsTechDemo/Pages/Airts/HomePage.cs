namespace AirtsTechDemo.Pages.Airts
{
    using AirtsTechDemo.Classes;
    using OpenQA.Selenium;

    public class HomePage
    {
        private IWebDriver driver;

        public Values ValuesPage;

        public HomePage(IWebDriver browser)
        {
            driver = browser;

            ValuesPage = new Values(driver);
        }

        public Selector AboutLink => new Selector(driver, "#menu-item-35 > a");

        public Selector ValuesLink => new Selector(driver, "#menu-item-11135 > a");
    }
}
