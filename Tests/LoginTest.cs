using POM_Basic.Source.Drivers;
using POM_Basic.Source.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_Basic.Tests
{
    public class LoginTest : Driver
    {
          
        [Test]
        public void InvalidLogin()
        {
            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();
            homePage.launchUrl();
            loginPage.Login("test@gmail.com", "password");
            loginPage.VerifyInvalidLogin();
        }
    }
}
