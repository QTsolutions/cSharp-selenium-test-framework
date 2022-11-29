using OpenQA.Selenium;
using POM_Basic.Source.Drivers;
using POM_Basic.Utilities;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_Basic.Source.Pages
{
    public class HomePage : Driver
    {
        ReadJson json = new ReadJson();
        [FindsBy(How = How.Id,Using = "twotabsearchtextbox")]
        private IWebElement _searchBox;
        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        private IWebElement _searchButton;
        [FindsBy(How = How.Id, Using = "nav-link-accountList")]
        public IWebElement _signInLink;
        public HomePage()
        {
            PageFactory.InitElements(_driver, this);
        }
        public void Search(string searchText)
        {
            _searchBox.SendKeys(searchText);
            _searchButton.Click();
        }
        public void launchUrl()
        {
            _driver.Navigate().GoToUrl(json.ReadData("url"));
        }
    }
}
