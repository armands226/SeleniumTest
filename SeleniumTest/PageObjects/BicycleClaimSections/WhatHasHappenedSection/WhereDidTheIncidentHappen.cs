using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest.PageObjects.BicycleClaimSections.WhatHasHappenedSection
{
    public class WhereDidTheIncidentHappen
    {
        private static IWebElement _section;
        private static IWebElement _header;
        private static IWebElement _country;
        private static IWebElement _city;
        private static IWebElement _street;

        // create scope to find header for this page and all element in it
        private readonly By _sectionLocator = By.Id("eventForm_section");
        private readonly By _countryLocator = By.Id("eventCountryDropDownSelect");
        private readonly By _cityLocator = By.Id("eventCityDropDownSelect");
        private readonly By _streetLocator = By.Id("bicycleStolenStreetInputText");

        public WhereDidTheIncidentHappen(IWebDriver section)
        {
            var driver = section;
            _section = driver.FindElement(_sectionLocator);
            _country = driver.FindElement(_countryLocator);
            _city = driver.FindElement(_cityLocator);
            _street = driver.FindElement(_streetLocator);
        }

        public string GetCountry()
        {
            return _country.Text;
        }

        public WhereDidTheIncidentHappen SelectCountry(string countryToSelect)
        {
           if (string.IsNullOrEmpty(countryToSelect))
                return this;
            var dropdown = new SelectElement(_country);
            dropdown.SelectByValue(countryToSelect);
            return this;
        }

        public WhereDidTheIncidentHappen EnterStolenStreetText(string streetTextInput)
        {
            if (string.IsNullOrEmpty(streetTextInput))
                return this;
            _street.SendKeys(streetTextInput);
            return this;
        }

        public WhereDidTheIncidentHappen SelectStolenCityText(string cityTextInput)
        {
            if (string.IsNullOrEmpty(cityTextInput))
                return this;
            var dropdown = new SelectElement(_city);
            dropdown.SelectByValue(cityTextInput);
            return this;
        }
    }
}
