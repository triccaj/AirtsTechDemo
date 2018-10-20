namespace AirtsTechDemo.Pages.Airts
{
    using AirtsTechDemo.Classes;
    using OpenQA.Selenium;

    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver browser)
        {
            driver = browser;
        }

        public Selector AboutLink => new Selector(driver, "#menu-item-35 > a");

        public Selector ValuesLink => new Selector(driver, "#menu-item-11135 > a");
    }
}
