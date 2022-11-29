using OpenQA.Selenium;
using POM_Basic.Source.Drivers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_Basic.Source.Pages
{
    public class LoginPage : Driver
    {

        [FindsBy(How = How.Id, Using = "ap_email")]
        private IWebElement _emailTextBox;
        [FindsBy(How = How.Id, Using = "ap_password")]
        private IWebElement _passwordTextBox;
        [FindsBy(How = How.Id, Using = "continue")]
        private IWebElement _continueBtn;
        [FindsBy(How = How.Id, Using = "signInSubmit")]
        private IWebElement _signInBtn;
        [FindsBy(How = How.ClassName, Using = "a-list-item")]
        private IWebElement _errorText;
        public LoginPage()
        {
            PageFactory.InitElements(_driver, this);
        }
        public void Login(string userName, string password)
        {
            HomePage homePage = new HomePage();
            homePage._signInLink.Click();
            _emailTextBox.SendKeys(userName);
            _continueBtn.Click();
            _passwordTextBox.SendKeys(password);
            _signInBtn.Click();
        }
        public void VerifyInvalidLogin()
        {
            string errorTxt = _errorText.Text;
            Assert.True(errorTxt.Contains("Your password is incorrect"));
        }
    }
}
