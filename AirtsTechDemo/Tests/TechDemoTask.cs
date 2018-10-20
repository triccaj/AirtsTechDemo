namespace AirtsTechDemo.Tests
{
    using AirtsTechDemo.Classes;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TechDemoTask : BaseTestClass
    {
        [TestMethod]
        public void TechDemoTaskSteps()
        {
            Google.SearchTextbox.EnterTextInTextboxAndSubmit("Airts");

            Google.Results.TopResultLink.VerifyText("Airts – Intelligent People Planning");
            Google.Results.TopResultLink.TriggerClick();

            Airts.AboutLink.VerifyVisible();
            actions.MoveToElement(Airts.AboutLink.GetElement()).Build().Perform();

            Airts.ValuesLink.WaitForElementToBeVisible();
            Airts.ValuesLink.TriggerClick();

            Airts.ValuesPage.PermissionsToPlayTitle.VerifyText("PERMISSION TO PLAY");
            Airts.ValuesPage.SenseOfHumourTitle.VerifyText("Sense of Humour");
            Airts.ValuesPage.HumourCopy1.VerifyText("We’re not looking for");
            Airts.ValuesPage.FringeLink.VerifyText("Edinburgh Fringe’s");
            Airts.ValuesPage.HumourCopy3.VerifyText("next breakthrough act (although that would be awesome!), but if you can’t laugh at yourself, Airts isn’t the place for you.");
        }
    }
}
