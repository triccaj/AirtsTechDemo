namespace AirtsTechDemo.Pages
{
    using AirtsTechDemo.Pages.Google;
    using OpenQA.Selenium;

    public class BasePage
    {
        private readonly IWebDriver driver;

        public Search Google;

        public BasePage(IWebDriver browser)
        {
            driver = browser;

            Google = new Search(driver);
        }
    }
}
