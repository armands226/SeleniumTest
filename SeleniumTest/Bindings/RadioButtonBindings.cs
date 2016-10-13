using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumTest.PageObjects;
using TechTalk.SpecFlow;

namespace SeleniumTest.Bindings
{
    [Binding]
    public sealed class RadioButtonBindings
    {

        [When(@"I click ""(.*)"" radio button")]
        public void WhenIClickElement(string button)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            page.WhatHasHappenedSection.WhatHappendRadioButtons.Click(button);
        }

        [Then(@"""(.*)"" radio button is selected")]
        public void ThenRadioButtonIsSelected(string button)
        {
            var selected = IsRadioButtonSelected(button);
            Assert.IsTrue(selected);

        }

        [Then(@"""(.*)"" radio button is unselected")]
        public void ThenRadioButtonIsUnselected(string button)
        {
            var selected = IsRadioButtonSelected(button);
            Assert.IsFalse(selected);

        }

        private bool IsRadioButtonSelected(string button)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            var selected = page.WhatHasHappenedSection.WhatHappendRadioButtons.IsSelected(button);
            Debug.WriteLine("-- '"  + button + "' selected = " + selected);
            return selected;

        }

    }
}
