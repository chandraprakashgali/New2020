using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProgram
{
    class TimeMaterialPage
    {
        public void ClickCreateNew(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']")).Click();
        }
​
        public void EnterDetails(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//input[@id='Code']")).SendKeys("99");
            driver.FindElement(By.XPath("//input[contains(@id,'Description')]")).SendKeys("Testing");
            IWebElement price = driver.FindElement(By.XPath("//input[@class='k-formatted-value k-input']"));
            price.SendKeys("11");
            driver.FindElement(By.XPath("//input[contains(@id,'SaveButton')]")).Click();
​
        }
​
        public void VerifyRecord(IWebDriver driver)
        {
            Console.WriteLine("Do the validations here");
        }

        public void EditTMRecord(IWebDriver driver)
        {
            //Implement lines of code to test edit functionality 
        }
    }
}
