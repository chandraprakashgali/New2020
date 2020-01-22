using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProgram
{
    class LoginPage
    {
        public void LoginSuccess(IWebDriver driver)
        {
            //identify user name 
            IWebElement userName = driver.FindElement(By.Id("UserName"));
            //Give username as hari
            userName.SendKeys("hari");
            //identify password and give its as 123123
            driver.FindElement(By.Id("Password")).SendKeys("123123");​
            IWebElement loginbutton = driver.FindElement(By.XPath("//input[contains(@type,'submit')]"));
            loginbutton.Click();
        }

    }
}
