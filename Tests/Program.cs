using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //add reference to Selenium
            // add reference to Chrome driver
            //open chrome driver
        }
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        public void Login()
        {
            //open url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
​
            LoginPage login = new LoginPage();
            login.LoginSuccess(driver);
        }
        [Test]
        public void CreateNewTMTest()
        {
            HomePage home = new HomePage();
            //verify that username is //a[@href='#'][contains(.,'Hello hari!')]
            home.VerifyUsername(driver);
​
            //Click on Administration button
            home.ClickAdministration(driver);
​
            //Click on Time & Materials button
            home.ClickTimeMaterial(driver);

            TimeMaterialPage tm = new TimeMaterialPage();
            tm.ClickCreateNew(driver);
            tm.EnterDetails(driver);
        }
        [Test]
        public void EditTMTest()
        {
            HomePage home = new HomePage();
            //verify that username is //a[@href='#'][contains(.,'Hello hari!')]
            home.VerifyUsername(driver);
​
            //Click on Administration button
            home.ClickAdministration(driver);
​
            //Click on Time & Materials button
            home.ClickTimeMaterial(driver);

            TimeMaterialPage tm = new TimeMaterialPage();
            tm.EditTMRecord(driver);
        }
        [TearDown]
        public void FlushTests()
        {
            driver.Close();
        }
    }
}
