using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace BaseProgram.StepDefinitions
{
    [Binding]
    public class TMSteps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I have logged into to turnup portal")]
        public void GivenIHaveLoggedIntoToTurnupPortal()
        {
            //open url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
​
            LoginPage login = new LoginPage();
            login.LoginSuccess(driver);
        }
        
        [Given(@"I have navigated to time and material page")]
        public void GivenIHaveNavigatedToTimeAndMaterialPage()
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

        }

        [Then(@"I should be able to create time and material page succesfully")]
        public void ThenIShouldBeAbleToCreateTimeAndMaterialPageSuccesfully()
        {
            TimeMaterialPage tm = new TimeMaterialPage();
            tm.ClickCreateNew(driver);
            tm.EnterDetails(driver);
        }
    }
}
