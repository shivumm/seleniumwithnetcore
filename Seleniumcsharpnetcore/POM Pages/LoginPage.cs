using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seleniumcsharpnetcore.POM_Pages
{
    class LoginPage:DriverHelper
    {

        IWebElement linkLoginUsername=> Driver.FindElement(By.Id("UserName"));
        IWebElement linkLoginPassword => Driver.FindElement(By.Id("Password"));

        IWebElement linkLoginbutton => Driver.FindElement(By.XPath("//div/input[@type='submit']"));



        public void EnterUsernamepasswor(string username,string password)
        {
            linkLoginUsername.SendKeys(username);
            linkLoginPassword.SendKeys(password);
        } 

        public void ClickLogin() => linkLoginbutton.Click();

    }
}
