using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProgram
{
    class HomePage
    {
        public void VerifyUsername(IWebDriver driver)
        {
            IWebElement txtusername = driver.FindElement(By.XPath("//a[contains(.,'Hello hari!')]"));
            // if (txtusername.Text == "Hello hari!")
            if ("Hello hari!".Contains(txtusername.Text))
            {
                Console.WriteLine("Test Passed");
                string txt = txtusername.Text;
                Console.WriteLine(txt);
            }​
            else
            {
                Console.WriteLine("Test Failed");
            }​
        }
​
        public void ClickAdministration(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]")).Click();
        }
​
        public void ClickTimeMaterial(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial']")).Click();
        }

    }
}