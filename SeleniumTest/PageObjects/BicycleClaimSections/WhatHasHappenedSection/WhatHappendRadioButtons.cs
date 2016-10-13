using System;
using OpenQA.Selenium;

namespace SeleniumTest.PageObjects.BicycleClaimSections.WhatHasHappenedSection
{
    public class WhatHappendRadioButtons
    {
        private static IWebDriver _driver;
        private static IWebElement _section;

        public WhatHappendRadioButtons(IWebDriver section)
        {
            _driver = section;
            _section = _driver.FindElement(_sectionLocator);
        }

        private By _sectionLocator = By.Id("eventForm_section");
        private By _bicycleStolenRbLocator = By.Id("eventTypeStolen");
        private By _bicycleVandalizedRbLocator = By.Id("eventTypeVandalized");
        private By _bicycleBrokenRbLocator = By.Id("eventTypeBroken");
        private By _bicycleDamagedRbLocator = By.Id("eventTypeDamaged");

        public void Click(string button)
        {
            _section.FindElement(GetLocator(button)).Click();
        }

        public bool IsSelected(string button)
        {
            return Selected(GetLocator(button));
        }

        private bool Selected(By locator)
        {

            var selected = false;
            var elementClass = _driver.FindElement(locator).FindElement(By.XPath("input")).GetAttribute("Class");
            if (elementClass.Contains("ng-valid-parse")) selected = true;

            return selected;
        }

        private By GetLocator(string button)
        {
            switch (button)
            {
                case "Bicycle or parts of it have been stolen": return _bicycleStolenRbLocator;
                case "Bicycle has been vandalized": return _bicycleVandalizedRbLocator;
                case "Bicycle has got broken": return _bicycleBrokenRbLocator;
                case "Bicycle has been damaged in a collision with a motor vehicle": return _bicycleDamagedRbLocator;
                default: throw new NotImplementedException("'" + button + "' button is not implemented in the code, contact responsible developer!");
            }
        }
    }
}
