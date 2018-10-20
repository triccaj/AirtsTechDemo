namespace AirtsTechDemo.Classes
{
    using System;
    using System.Threading;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;

    public class Selector
    {
        public string Locator;

        private readonly IWebDriver driver;

        private readonly IWebElement element;

        public Selector(IWebDriver browser, string locator)
        {
            driver = browser;
            Locator = locator;
            element = driver.FindElement(By.CssSelector(locator));
        }

        /// <summary>
        /// Clear the text box and then enters the text you pass in to the _element you pass in
        /// </summary>
        /// <param name="textToInput">What you wish to type</param>
        public void ClearAndEnterTextInTextbox(string textToInput)
        {
            element.Clear();
            element.SendKeys(textToInput);
        }

        /// <summary>
        ///     Clears the text from the _element you pass in - only use this on textboxes
        /// </summary>
        public void ClearTextbox()
        {
            element.Clear();
        }

        /// <summary>
        ///     Enters the text you pass in to the _element you pass in
        /// </summary>
        /// <param name="textToInput">What you wish to type</param>
        public void EnterTextInTextbox(string textToInput)
        {
            element.SendKeys(textToInput);
        }

        /// <summary>
        ///     Enters the text you pass in to the _element you pass in
        /// </summary>
        /// <param name="textToInput">What you wish to type</param>
        public void EnterTextInTextboxAndSubmit(string textToInput)
        {
            element.SendKeys(textToInput + Keys.Enter);
        }

        public IWebElement GetElement()
        {
            return element;
        }

        /// <summary>
        ///     Returns you the string at the locator you pass in
        /// </summary>
        /// <returns>The string at the locator you pass in</returns>
        public string GetTextInTextbox()
        {
            var returnText = element.GetAttribute("value");
            return returnText;
        }

        /// <summary>
        ///     Pauses the test and lets you give a reason for the pause - try to use the WaitUntil helpers instead if possible
        /// </summary>
        /// <param name="timeInSeconds">How long to pause for</param>
        /// <param name="reason">Why you need an explicit pause</param>
        public void PauseTest(int timeInSeconds, string reason)
        {
            var time = timeInSeconds * 1000;
            Thread.Sleep(time);
            Console.WriteLine($"Test paused for {timeInSeconds}s for the following reason: {reason}");
        }

        /// <summary>
        ///     This method clicks the _element you pass in
        /// </summary>
        public void TriggerClick()
        {
            element.Click();
        }

        /// <summary>
        ///     Verfies that the passed in checkbox _element is checked
        /// </summary>
        public void VerifyChecked()
        {
            Assert.IsTrue(element.Selected);
        }

        /// <summary>
        ///     This should only be used in tables where the rows are tr children of the table _element
        ///     TODO work out how to build the selector in a fashion that this can apply to any _element
        /// </summary>
        /// <param name="expectedNumber">Pass in your predicted result</param>
        public void VerifyCount(int expectedNumber)
        {
            Assert.AreEqual(element.FindElements(By.CssSelector("tr")).Count, expectedNumber);
        }

        /// <summary>
        ///     Verifies that the href embedded link in the _element you pass in is as you assert
        /// </summary>
        /// <param name="expected">The URL you are expecting</param>
        public void VerifyEmbeddedUrl(string expected)
        {
            Assert.AreEqual(expected, element.GetAttribute("hRef"));
        }

        /// <summary>
        ///     Verifies that the href embedded link you pass in is as you assert
        /// </summary>
        /// <param name="expected">The Source URL you are expecting</param>
        public void VerifyImageSource(string expected)
        {
            Assert.AreEqual(expected, element.GetAttribute("src"));
        }

        /// <summary>
        ///     Verfies that the passed in checkbox _element is not checked
        /// </summary>
        public void VerifyNotChecked()
        {
            Assert.IsTrue(!element.Selected);
        }

        /// <summary>
        ///     Verifies that the _element you passed in has a value of Displayed = False
        /// </summary>
        public void VerifyNotVisible()
        {
            Assert.IsTrue(!element.Displayed);
        }

        /// <summary>
        ///     Verifies that the _element you passed in contains the text you assert
        /// </summary>
        /// <param name="expected">The Text you are expecting</param>
        public void VerifyText(string expected)
        {
            Assert.AreEqual(expected, element.Text);
        }

        /// <summary>
        ///     Verifies that the text you passed in contains the text you assert
        ///     Useful when getting text out of a text box
        /// </summary>
        /// <param name="elementText">The actual string</param>
        /// <param name="expected">The expected string</param>
        public void VerifyText(string elementText, string expected)
        {
            Assert.AreEqual(expected, elementText);
        }

        /// <summary>
        ///     Verifies that the _element you passed in contains the text you assert
        /// </summary>
        /// <param name="expected">Expected text within the textbox</param>
        public void VerifyTextInTextbox(string expected)
        {
            Assert.AreEqual(expected, element.GetAttribute("value"));
        }

        /// <summary>
        ///     Verifies that the _element you passed in has a value of Displayed = True
        /// </summary>
        public void VerifyVisible()
        {
            Assert.IsTrue(element.Displayed);
        }
    }
}