using OpenQA.Selenium;
using SeleniumTest.PageObjects.BicycleClaimSections.PleaseGiveTHePersonalDetailsSection;
using SeleniumTest.PageObjects.BicycleClaimSections.WhatHasHappenedSection;
using SeleniumTest.PageObjects.BicycleClaimSections.WhatItemTheLossConcernsSection;

namespace SeleniumTest.PageObjects
{
    public class BicycleClaimPage
    {
        private static IWebDriver _driver;

        public BicycleClaimPage(IWebDriver driver) { _driver = driver; }

        private By _header = By.TagName("h2");
        private By _iHaveFilledInAllTheNecessary = By.Id("toggleReviewed");
        private By _sendButton = By.Id("sendClaimButton");
        private By _abortButton = By.Id("cancelButton");
        
        public IWebElement Header
        {
            get
            {
                var element = _driver.FindElement(_header);
                return element;
            }
        }

        public IWebElement Checkbox
        {
            get
            {
                var element = _driver.FindElement(_iHaveFilledInAllTheNecessary);
                return element;
            }
        }

        public IWebElement SendButton
        {
            get
            {
                var element = _driver.FindElement(_sendButton);
                return element;
            }
        }

        public IWebElement AbortButton
        {
            get
            {
                var element = _driver.FindElement(_abortButton);
                return element;
            }
        }

        public void ClickIHaveFilledInCheckbox()
        {
            _driver.FindElement(_iHaveFilledInAllTheNecessary).Click();
        }


        public PleaseGiveThePersonalDetailsSection PleaseGiveThePersonalDetails
        {
            get
            {
                //var element = _driver.FindElement(_whatHasHappenedSection);
                return new PleaseGiveThePersonalDetailsSection(_driver);
            }
        }
        
        public WhatHasHappenedSection WhatHasHappenedSection
        {
            get
            {
                //var element = _driver.FindElement(_whatHasHappenedSection);
                return new WhatHasHappenedSection(_driver);
            }
        }

        public WhatItemTheLossConcernsSection WhatItemTheLossConcernsSection
        {
            get
            {
                //var element = _driver.FindElement(_whatHasHappenedSection);
                return new WhatItemTheLossConcernsSection(_driver);
            }
        }
    }
}
