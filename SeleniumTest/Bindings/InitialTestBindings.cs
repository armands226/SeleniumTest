using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumTest.PageObjects;
using TechTalk.SpecFlow;

namespace SeleniumTest.Bindings
{
    [Binding]
    public sealed class InitialTestBindings
    {
        [Given(@"I have opened ""(.*)"" page")]
        public void NavigateToUrl(string url)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings[url]);
        }

        [Then(@"page header is visible")]
        public void ThenPageHeaderIsVisible()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            var pageElement = page.Header;
            Assert.IsNotNull(pageElement);
        }


        [Then("search page should be visible")]
        public void SearchPageIsVisible()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            var element = page.Header;
            Assert.IsNotNull(element);
        }

        [Then(@"section 1/3 header is visible")]
        public void ThenSection1OutOf3HeaderIsVisible()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            var element = page.WhatHasHappenedSection.Header;
            Assert.IsNotNull(element);
        }

        [Then(@"section 2/3 header is visible")]
        public void ThenSection2OutOf3HeaderIsVisible()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            var element = page.WhatItemTheLossConcernsSection.Header;
            Assert.IsNotNull(element);
        }

        [Then(@"section 3/3 header is visible")]
        public void ThenSection3OutOf3HeaderIsVisible()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            var element = page.PleaseGiveThePersonalDetails.Header;
            Assert.IsNotNull(element);
        }

        [Then(@"checkbox is visible")]
        public void WhenCheckboxIsVisible()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            var element = page.Checkbox;
            Assert.IsNotNull(element);
        }

        [Then(@"Send button is visible")]
        public void ThenSendButtonIsVisible()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            var element = page.SendButton;
            Assert.IsNotNull(element);
        }

        [Then(@"Abort button is visible")]
        public void ThenAbortButtonIsVisible()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            var element = page.AbortButton;
            Assert.IsNotNull(element);
        }
    }
}
