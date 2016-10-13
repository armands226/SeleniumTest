using OpenQA.Selenium;

namespace SeleniumTest.PageObjects.BicycleClaimSections.WhatHasHappenedSection
{
    public class WhatHasHappenedSection
    {
        private static IWebDriver _driver;
        private static IWebElement _section;

        public WhatHasHappenedSection(IWebDriver driver)
        {
            _driver = driver;
            _section = _driver.FindElement(_sectionLocator);
        }

        private By _sectionLocator = By.Id("eventForm_section");
        private By _headerLocator = By.XPath("//*[contains(@class,'ecmt-details-summary iconbefore icon-arrowdown')]");

        public IWebElement Header
        {
            get
            {
                var element = _section.FindElement(_headerLocator);
                return element;
            }
        }

        public WhatHappendRadioButtons WhatHappendRadioButtons
        {
            get
            {
                //var element = _driver.FindElement(_whatHasHappenedSection);
                return new WhatHappendRadioButtons(_driver);
            }
        }
    }
}
