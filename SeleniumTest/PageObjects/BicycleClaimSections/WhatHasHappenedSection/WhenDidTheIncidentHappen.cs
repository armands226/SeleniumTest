using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumTest.PageObjects.BicycleClaimSections.WhatHasHappenedSection
{
    public class WhenDidTheIncidentHappen
    {
        private static IWebElement _section;
        private static IWebElement _incidentDate;

        public WhenDidTheIncidentHappen(IWebDriver section)
        {
            var driver = section;
            _section = driver.FindElement(_sectionLocator);
            _incidentDate = driver.FindElement(_bicycleStolenDateLocator);
        }

        private readonly By _sectionLocator = By.Id("eventForm_section");
        private readonly By _bicycleStolenDateLocator = By.Name("bicycleStolenDateInputDate");


        public string GetIncidentDate()
        {
            return _incidentDate.Text;
        }

        public void SetIncidentDate(string inputDate)
        {
            _incidentDate.SendKeys(inputDate);
        }

    }
}
