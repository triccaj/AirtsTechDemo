namespace AirtsTechDemo.Pages.Google
{
    using AirtsTechDemo.Classes;
    using OpenQA.Selenium;

    public class Search
    {
        private readonly IWebDriver driver;

        public Results Results;

        public Search(IWebDriver browser)
        {
            driver = browser;
            Results = new Results(driver);
        }

        public Selector SearchTextbox => new Selector(driver, "#lst-ib");

        public Selector SearchButton => new Selector(driver, "#tsf > div.tsf-p > div.jsb > center > input[type=\"submit\"]:nth-child(1)");
    }
}
