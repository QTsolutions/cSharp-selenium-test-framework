using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace POM_Basic.Source.Drivers
{
    public  class Driver
    {
        public static IWebDriver _driver;
        [SetUp]
        public void InitSetup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }
        [TearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }

    }
}
