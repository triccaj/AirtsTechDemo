using AirtsTechDemo.Classes;
using OpenQA.Selenium;

namespace AirtsTechDemo.Pages.Airts
{
    public class Values
    {
        private IWebDriver driver;

        public Values(IWebDriver browser)
        {
            driver = browser;
        }

        public Selector PermissionsToPlayTitle => new Selector(driver, "#panel-11038-0-0-4 > div > div > div > h1");

        public Selector SenseOfHumourTitle => new Selector(driver, "#panel-11038-0-0-5 > div > div > div > h2:nth-child(7) > b");

        public Selector HumourCopy1 => new Selector(driver, "#panel-11038-0-0-5 > div > div > div > p:nth-child(8) > span:nth-child(1)");

        public Selector FringeLink => new Selector(driver, "#panel-11038-0-0-5 > div > div > div > p:nth-child(8) > a > span");

        public Selector HumourCopy3 => new Selector(driver, "#panel-11038-0-0-5 > div > div > div > p:nth-child(8) > span:nth-child(3)");
    }
}
