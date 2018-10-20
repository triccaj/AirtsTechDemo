namespace AirtsTechDemo.Pages.Google
{
    using AirtsTechDemo.Classes;
    using OpenQA.Selenium;

    public class Results
    {
        private readonly IWebDriver driver;

        public Results(IWebDriver browser)
        {
            driver = browser;
        }

        public Selector TopResultLink => new Selector(driver, "#rso > div:nth-child(1) > div > div > div > div > div.r > a > h3");
    }
}
