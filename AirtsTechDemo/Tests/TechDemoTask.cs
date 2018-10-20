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
            Google.SearchTextbox.EnterTextInTextbox("Airts");
            Google.SearchButton.TriggerClick();

            Google.Results.TopResultLink.VerifyText("Airts – Intelligent People Planning");
            Google.Results.TopResultLink.TriggerClick();

            Airts.AboutLink.VerifyVisible();
            actions.MoveToElement(Airts.AboutLink.GetElement());

            Airts.ValuesLink.VerifyVisible();
            Airts.ValuesLink.TriggerClick();
        }
    }
}
