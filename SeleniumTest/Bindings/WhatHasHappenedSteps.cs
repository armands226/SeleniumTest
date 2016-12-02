using OpenQA.Selenium;
using SeleniumTest.Models;
using SeleniumTest.PageObjects;
using SeleniumTest.PageObjects.BicycleClaimSections.WhatHasHappenedSection;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumTest.Bindings
{
    [Binding]
    class WhatHasHappenedSteps
    {
        [Given(@"I have opened bicycle claim")]
        public void GivenIHaveOpenedBicycleClaim()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter the following data into the what has happened section")]
        public void WhenIEnterTheFollowingDataIntoTheWhatHasHappenedSection(Table table)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>(); // in each step?? move to hooks?
            var page = new BicycleClaimPage(driver);// The same here

            var whatHasHappened = table.CreateInstance<WhatHasHappenedModel>();
            page.WhatHasHappenedSection.WhatHappendRadioButtons.Click(whatHasHappened.IncidentType);
            page.WhatHasHappenedSection.WhenDidTheIncidentHappen.SetIncidentDate(whatHasHappened.IncidentDate.ToString());
            page.WhatHasHappenedSection.WhereDidTheIncidentHappen
                .SelectCountry(whatHasHappened.IncidentCountry)
                .SelectStolenCityText(whatHasHappened.IncidentCity)
                .EnterStolenStreetText(whatHasHappened.IncidentPlace);
        }

        [Then(@"everything is ok")]
        public void ThenEverythingIsOk()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
